using ChessMate_pro.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ChessMate_pro.GameManagement;

namespace ChessMate_pro
{
    public partial class UpcomingGames: Form
    {
        private Guid currentUserID;

        private List<Game> scheduledGames;

        public UpcomingGames(Guid userID )
        {
            InitializeComponent();
            currentUserID = userID;
        }

        private void UpcomingGames_Load(object sender, EventArgs e)
        {

            using (var context = new ApplicationDbContext())
            {
                var query = context.Games                    
                    .Where(g => g.UserID == currentUserID && g.PGNFileID == null)
                    .OrderBy(g => g.Date)
                    .AsQueryable();

             

                string sql = ((System.Data.Entity.Infrastructure.DbQuery<Game>)query).ToString();
                Debug.WriteLine(sql);
                MessageBox.Show(sql);


                scheduledGames = query.ToList();

                //MessageBox.Show("filteredGames.Count.ToString()=" + filteredGames.Count.ToString());

                gamesListBox.Items.Clear();
             
                if (scheduledGames.Count == 0)
                {
                    MessageBox.Show("No Scheduled games found for the user.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (var game in scheduledGames)
                {
                    string display = $"{game.EventName} vs {game.OpponentName} - {game.Date.ToShortDateString()}";
                    gamesListBox.Items.Add(new ComboBoxItem { Game = game, DisplayText = display });
                }
            }


        }

        private void openInPGNGeneratorButton_Click_1(object sender, EventArgs e)
        {

            if (gamesListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a game first.");
                return;
            }

            this.Hide();
            PGNGenerator generator = new PGNGenerator(scheduledGames.ElementAt(gamesListBox.SelectedIndex), currentUserID);
            generator.ShowDialog();

        }

        private void gamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (gamesListBox.SelectedIndex == -1) return;

            string pgn = $"Event: {scheduledGames.ElementAt(gamesListBox.SelectedIndex).EventName}\n" +
                        $"OpponentName: {scheduledGames.ElementAt(gamesListBox.SelectedIndex).OpponentName}\n" +
                        $"Date: {scheduledGames.ElementAt(gamesListBox.SelectedIndex).Date:yyyy.MM.dd}";

            selectedGameDataBox.Text = pgn;
        }
    }
}
