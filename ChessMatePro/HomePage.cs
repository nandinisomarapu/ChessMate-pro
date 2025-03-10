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
        public HomePage()
        {
            InitializeComponent();
        }

        private void PGNGeneratorButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PGNGenerator pGNGenerator = new PGNGenerator();
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
