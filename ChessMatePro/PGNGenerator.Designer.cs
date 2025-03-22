namespace ChessMate_pro
{
    partial class PGNGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PGNGenerator));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eventNameInput = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.opponentNameInput = new System.Windows.Forms.TextBox();
            this.exportFileButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonWin = new System.Windows.Forms.RadioButton();
            this.radioButtonLose = new System.Windows.Forms.RadioButton();
            this.moveTable = new System.Windows.Forms.DataGridView();
            this.moveNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whiteMove = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blackMove = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annotations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.pngGeneratorBackground = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pngGeneratorBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eventNameInput
            // 
            this.eventNameInput.Location = new System.Drawing.Point(316, 108);
            this.eventNameInput.Name = "eventNameInput";
            this.eventNameInput.Size = new System.Drawing.Size(431, 20);
            this.eventNameInput.TabIndex = 2;
            this.eventNameInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(316, 137);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(431, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // opponentNameInput
            // 
            this.opponentNameInput.Location = new System.Drawing.Point(316, 168);
            this.opponentNameInput.Name = "opponentNameInput";
            this.opponentNameInput.Size = new System.Drawing.Size(431, 20);
            this.opponentNameInput.TabIndex = 4;
            // 
            // exportFileButton
            // 
            this.exportFileButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.exportFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.exportFileButton.Location = new System.Drawing.Point(476, 426);
            this.exportFileButton.Name = "exportFileButton";
            this.exportFileButton.Size = new System.Drawing.Size(271, 35);
            this.exportFileButton.TabIndex = 5;
            this.exportFileButton.Text = "EXPORT FILE";
            this.exportFileButton.UseVisualStyleBackColor = false;
            this.exportFileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 532);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(815, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PGN Genertor",
            "Export File"});
            this.comboBox1.Location = new System.Drawing.Point(35, 196);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "PGN Generator";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Game Management",
            "Schedule New Game",
            "View Upcoming Games"});
            this.comboBox2.Location = new System.Drawing.Point(35, 259);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.Text = "Game Management";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Your Account"});
            this.comboBox3.Location = new System.Drawing.Point(33, 332);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 11;
            this.comboBox3.Text = "Your Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(195, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Opponent Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(195, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Result";
            // 
            // radioButtonWin
            // 
            this.radioButtonWin.AutoSize = true;
            this.radioButtonWin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonWin.Location = new System.Drawing.Point(316, 196);
            this.radioButtonWin.Name = "radioButtonWin";
            this.radioButtonWin.Size = new System.Drawing.Size(46, 17);
            this.radioButtonWin.TabIndex = 15;
            this.radioButtonWin.TabStop = true;
            this.radioButtonWin.Text = "0 - 1";
            this.radioButtonWin.UseVisualStyleBackColor = true;
            // 
            // radioButtonLose
            // 
            this.radioButtonLose.AutoSize = true;
            this.radioButtonLose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButtonLose.Location = new System.Drawing.Point(395, 196);
            this.radioButtonLose.Name = "radioButtonLose";
            this.radioButtonLose.Size = new System.Drawing.Size(43, 17);
            this.radioButtonLose.TabIndex = 16;
            this.radioButtonLose.TabStop = true;
            this.radioButtonLose.Text = "1- 0";
            this.radioButtonLose.UseVisualStyleBackColor = true;
            // 
            // moveTable
            // 
            this.moveTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moveTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.moveNumber,
            this.whiteMove,
            this.blackMove,
            this.annotations,
            this.comments});
            this.moveTable.Location = new System.Drawing.Point(195, 224);
            this.moveTable.Name = "moveTable";
            this.moveTable.Size = new System.Drawing.Size(552, 185);
            this.moveTable.TabIndex = 17;
            this.moveTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // moveNumber
            // 
            this.moveNumber.HeaderText = "Move Number";
            this.moveNumber.Name = "moveNumber";
            // 
            // whiteMove
            // 
            this.whiteMove.HeaderText = "White Move";
            this.whiteMove.Name = "whiteMove";
            // 
            // blackMove
            // 
            this.blackMove.HeaderText = "Black Move";
            this.blackMove.Name = "blackMove";
            // 
            // annotations
            // 
            this.annotations.HeaderText = "Annotations (!, ?, etc.)";
            this.annotations.Name = "annotations";
            // 
            // comments
            // 
            this.comments.HeaderText = "Comments";
            this.comments.Name = "comments";
            // 
            // saveFileButton
            // 
            this.saveFileButton.BackColor = System.Drawing.Color.SlateGray;
            this.saveFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.saveFileButton.Location = new System.Drawing.Point(195, 426);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(264, 35);
            this.saveFileButton.TabIndex = 18;
            this.saveFileButton.Text = "SAVE FILE";
            this.saveFileButton.UseVisualStyleBackColor = false;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // pngGeneratorBackground
            // 
            this.pngGeneratorBackground.Image = ((System.Drawing.Image)(resources.GetObject("pngGeneratorBackground.Image")));
            this.pngGeneratorBackground.Location = new System.Drawing.Point(0, 21);
            this.pngGeneratorBackground.Name = "pngGeneratorBackground";
            this.pngGeneratorBackground.Size = new System.Drawing.Size(815, 472);
            this.pngGeneratorBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pngGeneratorBackground.TabIndex = 19;
            this.pngGeneratorBackground.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(195, 64);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(226, 10, 226, 10);
            this.label3.Size = new System.Drawing.Size(552, 33);
            this.label3.TabIndex = 20;
            this.label3.Text = "Game Management";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(195, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Event Name";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dateLabel.Location = new System.Drawing.Point(195, 141);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(38, 17);
            this.dateLabel.TabIndex = 22;
            this.dateLabel.Text = "Date";
            // 
            // PGNGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(815, 554);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.moveTable);
            this.Controls.Add(this.radioButtonLose);
            this.Controls.Add(this.radioButtonWin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.exportFileButton);
            this.Controls.Add(this.opponentNameInput);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.eventNameInput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pngGeneratorBackground);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PGNGenerator";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pngGeneratorBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox eventNameInput;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox opponentNameInput;
        private System.Windows.Forms.Button exportFileButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonWin;
        private System.Windows.Forms.RadioButton radioButtonLose;
        private System.Windows.Forms.DataGridView moveTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn moveNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn whiteMove;
        private System.Windows.Forms.DataGridViewTextBoxColumn blackMove;
        private System.Windows.Forms.DataGridViewTextBoxColumn annotations;
        private System.Windows.Forms.DataGridViewTextBoxColumn comments;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.PictureBox pngGeneratorBackground;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dateLabel;
    }
}