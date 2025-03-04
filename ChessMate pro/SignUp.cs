using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessMate_pro
{
    public partial class SignUp : Form
    {

        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public SignUp()
        {
            InitializeComponent();
            password.PasswordChar = '•';
            confirmpassword.PasswordChar = '•';
            password.MaxLength = 50;
            confirmpassword.MaxLength = 50;
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\__Students\Somarapu\ChessMate pro\ChessMate pro\Database1.mdf"";Integrated Security=True");
            cn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(confirmpassword.Text) &&
                !string.IsNullOrWhiteSpace(password.Text) &&
                !string.IsNullOrWhiteSpace(username.Text))
            {
                if (password.Text == confirmpassword.Text)
                {
                    try
                    {
                        // Check if username exists
                        cmd = new SqlCommand("SELECT * FROM LoginTable WHERE username=@username", cn);
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
                            cmd = new SqlCommand("INSERT INTO LoginTable (username, password) VALUES (@username, @password)", cn);
                            cmd.Parameters.AddWithValue("@username", username.Text);
                            cmd.Parameters.AddWithValue("@password", password.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Your account has been created, and you are ready to login now!",
                                "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error: " + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Passwords are not the same", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill out all of the fields", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}
