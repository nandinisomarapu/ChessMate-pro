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
        public ExportFile(string eventName, DateTime date, string opponentName, string result, List<string> moves)
        {
            InitializeComponent();

            string allMoves = string.Join(" ", moves);

            string pgn = $"[Event \"{eventName}\"]\n" +
                         $"[Date \"{date:yyyy.MM.dd}\"]\n" +
                         $"[White \"You\"]\n" +
                         $"[Black \"{opponentName}\"]\n" +
                         $"[Result \"{result}\"]\n\n" +
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
    }
}
