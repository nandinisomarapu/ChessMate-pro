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
            this.eventNameInput = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.opponentNameInput = new System.Windows.Forms.TextBox();
            this.exportFileButton = new System.Windows.Forms.Button();
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuPGNButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pngGeneratorBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveTable)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pngGeneratorBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // eventNameInput
            // 
            this.eventNameInput.Location = new System.Drawing.Point(311, 73);
            this.eventNameInput.Name = "eventNameInput";
            this.eventNameInput.Size = new System.Drawing.Size(431, 20);
            this.eventNameInput.TabIndex = 2;
            this.eventNameInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(311, 102);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(431, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // opponentNameInput
            // 
            this.opponentNameInput.Location = new System.Drawing.Point(311, 133);
            this.opponentNameInput.Name = "opponentNameInput";
            this.opponentNameInput.Size = new System.Drawing.Size(431, 20);
            this.opponentNameInput.TabIndex = 4;
            // 
            // exportFileButton
            // 
            this.exportFileButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.exportFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.exportFileButton.Location = new System.Drawing.Point(471, 391);
            this.exportFileButton.Name = "exportFileButton";
            this.exportFileButton.Size = new System.Drawing.Size(271, 35);
            this.exportFileButton.TabIndex = 5;
            this.exportFileButton.Text = "EXPORT FILE";
            this.exportFileButton.UseVisualStyleBackColor = false;
            this.exportFileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(190, 133);
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
            this.label2.Location = new System.Drawing.Point(190, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Result";
            // 
            // radioButtonWin
            // 
            this.radioButtonWin.AutoSize = true;
            this.radioButtonWin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonWin.Location = new System.Drawing.Point(311, 161);
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
            this.radioButtonLose.Location = new System.Drawing.Point(390, 161);
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
            this.moveTable.Location = new System.Drawing.Point(190, 189);
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
            this.saveFileButton.Location = new System.Drawing.Point(190, 391);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(264, 35);
            this.saveFileButton.TabIndex = 18;
            this.saveFileButton.Text = "SAVE FILE";
            this.saveFileButton.UseVisualStyleBackColor = false;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(190, 29);
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
            this.label4.Location = new System.Drawing.Point(190, 76);
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
            this.dateLabel.Location = new System.Drawing.Point(190, 106);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(38, 17);
            this.dateLabel.TabIndex = 22;
            this.dateLabel.Text = "Date";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuPGNButton);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(28, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 235);
            this.panel1.TabIndex = 26;
            // 
            // menuPGNButton
            // 
            this.menuPGNButton.Location = new System.Drawing.Point(3, 23);
            this.menuPGNButton.Name = "menuPGNButton";
            this.menuPGNButton.Size = new System.Drawing.Size(116, 23);
            this.menuPGNButton.TabIndex = 27;
            this.menuPGNButton.Text = "PGN Generator";
            this.menuPGNButton.UseVisualStyleBackColor = true;
            this.menuPGNButton.Click += new System.EventHandler(this.menuPGNButton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 203);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Your Account";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 139);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Upcoming Games";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Schedule Games";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "View Games";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(1, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Game Management";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(3, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Game Tools";
            // 
            // pngGeneratorBackground
            // 
            this.pngGeneratorBackground.Image = ((System.Drawing.Image)(resources.GetObject("pngGeneratorBackground.Image")));
            this.pngGeneratorBackground.Location = new System.Drawing.Point(-2, 0);
            this.pngGeneratorBackground.Name = "pngGeneratorBackground";
            this.pngGeneratorBackground.Size = new System.Drawing.Size(776, 462);
            this.pngGeneratorBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pngGeneratorBackground.TabIndex = 27;
            this.pngGeneratorBackground.TabStop = false;
            // 
            // PGNGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(772, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.moveTable);
            this.Controls.Add(this.radioButtonLose);
            this.Controls.Add(this.radioButtonWin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exportFileButton);
            this.Controls.Add(this.opponentNameInput);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.eventNameInput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pngGeneratorBackground);
            this.Name = "PGNGenerator";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pngGeneratorBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox eventNameInput;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox opponentNameInput;
        private System.Windows.Forms.Button exportFileButton;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button menuPGNButton;
        private System.Windows.Forms.PictureBox pngGeneratorBackground;
    }
}