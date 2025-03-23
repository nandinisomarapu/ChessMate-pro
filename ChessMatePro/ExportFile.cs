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

namespace ChessMate_pro
{
    public partial class ExportFile : Form
    {
        private Guid currentUserID;
        private PGNGameData gameData;

        public ExportFile(Guid userID, PGNGameData data)
        {
            InitializeComponent();
            currentUserID = userID;
            gameData = data;

            string allMoves = string.Join(" ", data.Moves);

            string pgn = $"[Event \"{data.EventName}\"]\n" +
                         $"[Date \"{data.GameDate:yyyy.MM.dd}\"]\n" +
                         $"[White \"You\"]\n" +
                         $"[Black \"{data.OpponentName}\"]\n" +
                         $"[Result \"{data.Result}\"]\n\n" +
                         $"{allMoves}";

            pgnTextDisplay.Text = pgn;
        }



        private void pgnTextDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PGN Files (*.pgn)|*.pgn",
                Title = "Save PGN File",
                FileName = "MyChessGame.pgn"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, pgnTextDisplay.Text, Encoding.UTF8);
                    MessageBox.Show("PGN file exported successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to export PGN file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }






        }

        private void menuPGNButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PGNGenerator pGNGenerator = new PGNGenerator(null, currentUserID);
            pGNGenerator.ShowDialog();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameManagement gameManagement = new GameManagement(currentUserID);
            gameManagement.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide(); // Hide export form
            PGNGenerator generator = new PGNGenerator(null, currentUserID);
            generator.Show(); // Go back with preserved data
            this.Close(); // Optional: fully close export form

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
