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
            this.filterButton = new System.Windows.Forms.Button();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.txtOpponentName = new System.Windows.Forms.TextBox();
            this.dateTimeInput = new System.Windows.Forms.DateTimePicker();
            this.gameResultLost = new System.Windows.Forms.RadioButton();
            this.gameResultWon = new System.Windows.Forms.RadioButton();
            this.filteredGameListBox = new System.Windows.Forms.ListBox();
            this.chkDateFilter = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(120, 292);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(75, 23);
            this.filterButton.TabIndex = 0;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(120, 111);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(100, 20);
            this.txtEventName.TabIndex = 1;
            this.txtEventName.Text = "Event Name";
            // 
            // txtOpponentName
            // 
            this.txtOpponentName.Location = new System.Drawing.Point(120, 156);
            this.txtOpponentName.Name = "txtOpponentName";
            this.txtOpponentName.Size = new System.Drawing.Size(100, 20);
            this.txtOpponentName.TabIndex = 2;
            this.txtOpponentName.Text = "Opponent Name";
            // 
            // dateTimeInput
            // 
            this.dateTimeInput.Location = new System.Drawing.Point(147, 199);
            this.dateTimeInput.Name = "dateTimeInput";
            this.dateTimeInput.Size = new System.Drawing.Size(173, 20);
            this.dateTimeInput.TabIndex = 3;
            // 
            // gameResultLost
            // 
            this.gameResultLost.AutoSize = true;
            this.gameResultLost.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gameResultLost.Location = new System.Drawing.Point(120, 226);
            this.gameResultLost.Name = "gameResultLost";
            this.gameResultLost.Size = new System.Drawing.Size(43, 17);
            this.gameResultLost.TabIndex = 4;
            this.gameResultLost.TabStop = true;
            this.gameResultLost.Text = "0 -1";
            this.gameResultLost.UseVisualStyleBackColor = true;
            // 
            // gameResultWon
            // 
            this.gameResultWon.AutoSize = true;
            this.gameResultWon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gameResultWon.Location = new System.Drawing.Point(120, 250);
            this.gameResultWon.Name = "gameResultWon";
            this.gameResultWon.Size = new System.Drawing.Size(46, 17);
            this.gameResultWon.TabIndex = 5;
            this.gameResultWon.TabStop = true;
            this.gameResultWon.Text = "1 - 0";
            this.gameResultWon.UseVisualStyleBackColor = true;
            // 
            // filteredGameListBox
            // 
            this.filteredGameListBox.FormattingEnabled = true;
            this.filteredGameListBox.Location = new System.Drawing.Point(400, 111);
            this.filteredGameListBox.Name = "filteredGameListBox";
            this.filteredGameListBox.Size = new System.Drawing.Size(120, 95);
            this.filteredGameListBox.TabIndex = 6;
            this.filteredGameListBox.SelectedIndexChanged += new System.EventHandler(this.filteredGameListBox_SelectedIndexChanged);
            // 
            // chkDateFilter
            // 
            this.chkDateFilter.AutoSize = true;
            this.chkDateFilter.Location = new System.Drawing.Point(120, 199);
            this.chkDateFilter.Name = "chkDateFilter";
            this.chkDateFilter.Size = new System.Drawing.Size(15, 14);
            this.chkDateFilter.TabIndex = 7;
            this.chkDateFilter.UseVisualStyleBackColor = true;
            // 
            // GameManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkDateFilter);
            this.Controls.Add(this.filteredGameListBox);
            this.Controls.Add(this.gameResultWon);
            this.Controls.Add(this.gameResultLost);
            this.Controls.Add(this.dateTimeInput);
            this.Controls.Add(this.txtOpponentName);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.filterButton);
            this.Name = "GameManagement";
            this.Text = "GameManagement";
            this.Load += new System.EventHandler(this.GameManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.TextBox txtOpponentName;
        private System.Windows.Forms.DateTimePicker dateTimeInput;
        private System.Windows.Forms.RadioButton gameResultLost;
        private System.Windows.Forms.RadioButton gameResultWon;
        private System.Windows.Forms.ListBox filteredGameListBox;
        private System.Windows.Forms.CheckBox chkDateFilter;
    }
}