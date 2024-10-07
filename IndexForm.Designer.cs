namespace lab1_1
{
    partial class IndexForm
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
            this.DBListCaption = new System.Windows.Forms.Label();
            this.NewDBButton = new System.Windows.Forms.Button();
            this.DBListBox = new System.Windows.Forms.ListBox();
            this.DBNameTextBox = new System.Windows.Forms.TextBox();
            this.DBNameLabel = new System.Windows.Forms.Label();
            this.InvalidNameLabel = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DBListCaption
            // 
            this.DBListCaption.AutoSize = true;
            this.DBListCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DBListCaption.Location = new System.Drawing.Point(12, 31);
            this.DBListCaption.Name = "DBListCaption";
            this.DBListCaption.Size = new System.Drawing.Size(221, 32);
            this.DBListCaption.TabIndex = 0;
            this.DBListCaption.Text = "Your databases:";
            // 
            // NewDBButton
            // 
            this.NewDBButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewDBButton.Location = new System.Drawing.Point(584, 174);
            this.NewDBButton.Name = "NewDBButton";
            this.NewDBButton.Size = new System.Drawing.Size(153, 32);
            this.NewDBButton.TabIndex = 1;
            this.NewDBButton.Text = "New database";
            this.NewDBButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NewDBButton.UseVisualStyleBackColor = true;
            this.NewDBButton.Click += new System.EventHandler(this.NewDBButton_Click);
            // 
            // DBListBox
            // 
            this.DBListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DBListBox.FormattingEnabled = true;
            this.DBListBox.ItemHeight = 22;
            this.DBListBox.Location = new System.Drawing.Point(18, 92);
            this.DBListBox.Name = "DBListBox";
            this.DBListBox.Size = new System.Drawing.Size(502, 114);
            this.DBListBox.TabIndex = 2;
            this.DBListBox.SelectedIndexChanged += new System.EventHandler(this.DBListBox_SelectedIndexChanged);
            // 
            // DBNameTextBox
            // 
            this.DBNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DBNameTextBox.Location = new System.Drawing.Point(584, 128);
            this.DBNameTextBox.Name = "DBNameTextBox";
            this.DBNameTextBox.Size = new System.Drawing.Size(153, 28);
            this.DBNameTextBox.TabIndex = 3;
            // 
            // DBNameLabel
            // 
            this.DBNameLabel.AutoSize = true;
            this.DBNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DBNameLabel.Location = new System.Drawing.Point(584, 92);
            this.DBNameLabel.Name = "DBNameLabel";
            this.DBNameLabel.Size = new System.Drawing.Size(130, 22);
            this.DBNameLabel.TabIndex = 4;
            this.DBNameLabel.Text = "New DB name:";
            // 
            // InvalidNameLabel
            // 
            this.InvalidNameLabel.AutoSize = true;
            this.InvalidNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InvalidNameLabel.Location = new System.Drawing.Point(584, 224);
            this.InvalidNameLabel.Name = "InvalidNameLabel";
            this.InvalidNameLabel.Size = new System.Drawing.Size(0, 22);
            this.InvalidNameLabel.TabIndex = 5;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshButton.Location = new System.Drawing.Point(609, 31);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(91, 31);
            this.RefreshButton.TabIndex = 6;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.InvalidNameLabel);
            this.Controls.Add(this.DBNameLabel);
            this.Controls.Add(this.DBNameTextBox);
            this.Controls.Add(this.DBListBox);
            this.Controls.Add(this.NewDBButton);
            this.Controls.Add(this.DBListCaption);
            this.Name = "IndexForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DBListCaption;
        private System.Windows.Forms.Button NewDBButton;
        private System.Windows.Forms.ListBox DBListBox;
        private System.Windows.Forms.TextBox DBNameTextBox;
        private System.Windows.Forms.Label DBNameLabel;
        private System.Windows.Forms.Label InvalidNameLabel;
        private System.Windows.Forms.Button RefreshButton;
    }
}

