﻿using System;
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
    public partial class PGNGenerator : Form
    {
        private Game game;
        public PGNGenerator()
        {
            InitializeComponent();
            game = new Game();
            //Bind components/load game properties
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();    

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExportFile exportFile = new ExportFile();
            exportFile.ShowDialog();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void SaveToFile(String filePath)
        {
            try
            {
                // Convert game to string representation and write to the specified file using UTF-8 encoding
                File.WriteAllText(filePath, this.game.GenerateGameAsString(), Encoding.UTF8);

            }
            catch (Exception ex)
            {
                // Display error message if file writing fails, including the original exception message
                MessageBox.Show("Error: Could not write game to file. Original error: " + ex.Message);
            }
        }
    }
}


