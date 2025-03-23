namespace ChessMate_pro
{
    partial class GameManagement
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameManagement));
            this.filterButton = new System.Windows.Forms.Button();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.txtOpponentName = new System.Windows.Forms.TextBox();
            this.datePickerFilter = new System.Windows.Forms.DateTimePicker();
            this.gameResultLost = new System.Windows.Forms.RadioButton();
            this.gameResultWon = new System.Windows.Forms.RadioButton();
            this.chkDateFilter = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FilterGamesLabel = new System.Windows.Forms.Label();
            this.GameInformationLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEventNameFilter = new System.Windows.Forms.TextBox();
            this.txtOpponentFilter = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.gameResultLabel = new System.Windows.Forms.Label();
            this.gameInformationBacking = new System.Windows.Forms.Label();
            this.gameManagementBackground = new System.Windows.Forms.PictureBox();
            this.filteredGameListBox = new System.Windows.Forms.ListBox();
            this.selectedPGNDisplay = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yourAccountMenuButton = new System.Windows.Forms.Button();
            this.upcomingGamesMenuButton = new System.Windows.Forms.Button();
            this.scheduleGamesMenuButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuPGNButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameManagementBackground)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.filterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterButton.Location = new System.Drawing.Point(196, 348);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(199, 33);
            this.filterButton.TabIndex = 0;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = false;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // txtEventName
            // 
            this.txtEventName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtEventName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEventName.Location = new System.Drawing.Point(195, 132);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(200, 16);
            this.txtEventName.TabIndex = 1;
            this.txtEventName.Text = "Event Name";
            this.txtEventName.UseWaitCursor = true;
            // 
            // txtOpponentName
            // 
            this.txtOpponentName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtOpponentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOpponentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtOpponentName.Location = new System.Drawing.Point(195, 179);
            this.txtOpponentName.Name = "txtOpponentName";
            this.txtOpponentName.Size = new System.Drawing.Size(100, 16);
            this.txtOpponentName.TabIndex = 2;
            this.txtOpponentName.Text = "Opponent Name";
            // 
            // datePickerFilter
            // 
            this.datePickerFilter.Location = new System.Drawing.Point(222, 252);
            this.datePickerFilter.Name = "datePickerFilter";
            this.datePickerFilter.Size = new System.Drawing.Size(173, 20);
            this.datePickerFilter.TabIndex = 3;
            // 
            // gameResultLost
            // 
            this.gameResultLost.AutoSize = true;
            this.gameResultLost.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gameResultLost.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gameResultLost.Location = new System.Drawing.Point(201, 314);
            this.gameResultLost.Name = "gameResultLost";
            this.gameResultLost.Size = new System.Drawing.Size(43, 17);
            this.gameResultLost.TabIndex = 4;
            this.gameResultLost.TabStop = true;
            this.gameResultLost.Text = "0 -1";
            this.gameResultLost.UseVisualStyleBackColor = false;
            // 
            // gameResultWon
            // 
            this.gameResultWon.AutoSize = true;
            this.gameResultWon.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gameResultWon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gameResultWon.Location = new System.Drawing.Point(265, 314);
            this.gameResultWon.Name = "gameResultWon";
            this.gameResultWon.Size = new System.Drawing.Size(46, 17);
            this.gameResultWon.TabIndex = 5;
            this.gameResultWon.TabStop = true;
            this.gameResultWon.Text = "1 - 0";
            this.gameResultWon.UseVisualStyleBackColor = false;
            // 
            // chkDateFilter
            // 
            this.chkDateFilter.AutoSize = true;
            this.chkDateFilter.Location = new System.Drawing.Point(201, 258);
            this.chkDateFilter.Name = "chkDateFilter";
            this.chkDateFilter.Size = new System.Drawing.Size(15, 14);
            this.chkDateFilter.TabIndex = 7;
            this.chkDateFilter.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(192, 34);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(230, 10, 230, 10);
            this.label1.Size = new System.Drawing.Size(572, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filter and View Games";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FilterGamesLabel
            // 
            this.FilterGamesLabel.AutoSize = true;
            this.FilterGamesLabel.BackColor = System.Drawing.Color.LightSlateGray;
            this.FilterGamesLabel.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.FilterGamesLabel.Location = new System.Drawing.Point(194, 100);
            this.FilterGamesLabel.Name = "FilterGamesLabel";
            this.FilterGamesLabel.Padding = new System.Windows.Forms.Padding(72, 4, 72, 4);
            this.FilterGamesLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FilterGamesLabel.Size = new System.Drawing.Size(209, 21);
            this.FilterGamesLabel.TabIndex = 10;
            this.FilterGamesLabel.Text = "Filter Games";
            this.FilterGamesLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // GameInformationLabel
            // 
            this.GameInformationLabel.AutoSize = true;
            this.GameInformationLabel.BackColor = System.Drawing.Color.LightSlateGray;
            this.GameInformationLabel.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.GameInformationLabel.Location = new System.Drawing.Point(445, 100);
            this.GameInformationLabel.Name = "GameInformationLabel";
            this.GameInformationLabel.Padding = new System.Windows.Forms.Padding(110, 4, 110, 4);
            this.GameInformationLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GameInformationLabel.Size = new System.Drawing.Size(310, 21);
            this.GameInformationLabel.TabIndex = 15;
            this.GameInformationLabel.Text = "Game Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(191, 97);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(102, 140, 102, 140);
            this.label2.Size = new System.Drawing.Size(214, 293);
            this.label2.TabIndex = 16;
            this.label2.Text = " ";
            // 
            // txtEventNameFilter
            // 
            this.txtEventNameFilter.Location = new System.Drawing.Point(195, 155);
            this.txtEventNameFilter.Name = "txtEventNameFilter";
            this.txtEventNameFilter.Size = new System.Drawing.Size(199, 20);
            this.txtEventNameFilter.TabIndex = 17;
            this.txtEventNameFilter.TextChanged += new System.EventHandler(this.txtEventNameFilter_TextChanged);
            // 
            // txtOpponentFilter
            // 
            this.txtOpponentFilter.Location = new System.Drawing.Point(195, 202);
            this.txtOpponentFilter.Name = "txtOpponentFilter";
            this.txtOpponentFilter.Size = new System.Drawing.Size(200, 20);
            this.txtOpponentFilter.TabIndex = 18;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateLabel.Location = new System.Drawing.Point(194, 229);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(38, 17);
            this.dateLabel.TabIndex = 19;
            this.dateLabel.Text = "Date";
            // 
            // gameResultLabel
            // 
            this.gameResultLabel.AutoSize = true;
            this.gameResultLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gameResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gameResultLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gameResultLabel.Location = new System.Drawing.Point(194, 290);
            this.gameResultLabel.Name = "gameResultLabel";
            this.gameResultLabel.Size = new System.Drawing.Size(90, 17);
            this.gameResultLabel.TabIndex = 20;
            this.gameResultLabel.Text = "Game Result";
            // 
            // gameInformationBacking
            // 
            this.gameInformationBacking.AutoSize = true;
            this.gameInformationBacking.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gameInformationBacking.Location = new System.Drawing.Point(442, 97);
            this.gameInformationBacking.Name = "gameInformationBacking";
            this.gameInformationBacking.Padding = new System.Windows.Forms.Padding(153, 140, 153, 140);
            this.gameInformationBacking.Size = new System.Drawing.Size(316, 293);
            this.gameInformationBacking.TabIndex = 21;
            this.gameInformationBacking.Text = " ";
            // 
            // gameManagementBackground
            // 
            this.gameManagementBackground.Image = ((System.Drawing.Image)(resources.GetObject("gameManagementBackground.Image")));
            this.gameManagementBackground.Location = new System.Drawing.Point(-2, -1);
            this.gameManagementBackground.Name = "gameManagementBackground";
            this.gameManagementBackground.Size = new System.Drawing.Size(804, 450);
            this.gameManagementBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gameManagementBackground.TabIndex = 22;
            this.gameManagementBackground.TabStop = false;
            // 
            // filteredGameListBox
            // 
            this.filteredGameListBox.FormattingEnabled = true;
            this.filteredGameListBox.Location = new System.Drawing.Point(445, 127);
            this.filteredGameListBox.Name = "filteredGameListBox";
            this.filteredGameListBox.Size = new System.Drawing.Size(120, 251);
            this.filteredGameListBox.TabIndex = 23;
            this.filteredGameListBox.SelectedIndexChanged += new System.EventHandler(this.filteredGameListBox_SelectedIndexChanged_1);
            // 
            // selectedPGNDisplay
            // 
            this.selectedPGNDisplay.Location = new System.Drawing.Point(572, 127);
            this.selectedPGNDisplay.Name = "selectedPGNDisplay";
            this.selectedPGNDisplay.Size = new System.Drawing.Size(180, 251);
            this.selectedPGNDisplay.TabIndex = 24;
            this.selectedPGNDisplay.Text = "";
            this.selectedPGNDisplay.TextChanged += new System.EventHandler(this.selectedPGNDisplay_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.yourAccountMenuButton);
            this.panel1.Controls.Add(this.upcomingGamesMenuButton);
            this.panel1.Controls.Add(this.scheduleGamesMenuButton);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.menuPGNButton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(25, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 235);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // yourAccountMenuButton
            // 
            this.yourAccountMenuButton.Location = new System.Drawing.Point(0, 203);
            this.yourAccountMenuButton.Name = "yourAccountMenuButton";
            this.yourAccountMenuButton.Size = new System.Drawing.Size(120, 23);
            this.yourAccountMenuButton.TabIndex = 7;
            this.yourAccountMenuButton.Text = "Your Account";
            this.yourAccountMenuButton.UseVisualStyleBackColor = true;
            this.yourAccountMenuButton.Click += new System.EventHandler(this.yourAccountMenuButton_Click);
            // 
            // upcomingGamesMenuButton
            // 
            this.upcomingGamesMenuButton.Location = new System.Drawing.Point(0, 139);
            this.upcomingGamesMenuButton.Name = "upcomingGamesMenuButton";
            this.upcomingGamesMenuButton.Size = new System.Drawing.Size(120, 23);
            this.upcomingGamesMenuButton.TabIndex = 6;
            this.upcomingGamesMenuButton.Text = "Upcoming Games";
            this.upcomingGamesMenuButton.UseVisualStyleBackColor = true;
            this.upcomingGamesMenuButton.Click += new System.EventHandler(this.upcomingGamesMenuButton_Click);
            // 
            // scheduleGamesMenuButton
            // 
            this.scheduleGamesMenuButton.Location = new System.Drawing.Point(0, 110);
            this.scheduleGamesMenuButton.Name = "scheduleGamesMenuButton";
            this.scheduleGamesMenuButton.Size = new System.Drawing.Size(120, 23);
            this.scheduleGamesMenuButton.TabIndex = 5;
            this.scheduleGamesMenuButton.Text = "Schedule Games";
            this.scheduleGamesMenuButton.UseVisualStyleBackColor = true;
            this.scheduleGamesMenuButton.Click += new System.EventHandler(this.scheduleGamesMenuButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "View Games";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // menuPGNButton
            // 
            this.menuPGNButton.Location = new System.Drawing.Point(4, 24);
            this.menuPGNButton.Name = "menuPGNButton";
            this.menuPGNButton.Size = new System.Drawing.Size(116, 23);
            this.menuPGNButton.TabIndex = 3;
            this.menuPGNButton.Text = "PGN Generator";
            this.menuPGNButton.UseVisualStyleBackColor = true;
            this.menuPGNButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(0, 184);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Account";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(1, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Game Management";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Game Tools";
            // 
            // GameManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.selectedPGNDisplay);
            this.Controls.Add(this.filteredGameListBox);
            this.Controls.Add(this.gameResultLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.txtOpponentFilter);
            this.Controls.Add(this.txtEventNameFilter);
            this.Controls.Add(this.GameInformationLabel);
            this.Controls.Add(this.FilterGamesLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkDateFilter);
            this.Controls.Add(this.gameResultWon);
            this.Controls.Add(this.gameResultLost);
            this.Controls.Add(this.datePickerFilter);
            this.Controls.Add(this.txtOpponentName);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gameInformationBacking);
            this.Controls.Add(this.gameManagementBackground);
            this.Name = "GameManagement";
            this.Text = "GameManagement";
            this.Load += new System.EventHandler(this.GameManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameManagementBackground)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.TextBox txtOpponentName;
        private System.Windows.Forms.DateTimePicker datePickerFilter;
        private System.Windows.Forms.RadioButton gameResultLost;
        private System.Windows.Forms.RadioButton gameResultWon;
        private System.Windows.Forms.CheckBox chkDateFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FilterGamesLabel;
        private System.Windows.Forms.Label GameInformationLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEventNameFilter;
        private System.Windows.Forms.TextBox txtOpponentFilter;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label gameResultLabel;
        private System.Windows.Forms.Label gameInformationBacking;
        private System.Windows.Forms.PictureBox gameManagementBackground;
        private System.Windows.Forms.ListBox filteredGameListBox;
        private System.Windows.Forms.RichTextBox selectedPGNDisplay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button menuPGNButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button yourAccountMenuButton;
        private System.Windows.Forms.Button upcomingGamesMenuButton;
        private System.Windows.Forms.Button scheduleGamesMenuButton;
    }
}