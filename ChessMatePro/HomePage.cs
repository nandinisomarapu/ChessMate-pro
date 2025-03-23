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
    public partial class HomePage : Form
    {
        Guid currentUserID; 
        public HomePage(Guid userID)
        {
            InitializeComponent();
            currentUserID = userID; 
        }

        // Event handler for PGN Generator button click
        private void PGNGeneratorButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Create a blank/default PGNGameData object
            PGNGameData blankData = new PGNGameData
            {
                EventName = "",
                GameDate = DateTime.Now,
                OpponentName = "",
                Result = "*",
                Moves = new List<string>()
            };

            // Pass both parameters to the constructor
            PGNGenerator pGNGenerator = new PGNGenerator(null, currentUserID);
            pGNGenerator.ShowDialog();
        }





        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameManagement gameManagement = new GameManagement(currentUserID);
            gameManagement.Show();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            YourAccount yourAccount = new YourAccount(currentUserID);
            yourAccount.Show();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
