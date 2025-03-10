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
    public partial class ExportFile : Form
    {
        public ExportFile()
        {
            InitializeComponent();
        }

        public void SaveToFile(String filePath)
        {
            try
            {
                File.WriteAllText(filePath, GeneratePGN(), Encoding.UTF8);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not write game to file. Original error: " + ex.Message);
            }
        }
    }
}
