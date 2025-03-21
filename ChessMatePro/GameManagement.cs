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



namespace ChessMate_pro
{
    public partial class GameManagement : Form
    {
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
            using (var context = new ApplicationDbContext()) // Database Context
            {
                var query = context.Games.AsQueryable(); // Start LINQ query

                // Apply Event Name filter if input is provided
                if (!string.IsNullOrWhiteSpace(txtEventName.Text))
                {
                    query = query.Where(g => g.EventName.Contains(txtEventName.Text));
                }

                // Apply Opponent Name filter if input is provided
                if (!string.IsNullOrWhiteSpace(txtOpponentName.Text))
                {
                    query = query.Where(g => g.OpponentName.Contains(txtOpponentName.Text));
                }

                // Apply Date Filter (if checkbox checked)
                if (chkDateFilter.Checked)
                {
                    DateTime selectedDate = dateTimeInput.Value.Date;
                    query = query.Where(g => g.Date.Date == selectedDate);
                }

                // Apply Win/Loss filter based on radio button selection
                if (gameResultWon.Checked)
                {
                    query = query.Where(g => g.Result == "1-0");
                }
                else if (gameResultLost.Checked)
                {
                    query = query.Where(g => g.Result == "0-1");
                }

                // Execute the query and convert results to a list
                var filteredGames = query.ToList();

                // Display results in the ListBox
                filteredGameListBox.Items.Clear();
                foreach (var game in filteredGames)
                {
                    filteredGameListBox.Items.Add($"{game.EventName} - {game.OpponentName} ({game.Date.ToShortDateString()}) - {game.Result}");
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
