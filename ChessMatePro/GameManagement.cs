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



namespace ChessMate_pro
{
    public partial class GameManagement : Form
    {
        private int currentUserID = 1; // Assuming current user ID is 1 
        public GameManagement()
        {
            InitializeComponent();
        }

        private void GameManagement_Load(object sender, EventArgs e)
        {

        }

        private void filteredGameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            FilterGames();
        }

        private void FilterGames()
        {
            using (var context = new ApplicationDbContext()) // EF DbContext
            {
                var query = context.Games
                    .Include(g => g.PGNFile) // Assuming navigation property exists
                    .Where(g => g.UserID == currentUserID) // Only current user's games
                    .AsQueryable();

                // Filter: Event name
                if (!string.IsNullOrWhiteSpace(txtEventName.Text))
                {
                    query = query.Where(g => g.EventName.Contains(txtEventName.Text));
                }

                // Filter: Opponent name
                if (!string.IsNullOrWhiteSpace(txtOpponentName.Text))
                {
                    query = query.Where(g => g.OpponentName.Contains(txtOpponentName.Text));
                }

                // Filter: Date
                if (chkDateFilter.Checked)
                {
                    DateTime selectedDate = dateTimeInput.Value.Date;
                    query = query.Where(g => g.Date.Date == selectedDate);
                }

                // Filter: Result
                if (gameResultWon.Checked)
                {
                    query = query.Where(g => g.Result == "1-0");
                }
                else if (gameResultLost.Checked)
                {
                    query = query.Where(g => g.Result == "0-1");
                }

                // Execute the query
                var filteredGames = query.ToList();

                // Display games in PGN format in the ListBox
                filteredGameListBox.Items.Clear();

                foreach (var game in filteredGames)
                {
                    var pgnFile = game.PGNFile;

                    string pgn = $"[Event \"{game.EventName}\"]\n" +
                                 $"[Date \"{game.Date:yyyy.MM.dd}\"]\n" +
                                 $"[White \"You\"]\n" +
                                 $"[Black \"{game.OpponentName}\"]\n" +
                                 $"[Result \"{game.Result}\"]\n" +
                                 $"[Annotations \"{pgnFile?.Annotations}\"]\n" +
                                 $"[Comments \"{pgnFile?.Comments}\"]\n\n" +
                                 $"{pgnFile?.Moves}";

                    filteredGameListBox.Items.Add(pgn);
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
    }
}
