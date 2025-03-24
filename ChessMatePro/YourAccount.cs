using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using ChessMate_pro.Data;

namespace ChessMate_pro
{
    public partial class YourAccount : Form
    {
        private Guid currentUserID;

        public YourAccount(Guid userID)
        {
            InitializeComponent();
            currentUserID = userID;
        }

        private void YourAccount_Load(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                // Load user
                var user = context.Users.FirstOrDefault(u => u.UserID == currentUserID);

                if (user != null)
                {
                    labelEmailValue.Text = user.Email;
                    usernameDisplayLabel.Text = user.Username;
                }

                // Load game stats only for the games that have a PGN file (will have result of 0-1 or 1-0)
                var userGames = context.Games.Where(g => g.UserID == currentUserID && g.PGNFileID != null).ToList();

                if (userGames.Count == 0)
                {
                    labelWinsValue.Text = "0";
                    labelLossesValue.Text = "0";
                    
                    return;
                }
                else
                {
                    int wins = userGames.Count(g => g.Result == "1-0" || g.Result.ToLower() == "win");
                    int losses = userGames.Count(g => g.Result == "0-1" || g.Result.ToLower() == "lose");
                    labelWinsValue.Text = wins.ToString();
                    labelLossesValue.Text = losses.ToString();
                }

            }
        }

        private void labelUsernameValue_Click(object sender, EventArgs e)
        {

        }

        private void labelEmailValue_Click(object sender, EventArgs e)
        {

        }

        private void viewGamesMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameManagement gameManagement = new GameManagement(currentUserID);
            gameManagement.ShowDialog();
        }

        private void scheduleGamesMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScheduleGames scheduleGames = new ScheduleGames(currentUserID);
            scheduleGames.ShowDialog();
        }

        private void upcomingGamesMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpcomingGames upcomingGames = new UpcomingGames(currentUserID);
            upcomingGames.ShowDialog();
        }

        private void yourAccountMenuButton_Click(object sender, EventArgs e)
        {

        }

        private void menuPGNButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PGNGenerator pgnGenerator = new PGNGenerator(null, currentUserID);
            pgnGenerator.ShowDialog();
        }

        private void newAccountButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void usernameDisplayLabel_Click(object sender, EventArgs e)
        {

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void gamesPlayedValueLabel_Click(object sender, EventArgs e)
        {

        }
    }
}



