namespace ChessMate_pro
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            // Dispose of managed resources if the 'disposing' flag is true
            if (disposing && (components != null))
            {
                components.Dispose();
            }
             // Call the base class Dispose method
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // Initialize a ResourceManager for accessing resources in the current assembly
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            // Create a new Button control for PGN Generator
            this.PGNGeneratorButton = new System.Windows.Forms.Button();


            // PGNGeneratorButton
            // // Configure properties for the PGNGeneratorButton
            this.PGNGeneratorButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.PGNGeneratorButton.Location = new System.Drawing.Point(73, 223);
            this.PGNGeneratorButton.Name = "PGNGeneratorButton";
            this.PGNGeneratorButton.Size = new System.Drawing.Size(163, 149);
            this.PGNGeneratorButton.TabIndex = 4;
            this.PGNGeneratorButton.Text = "PGN Generator";
            this.PGNGeneratorButton.UseVisualStyleBackColor = false;
            this.PGNGeneratorButton.Click += new System.EventHandler(this.PGNGeneratorButton_Click);

            this.pictureBox1 = new System.Windows.Forms.PictureBox();

            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(291, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 

            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSlateGray;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(312, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 149);
            this.button2.TabIndex = 5;
            this.button2.Text = "Game Management";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSlateGray;
            this.button3.Location = new System.Drawing.Point(539, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 149);
            this.button3.TabIndex = 6;
            this.button3.Text = "Your Account";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(70, 400);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(220, 20, 220, 20);
            this.label1.Size = new System.Drawing.Size(632, 53);
            this.label1.TabIndex = 7;
            this.label1.Text = "Click on one of the options to continue!";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(880, 551);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PGNGeneratorButton);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "HomePage";
            this.Text = "PGN Generator";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PGNGeneratorButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}
