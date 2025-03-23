using ChessMate_pro.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Diagnostics;
using ChessMate_pro;



namespace ChessMate_pro
{
    public partial class GameManagement : Form
    {
        private Guid currentUserID;
        public GameManagement(Guid userID)
        {
            InitializeComponent();
            currentUserID = userID; 
        }

        private void GameManagement_Load(object sender, EventArgs e)
        {

        }

        private void filteredGameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void filterButton_Click(object sender, EventArgs e)
        {
    
            using (var context = new ApplicationDbContext())
            {
                var query = context.Games
                    .Include(g => g.PGNFile)
                    .Where(g => g.UserID == currentUserID)
                    .AsQueryable();

                if (!string.IsNullOrWhiteSpace(txtEventNameFilter.Text))
                {
                    string eventFilter = txtEventNameFilter.Text.Trim();

                    MessageBox.Show("eventFilter =" + eventFilter);

                    query = query.Where(g => g.EventName.Contains(eventFilter));
                }

                if (!string.IsNullOrWhiteSpace(txtOpponentFilter.Text))
                {
                    string opponentFilter = txtOpponentFilter.Text.Trim();
                    query = query.Where(g => g.OpponentName.Contains(opponentFilter));
                }

                if (datePickerFilter.Checked)
                {
                    DateTime selectedDate = datePickerFilter.Value.Date;
                    query = query.Where(g => DbFunctions.TruncateTime(g.Date) == selectedDate);
                }

                if (gameResultWon.Checked)
                {
                    query = query.Where(g => g.Result == "1-0" || g.Result.ToLower() == "win");
                }
                else if (gameResultLost.Checked)
                {
                    query = query.Where(g => g.Result == "0-1" || g.Result.ToLower() == "lose");
                }

                string sql = ((System.Data.Entity.Infrastructure.DbQuery<Game>)query).ToString();
                Debug.WriteLine(sql);
                //MessageBox.Show(sql);
                

                var filteredGames = query.ToList();

                //MessageBox.Show("filteredGames.Count.ToString()=" + filteredGames.Count.ToString());

                filteredGameListBox.Items.Clear();
                selectedPGNDisplay.Clear();

                if (filteredGames.Count == 0)
                {
                    MessageBox.Show("No games found with the selected filters.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (var game in filteredGames)
                {
                    string display = $"{game.EventName} vs {game.OpponentName} - {game.Date.ToShortDateString()} - {game.Result}";
                    filteredGameListBox.Items.Add(new ComboBoxItem { Game = game, DisplayText = display });
                }
            }
        }







        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void filteredGameListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (filteredGameListBox.SelectedItem is ComboBoxItem selectedItem)
            {
                var game = selectedItem.Game;
                var pgnFile = game.PGNFile;

                string pgn = $"[Event \"{game.EventName}\"]\n" +
                             $"[Date \"{game.Date:yyyy.MM.dd}\"]\n" +
                             $"[White \"You\"]\n" +
                             $"[Black \"{game.OpponentName}\"]\n" +
                             $"[Result \"{game.Result}\"]\n" +
                             $"[Annotations \"{pgnFile?.Annotations}\"]\n" +
                             $"[Comments \"{pgnFile?.Comments}\"]\n\n" +
                             $"{pgnFile?.Moves}";

                selectedPGNDisplay.Text = pgn;
            }
        }

        public class ComboBoxItem
        {
            public Game Game { get; set; }
            public string DisplayText { get; set; }

            public override string ToString()
            {
                return DisplayText;
            }
        }

        private void selectedPGNDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEventNameFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PGNGenerator pgnGenerator = new PGNGenerator(null, currentUserID);
            pgnGenerator.ShowDialog();



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
            this.Hide();
            YourAccount yourAccount = new YourAccount(currentUserID);
            yourAccount.Show();
        }
    }
}
