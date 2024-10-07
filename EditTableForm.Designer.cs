namespace lab1_1
{
    partial class EditTableForm
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
            this.ColumnListBox = new System.Windows.Forms.CheckedListBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NameInvalidLabel = new System.Windows.Forms.Label();
            this.AddColumnButton = new System.Windows.Forms.Button();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ColumnTypeComboBox = new System.Windows.Forms.ComboBox();
            this.NewColumnLabel = new System.Windows.Forms.Label();
            this.ColumnNameTextbox = new System.Windows.Forms.TextBox();
            this.TableNameLabel = new System.Windows.Forms.Label();
            this.TipLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ColumnListBox
            // 
            this.ColumnListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnListBox.FormattingEnabled = true;
            this.ColumnListBox.Location = new System.Drawing.Point(12, 94);
            this.ColumnListBox.Name = "ColumnListBox";
            this.ColumnListBox.Size = new System.Drawing.Size(387, 344);
            this.ColumnListBox.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(12, 12);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(145, 67);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save changes and exit";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NameInvalidLabel
            // 
            this.NameInvalidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameInvalidLabel.Location = new System.Drawing.Point(502, 375);
            this.NameInvalidLabel.Name = "NameInvalidLabel";
            this.NameInvalidLabel.Size = new System.Drawing.Size(265, 54);
            this.NameInvalidLabel.TabIndex = 26;
            this.NameInvalidLabel.Text = "The table name is invalid, please try again.";
            this.NameInvalidLabel.Visible = false;
            // 
            // AddColumnButton
            // 
            this.AddColumnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddColumnButton.Location = new System.Drawing.Point(506, 305);
            this.AddColumnButton.Name = "AddColumnButton";
            this.AddColumnButton.Size = new System.Drawing.Size(169, 38);
            this.AddColumnButton.TabIndex = 25;
            this.AddColumnButton.Text = "Add a column";
            this.AddColumnButton.UseVisualStyleBackColor = true;
            this.AddColumnButton.Click += new System.EventHandler(this.AddColumnButton_Click);
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeLabel.Location = new System.Drawing.Point(648, 254);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(51, 22);
            this.TypeLabel.TabIndex = 24;
            this.TypeLabel.Text = "Type";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(648, 203);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(57, 22);
            this.NameLabel.TabIndex = 23;
            this.NameLabel.Text = "Name";
            // 
            // ColumnTypeComboBox
            // 
            this.ColumnTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnTypeComboBox.FormattingEnabled = true;
            this.ColumnTypeComboBox.Items.AddRange(new object[] {
            "integer",
            "real",
            "char",
            "string",
            "time",
            "timeInvl"});
            this.ColumnTypeComboBox.Location = new System.Drawing.Point(506, 251);
            this.ColumnTypeComboBox.Name = "ColumnTypeComboBox";
            this.ColumnTypeComboBox.Size = new System.Drawing.Size(117, 30);
            this.ColumnTypeComboBox.TabIndex = 22;
            // 
            // NewColumnLabel
            // 
            this.NewColumnLabel.AutoSize = true;
            this.NewColumnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewColumnLabel.Location = new System.Drawing.Point(501, 152);
            this.NewColumnLabel.Name = "NewColumnLabel";
            this.NewColumnLabel.Size = new System.Drawing.Size(138, 25);
            this.NewColumnLabel.TabIndex = 21;
            this.NewColumnLabel.Text = "Add a column:";
            // 
            // ColumnNameTextbox
            // 
            this.ColumnNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnNameTextbox.Location = new System.Drawing.Point(506, 200);
            this.ColumnNameTextbox.Name = "ColumnNameTextbox";
            this.ColumnNameTextbox.Size = new System.Drawing.Size(117, 28);
            this.ColumnNameTextbox.TabIndex = 20;
            // 
            // TableNameLabel
            // 
            this.TableNameLabel.AutoSize = true;
            this.TableNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableNameLabel.Location = new System.Drawing.Point(501, 54);
            this.TableNameLabel.Name = "TableNameLabel";
            this.TableNameLabel.Size = new System.Drawing.Size(122, 25);
            this.TableNameLabel.TabIndex = 18;
            this.TableNameLabel.Text = "Table name:";
            // 
            // TipLabel
            // 
            this.TipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TipLabel.Location = new System.Drawing.Point(193, 12);
            this.TipLabel.Name = "TipLabel";
            this.TipLabel.Size = new System.Drawing.Size(206, 67);
            this.TipLabel.TabIndex = 27;
            this.TipLabel.Text = "Tick all of the columns you want to keep before saving.";
            // 
            // EditTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TipLabel);
            this.Controls.Add(this.NameInvalidLabel);
            this.Controls.Add(this.AddColumnButton);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ColumnTypeComboBox);
            this.Controls.Add(this.NewColumnLabel);
            this.Controls.Add(this.ColumnNameTextbox);
            this.Controls.Add(this.TableNameLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ColumnListBox);
            this.Name = "EditTableForm";
            this.Text = "EditTableForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ColumnListBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label NameInvalidLabel;
        private System.Windows.Forms.Button AddColumnButton;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label NameLabel;
        protected System.Windows.Forms.ComboBox ColumnTypeComboBox;
        private System.Windows.Forms.Label NewColumnLabel;
        private System.Windows.Forms.TextBox ColumnNameTextbox;
        private System.Windows.Forms.Label TableNameLabel;
        private System.Windows.Forms.Label TipLabel;
    }
}