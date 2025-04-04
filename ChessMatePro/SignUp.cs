﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessMate_pro
{
    public partial class SignUp : Form
    {

         // SQL-related objects for database operations
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public SignUp()
        {
            InitializeComponent();
             // Set password character and max length for password fields
            password.PasswordChar = '•';
            confirmpassword.PasswordChar = '•';
            password.MaxLength = 50;
            confirmpassword.MaxLength = 50;
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            try
            {

                // Initialize and open database connection
                cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nandini\source\repos\ChessMate-pro\ChessMatePro\Database1.mdf;Integrated Security=True");
                cn.Open();
                //MessageBox.Show("SqlConnection Opened successfully");
            }
            catch (Exception ex)
            {
                // Display error message if database connection fails
                MessageBox.Show("Database connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {

            // Check if database connection is valid
            if (cn == null || cn.State == ConnectionState.Closed)
            {
                MessageBox.Show("Database connection is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate that all fields are filled
            if (!string.IsNullOrWhiteSpace(confirmpassword.Text) &&
                !string.IsNullOrWhiteSpace(password.Text) &&
                !string.IsNullOrWhiteSpace(username.Text) &&
                !string.IsNullOrWhiteSpace(email.Text))
            {
                // Check if passwords match
                if (password.Text == confirmpassword.Text)
                {
                    try
                    {
                        // Check if username exists
                        cmd = new SqlCommand("SELECT * FROM Users WHERE username=@username", cn);
                        cmd.Parameters.AddWithValue("@username", username.Text);
                        dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            dr.Close();
                            MessageBox.Show("This username already exists, please try another", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            dr.Close();
                            // Insert new user into database
                            cmd = new SqlCommand("INSERT INTO Users (username, password, email) VALUES (@username, @password, @email)", cn);
                            cmd.Parameters.AddWithValue("@username", username.Text);
                            cmd.Parameters.AddWithValue("@password", hashPassword(password.Text));
                            cmd.Parameters.AddWithValue("@email", email.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Your account has been created, and you are ready to login now!",
                                "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                         // Display error message if database operation fails
                        MessageBox.Show("Database error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Display error if passwords don't match
                    MessageBox.Show("Passwords are not the same", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                  // Display error if any field is empty
                MessageBox.Show("Please fill out all of the fields", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
       
        }

        private string hashPassword(string inputPassword)
        {
             // Create a new instance of the SHA256 hashing algorithm
            using (SHA256 sha256 = SHA256.Create())
            {
                 // Convert the input password string to a byte array using UTF8 encoding
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(inputPassword));
                // Convert the hashed byte array to a Base64 encoded string
                // This provides a string representation of the hash that's safe for storage
                return Convert.ToBase64String(bytes);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
