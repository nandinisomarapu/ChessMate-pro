using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ChessMate_pro
{
    public partial class Login : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public Login()
        {
            InitializeComponent();
            password.PasswordChar = '•';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void Login_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nandini\source\repos\ChessMate-pro\ChessMatePro\Database1.mdf;Integrated Security=True");
            cn.Open();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.ShowDialog();

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.ShowDialog();

        }



        private void loginButton_Clicked(object sender, EventArgs e)
        {

             // Check if the database connection is initialized and open
            if (cn == null || cn.State == ConnectionState.Closed)
            {
                MessageBox.Show("Database connection is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

             // Validate that both username and password fields are not empty
            if (!string.IsNullOrWhiteSpace(password.Text) &&
                !string.IsNullOrWhiteSpace(username.Text))
            {
                try
                {
                    // Hash the entered password for secure comparison
                    string hashedPassword = hashPassword(password.Text);

                    // Prepare SQL command to authenticate user
                    cmd = new SqlCommand("SELECT userid, username FROM UserTable WHERE username=@username AND password=@hashedPassword", cn);
                    cmd.Parameters.AddWithValue("@username", username.Text);
                    cmd.Parameters.AddWithValue("@hashedPassword", hashedPassword);

                    // Execute the query and get the result
                    dr = cmd.ExecuteReader();

                   // Check if a matching user was found
                    if (dr.HasRows)
                    {

                        dr.Read();  

                        Guid userID = dr.GetGuid(0);

                        dr.Close();


                         // Hide the current form and show the HomePage
                        this.Hide();
                        HomePage homePage = new HomePage(userID);
                        homePage.ShowDialog();
                    }
                    else
                    {
                        dr.Close();
                         // Display error message for invalid credentials
                        MessageBox.Show("Username and/or Password are incorrect.  Enter valid credentials to Login!",
                            "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    if (dr != null && !dr.IsClosed)
                    {
                        dr.Close();
                    }
                    // Handle and display any database errors
                    MessageBox.Show("Database error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                // Display error message if username or password field is empty
                MessageBox.Show("Please fill out all of the fields", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        // Hash the password using SHA256 - as we don't store password as plaintext in the database during signup to follow security best practice
        private string hashPassword(string inputPassword)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(inputPassword));
                return Convert.ToBase64String(bytes);
            }

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }

}
  
