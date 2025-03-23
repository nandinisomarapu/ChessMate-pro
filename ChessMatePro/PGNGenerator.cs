using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ChessMate_pro
{
    public partial class PGNGenerator : Form
    {
        private Game game;
        private Guid currentUserID;
        private Game scheduledGame;
        public PGNGenerator(Game game, Guid userID)
        {
            InitializeComponent();
            scheduledGame = game;
            //Bind components/load game properties
            currentUserID = userID;
            if (game != null)
            {
                // Pre-fill fields
                eventNameInput.Text = game.EventName;
                opponentNameInput.Text = game.OpponentName;
                dateTimePicker1.Value = game.Date;

                if (game.Result == "1-0") radioButtonWin.Checked = true;
                else if (game.Result == "0-1") radioButtonLose.Checked = true;

                // Populate move table (optional — assuming you parse each move)
                foreach (var move in game.MoveList)
                {
                    moveTable.Rows.Add(/* parse and add cells from move string */);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get basic input from the user
            string eventName = eventNameInput.Text.Trim();
            DateTime gameDate = dateTimePicker1.Value.Date;
            string opponentName = opponentNameInput.Text.Trim();

            // Determine game result
            string result = radioButtonWin.Checked ? "1-0" :
                            radioButtonLose.Checked ? "0-1" : "*";

            // Build list of moves from the moveTable (DataGridView)
            List<string> moveList = new List<string>();
            foreach (DataGridViewRow row in moveTable.Rows)
            {
                if (!row.IsNewRow)
                {
                    string moveNum = row.Cells[0].Value?.ToString() ?? "";
                    string whiteMove = row.Cells[1].Value?.ToString() ?? "";
                    string blackMove = row.Cells[2].Value?.ToString() ?? "";
                    string annotation = row.Cells[3].Value?.ToString() ?? "";
                    string comment = row.Cells[4].Value?.ToString() ?? "";

                    // Format PGN-style move: 1. e4 e5 {Annotation} ; Comment
                    string formattedMove = $"{moveNum}. {whiteMove} {blackMove}";

                    if (!string.IsNullOrWhiteSpace(annotation))
                        formattedMove += $" {{{annotation}}}";

                    if (!string.IsNullOrWhiteSpace(comment))
                        formattedMove += $" ; {comment}";

                    moveList.Add(formattedMove);
                }
            }
            PGNGameData gameData = new PGNGameData
            {
                EventName = eventName,
                GameDate = gameDate,
                OpponentName = opponentName,
                Result = result,
                Moves = moveList
            };


            // Open ExportFile form and pass all the data
            this.Hide();
            ExportFile exportFile = new ExportFile(currentUserID, gameData);
            exportFile.ShowDialog();
        }





        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void SaveToFile(String filePath)
        {
            try
            {
                // Convert game to string representation and write to the specified file using UTF-8 encoding
                File.WriteAllText(filePath, this.game.GenerateGameAsString(), Encoding.UTF8);

            }
            catch (Exception ex)
            {
                // Display error message if file writing fails, including the original exception message
                MessageBox.Show("Error: Could not write game to file. Original error: " + ex.Message);
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void saveFileButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(eventNameInput.Text.Trim()) &&
               !string.IsNullOrWhiteSpace(opponentNameInput.Text.Trim()) &&
                    (radioButtonWin.Checked || radioButtonLose.Checked))
            {
                string eventName = eventNameInput.Text.Trim();
                DateTime gameDate = dateTimePicker1.Value.Date;
                string opponentName = opponentNameInput.Text.Trim();
                string result = radioButtonWin.Checked ? "Win" : radioButtonLose.Checked ? "Lose" : "Unknown";

                // Build PGN-related text from moveTable
                List<string> moves = new List<string>();
                List<string> annotations = new List<string>();
                List<string> comments = new List<string>();

                foreach (DataGridViewRow row in moveTable.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string moveNum = row.Cells[0].Value?.ToString() ?? "";
                        string whiteMove = row.Cells[1].Value?.ToString() ?? "";
                        string blackMove = row.Cells[2].Value?.ToString() ?? "";
                        string annotation = row.Cells[3].Value?.ToString() ?? "";
                        string comment = row.Cells[4].Value?.ToString() ?? "";

                        moves.Add($"{moveNum}. {whiteMove} {blackMove}");
                        annotations.Add(annotation);
                        comments.Add(comment);
                    }
                }

                string movesText = string.Join(" ", moves);
                string annotationsText = string.Join(" | ", annotations);
                string commentsText = string.Join(" | ", comments);

                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nandini\source\repos\ChessMate-pro\ChessMatePro\Database1.mdf;Integrated Security=True"))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // Insert into PGNFiles
                        SqlCommand insertPGN = new SqlCommand(
                            @"INSERT INTO PGNFiles (moves, annotations, comments, exportstatus)
                  OUTPUT INSERTED.PGNFileID
                  VALUES (@Moves, @Annotations, @Comments, 0)", conn, transaction);

                        insertPGN.Parameters.AddWithValue("@Moves", movesText);
                        insertPGN.Parameters.AddWithValue("@Annotations", annotationsText);
                        insertPGN.Parameters.AddWithValue("@Comments", commentsText);

                        Guid pgnFileId = (Guid)insertPGN.ExecuteScalar();

                        if (scheduledGame != null)
                        {
                            // Update the scheduled game with the PGNFileID
                            SqlCommand updateGame = new SqlCommand(
                                @"UPDATE Games
                      SET pgnfileid = @PGNFileID
                      WHERE gameid = @GameID", conn, transaction);
                            updateGame.Parameters.AddWithValue("@PGNFileID", pgnFileId);
                            updateGame.Parameters.AddWithValue("@GameID", scheduledGame.GameID);
                            updateGame.ExecuteNonQuery();
                        }
                        else
                        {
                            // Insert into Game table
                            SqlCommand insertGame = new SqlCommand(
                                @"INSERT INTO Games (eventname, date, opponentname, result, pgnfileid, userid)
                      VALUES (@EventName, @Date, @OpponentName, @Result, @PGNFileID, @UserID)", conn, transaction);
                            insertGame.Parameters.AddWithValue("@EventName", eventName);
                            insertGame.Parameters.AddWithValue("@Date", gameDate);
                            insertGame.Parameters.AddWithValue("@OpponentName", opponentName);
                            insertGame.Parameters.AddWithValue("@Result", result);
                            insertGame.Parameters.AddWithValue("@PGNFileID", pgnFileId);
                            //MessageBox.Show("Saving with UserID: " + currentUserID.ToString() + " Type: " + currentUserID.GetType());
                            //MessageBox.Show("Saving with PGNFileID: " + pgnFileId.ToString() + " Type: " + pgnFileId.GetType());
                            insertGame.Parameters.AddWithValue("@UserID", currentUserID);
                            insertGame.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Game successfully saved!");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error saving game: " + ex.Message +
                         (ex.InnerException != null ? "\nInner: " + ex.InnerException.Message : ""));


                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill in all required fields (Event Name, Opponent Name, and Game Result) before saving the game.");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            GameManagement gameManagement = new GameManagement(currentUserID);
            gameManagement.ShowDialog();
        }

        private void menuPGNButton_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScheduleGames scheduleGames = new ScheduleGames(currentUserID);
            scheduleGames.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpcomingGames upcomingGames = new UpcomingGames(currentUserID);
            upcomingGames.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            YourAccount yourAccount = new YourAccount(currentUserID);
            yourAccount.Show();
        }
    }
}
    



