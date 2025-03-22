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
            // Hide the current form
            this.Hide();

            // Create and show the PGN Generator form
            PGNGenerator pGNGenerator = new PGNGenerator(currentUserID);
            pGNGenerator.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameManagement gameManagement = new GameManagement();
            gameManagement.Show();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            YourAccount yourAccount = new YourAccount();
            yourAccount.Show();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
