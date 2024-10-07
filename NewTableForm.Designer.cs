namespace lab1_1
{
    partial class NewTableForm
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
            this.TableNameLabel = new System.Windows.Forms.Label();
            this.TableNameTextBox = new System.Windows.Forms.TextBox();
            this.TableSchemeLabel = new System.Windows.Forms.Label();
            this.ColumnNameTextbox = new System.Windows.Forms.TextBox();
            this.NewColumnLabel = new System.Windows.Forms.Label();
            this.ColumnTypeComboBox = new System.Windows.Forms.ComboBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.TableSubmitButton = new System.Windows.Forms.Button();
            this.AddColumnButton = new System.Windows.Forms.Button();
            this.TableNameListBox = new System.Windows.Forms.ListBox();
            this.TableTypeListBox = new System.Windows.Forms.ListBox();
            this.NameInvalidLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TableNameLabel
            // 
            this.TableNameLabel.AutoSize = true;
            this.TableNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableNameLabel.Location = new System.Drawing.Point(584, 24);
            this.TableNameLabel.Name = "TableNameLabel";
            this.TableNameLabel.Size = new System.Drawing.Size(122, 25);
            this.TableNameLabel.TabIndex = 0;
            this.TableNameLabel.Text = "Table name:";
            // 
            // TableNameTextBox
            // 
            this.TableNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableNameTextBox.Location = new System.Drawing.Point(589, 63);
            this.TableNameTextBox.Name = "TableNameTextBox";
            this.TableNameTextBox.Size = new System.Drawing.Size(117, 28);
            this.TableNameTextBox.TabIndex = 1;
            // 
            // TableSchemeLabel
            // 
            this.TableSchemeLabel.AutoSize = true;
            this.TableSchemeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableSchemeLabel.Location = new System.Drawing.Point(12, 24);
            this.TableSchemeLabel.Name = "TableSchemeLabel";
            this.TableSchemeLabel.Size = new System.Drawing.Size(146, 25);
            this.TableSchemeLabel.TabIndex = 2;
            this.TableSchemeLabel.Text = "Table columns:";
            // 
            // ColumnNameTextbox
            // 
            this.ColumnNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnNameTextbox.Location = new System.Drawing.Point(589, 186);
            this.ColumnNameTextbox.Name = "ColumnNameTextbox";
            this.ColumnNameTextbox.Size = new System.Drawing.Size(117, 28);
            this.ColumnNameTextbox.TabIndex = 5;
            // 
            // NewColumnLabel
            // 
            this.NewColumnLabel.AutoSize = true;
            this.NewColumnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewColumnLabel.Location = new System.Drawing.Point(584, 138);
            this.NewColumnLabel.Name = "NewColumnLabel";
            this.NewColumnLabel.Size = new System.Drawing.Size(138, 25);
            this.NewColumnLabel.TabIndex = 7;
            this.NewColumnLabel.Text = "Add a column:";
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
            this.ColumnTypeComboBox.Location = new System.Drawing.Point(589, 237);
            this.ColumnTypeComboBox.Name = "ColumnTypeComboBox";
            this.ColumnTypeComboBox.Size = new System.Drawing.Size(117, 30);
            this.ColumnTypeComboBox.TabIndex = 8;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(731, 189);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(57, 22);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "Name";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeLabel.Location = new System.Drawing.Point(731, 240);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(51, 22);
            this.TypeLabel.TabIndex = 10;
            this.TypeLabel.Text = "Type";
            // 
            // TableSubmitButton
            // 
            this.TableSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableSubmitButton.Location = new System.Drawing.Point(385, 350);
            this.TableSubmitButton.Name = "TableSubmitButton";
            this.TableSubmitButton.Size = new System.Drawing.Size(132, 63);
            this.TableSubmitButton.TabIndex = 13;
            this.TableSubmitButton.Text = "Submit";
            this.TableSubmitButton.UseVisualStyleBackColor = true;
            this.TableSubmitButton.Click += new System.EventHandler(this.TableSubmitButton_Click);
            // 
            // AddColumnButton
            // 
            this.AddColumnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddColumnButton.Location = new System.Drawing.Point(589, 291);
            this.AddColumnButton.Name = "AddColumnButton";
            this.AddColumnButton.Size = new System.Drawing.Size(169, 38);
            this.AddColumnButton.TabIndex = 14;
            this.AddColumnButton.Text = "Add a column";
            this.AddColumnButton.UseVisualStyleBackColor = true;
            this.AddColumnButton.Click += new System.EventHandler(this.AddColumnButton_Click);
            // 
            // TableNameListBox
            // 
            this.TableNameListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableNameListBox.FormattingEnabled = true;
            this.TableNameListBox.ItemHeight = 22;
            this.TableNameListBox.Location = new System.Drawing.Point(17, 79);
            this.TableNameListBox.Name = "TableNameListBox";
            this.TableNameListBox.Size = new System.Drawing.Size(149, 246);
            this.TableNameListBox.TabIndex = 15;
            // 
            // TableTypeListBox
            // 
            this.TableTypeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableTypeListBox.FormattingEnabled = true;
            this.TableTypeListBox.ItemHeight = 22;
            this.TableTypeListBox.Location = new System.Drawing.Point(201, 79);
            this.TableTypeListBox.Name = "TableTypeListBox";
            this.TableTypeListBox.Size = new System.Drawing.Size(149, 246);
            this.TableTypeListBox.TabIndex = 16;
            // 
            // NameInvalidLabel
            // 
            this.NameInvalidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameInvalidLabel.Location = new System.Drawing.Point(523, 359);
            this.NameInvalidLabel.Name = "NameInvalidLabel";
            this.NameInvalidLabel.Size = new System.Drawing.Size(265, 54);
            this.NameInvalidLabel.TabIndex = 17;
            this.NameInvalidLabel.Text = "The table name is invalid, please try again.";
            this.NameInvalidLabel.Visible = false;
            // 
            // NewTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NameInvalidLabel);
            this.Controls.Add(this.TableTypeListBox);
            this.Controls.Add(this.TableNameListBox);
            this.Controls.Add(this.AddColumnButton);
            this.Controls.Add(this.TableSubmitButton);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ColumnTypeComboBox);
            this.Controls.Add(this.NewColumnLabel);
            this.Controls.Add(this.ColumnNameTextbox);
            this.Controls.Add(this.TableSchemeLabel);
            this.Controls.Add(this.TableNameTextBox);
            this.Controls.Add(this.TableNameLabel);
            this.Name = "NewTableForm";
            this.Text = "NewTableForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TableNameLabel;
        private System.Windows.Forms.TextBox TableNameTextBox;
        private System.Windows.Forms.Label TableSchemeLabel;
        private System.Windows.Forms.TextBox ColumnNameTextbox;
        private System.Windows.Forms.Label NewColumnLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Button TableSubmitButton;
        private System.Windows.Forms.Button AddColumnButton;
        protected System.Windows.Forms.ComboBox ColumnTypeComboBox;
        private System.Windows.Forms.ListBox TableNameListBox;
        private System.Windows.Forms.ListBox TableTypeListBox;
        private System.Windows.Forms.Label NameInvalidLabel;
    }
}