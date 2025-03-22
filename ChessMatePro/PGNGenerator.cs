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

namespace ChessMate_pro
{
    public partial class PGNGenerator : Form
    {
        private Game game;
        private Guid currentUserID;
        public PGNGenerator(Guid userID)
        {
            InitializeComponent();
            game = new Game();
            //Bind components/load game properties
            currentUserID = userID;
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

            // Open ExportFile form and pass all the data
            this.Hide();
            ExportFile exportFile = new ExportFile(currentUserID, eventName, gameDate, opponentName, result, moveList);
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


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameManagement gameManagement = new GameManagement(currentUserID);
            gameManagement.ShowDialog();
        }

        private void menuPGNButton_Click(object sender, EventArgs e)
        {

        }
    }
}



