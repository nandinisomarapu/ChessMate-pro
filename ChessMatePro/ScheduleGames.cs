using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessMate_pro
{
    public partial class ScheduleGames: Form
    {
        public static List<PGNGameData> ScheduledGames = new List<PGNGameData>();
        private Guid currentUserID;

        public ScheduleGames(Guid userID)
        {
            InitializeComponent();
            currentUserID = userID;
        }

        private void opponentNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void scheduleGameButton_Click(object sender, EventArgs e)
        {
            string eventName = eventNameInput.Text.Trim();
            string opponentName = opponentNameInput.Text.Trim();
            DateTime gameDate = futureGameDateInput.Value.Date;

            if (string.IsNullOrWhiteSpace(eventName) || string.IsNullOrWhiteSpace(opponentName))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nandini\source\repos\ChessMate-pro\ChessMatePro\Database1.mdf;Integrated Security=True"))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
              
                    // Insert into Game table
                    SqlCommand insertGame = new SqlCommand(
                        @"INSERT INTO Games (eventname, date, opponentname, userid)
                  VALUES (@EventName, @Date, @OpponentName, @UserID)", conn, transaction);

                    insertGame.Parameters.AddWithValue("@EventName", eventName);
                    insertGame.Parameters.AddWithValue("@Date", gameDate);
                    insertGame.Parameters.AddWithValue("@OpponentName", opponentName);


                    //MessageBox.Show("Saving with UserID: " + currentUserID.ToString() + " Type: " + currentUserID.GetType());
                    //MessageBox.Show("Saving with PGNFileID: " + pgnFileId.ToString() + " Type: " + pgnFileId.GetType());

                    insertGame.Parameters.AddWithValue("@UserID", currentUserID);

                    insertGame.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Game scheduled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error saving game: " + ex.Message +
                     (ex.InnerException != null ? "\nInner: " + ex.InnerException.Message : ""));


                }
            }       

            // Optional: clear fields
            eventNameInput.Clear();
            opponentNameInput.Clear();
            futureGameDateInput.Value = DateTime.Today;


        }

        private void upcomingGamesMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpcomingGames upcomingGames = new UpcomingGames(currentUserID);
            upcomingGames.ShowDialog();
        }

        private void viewGamesMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameManagement gameManagement = new GameManagement(currentUserID);
            gameManagement.ShowDialog();
        }

        private void yourAccountMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            YourAccount yourAccount = new YourAccount(currentUserID);
            yourAccount.Show();
        }

        private void menuPGNButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PGNGenerator pgnGenerator = new PGNGenerator(null, currentUserID);
            pgnGenerator.ShowDialog();
        }
    }
}
