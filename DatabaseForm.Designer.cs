namespace lab1_1
{
    partial class DatabaseForm
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
            this.TableListLabel = new System.Windows.Forms.Label();
            this.TableListBox = new System.Windows.Forms.ListBox();
            this.NewTableButton = new System.Windows.Forms.Button();
            this.IntersectionButton = new System.Windows.Forms.Button();
            this.LeftTableComboBox = new System.Windows.Forms.ComboBox();
            this.RightTableComboBox = new System.Windows.Forms.ComboBox();
            this.LeftTableLabel = new System.Windows.Forms.Label();
            this.RightTableLabel = new System.Windows.Forms.Label();
            this.RenameButton = new System.Windows.Forms.Button();
            this.RenameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TableListLabel
            // 
            this.TableListLabel.AutoSize = true;
            this.TableListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableListLabel.Location = new System.Drawing.Point(70, 36);
            this.TableListLabel.Name = "TableListLabel";
            this.TableListLabel.Size = new System.Drawing.Size(108, 32);
            this.TableListLabel.TabIndex = 0;
            this.TableListLabel.Text = "Tables:";
            // 
            // TableListBox
            // 
            this.TableListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableListBox.FormattingEnabled = true;
            this.TableListBox.ItemHeight = 25;
            this.TableListBox.Location = new System.Drawing.Point(12, 111);
            this.TableListBox.Name = "TableListBox";
            this.TableListBox.Size = new System.Drawing.Size(229, 79);
            this.TableListBox.TabIndex = 1;
            this.TableListBox.SelectedIndexChanged += new System.EventHandler(this.TableListBox_SelectedIndexChanged);
            // 
            // NewTableButton
            // 
            this.NewTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewTableButton.Location = new System.Drawing.Point(460, 21);
            this.NewTableButton.Name = "NewTableButton";
            this.NewTableButton.Size = new System.Drawing.Size(137, 68);
            this.NewTableButton.TabIndex = 2;
            this.NewTableButton.Text = "New table";
            this.NewTableButton.UseVisualStyleBackColor = true;
            this.NewTableButton.Click += new System.EventHandler(this.NewTableButton_Click);
            // 
            // IntersectionButton
            // 
            this.IntersectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IntersectionButton.Location = new System.Drawing.Point(338, 358);
            this.IntersectionButton.Name = "IntersectionButton";
            this.IntersectionButton.Size = new System.Drawing.Size(137, 68);
            this.IntersectionButton.TabIndex = 3;
            this.IntersectionButton.Text = "Find intersection";
            this.IntersectionButton.UseVisualStyleBackColor = true;
            this.IntersectionButton.Click += new System.EventHandler(this.IntersectionButton_Click);
            // 
            // LeftTableComboBox
            // 
            this.LeftTableComboBox.FormattingEnabled = true;
            this.LeftTableComboBox.Location = new System.Drawing.Point(442, 219);
            this.LeftTableComboBox.Name = "LeftTableComboBox";
            this.LeftTableComboBox.Size = new System.Drawing.Size(121, 24);
            this.LeftTableComboBox.TabIndex = 4;
            // 
            // RightTableComboBox
            // 
            this.RightTableComboBox.FormattingEnabled = true;
            this.RightTableComboBox.Location = new System.Drawing.Point(442, 265);
            this.RightTableComboBox.Name = "RightTableComboBox";
            this.RightTableComboBox.Size = new System.Drawing.Size(121, 24);
            this.RightTableComboBox.TabIndex = 5;
            // 
            // LeftTableLabel
            // 
            this.LeftTableLabel.AutoSize = true;
            this.LeftTableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftTableLabel.Location = new System.Drawing.Point(334, 221);
            this.LeftTableLabel.Name = "LeftTableLabel";
            this.LeftTableLabel.Size = new System.Drawing.Size(84, 22);
            this.LeftTableLabel.TabIndex = 6;
            this.LeftTableLabel.Text = "Left table";
            // 
            // RightTableLabel
            // 
            this.RightTableLabel.AutoSize = true;
            this.RightTableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightTableLabel.Location = new System.Drawing.Point(334, 267);
            this.RightTableLabel.Name = "RightTableLabel";
            this.RightTableLabel.Size = new System.Drawing.Size(96, 22);
            this.RightTableLabel.TabIndex = 7;
            this.RightTableLabel.Text = "Right table";
            // 
            // RenameButton
            // 
            this.RenameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RenameButton.Location = new System.Drawing.Point(460, 111);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(137, 68);
            this.RenameButton.TabIndex = 9;
            this.RenameButton.Text = "Rename database";
            this.RenameButton.UseVisualStyleBackColor = true;
            this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // RenameTextBox
            // 
            this.RenameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RenameTextBox.Location = new System.Drawing.Point(293, 133);
            this.RenameTextBox.Name = "RenameTextBox";
            this.RenameTextBox.Size = new System.Drawing.Size(137, 28);
            this.RenameTextBox.TabIndex = 10;
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.RenameTextBox);
            this.Controls.Add(this.RenameButton);
            this.Controls.Add(this.RightTableLabel);
            this.Controls.Add(this.LeftTableLabel);
            this.Controls.Add(this.RightTableComboBox);
            this.Controls.Add(this.LeftTableComboBox);
            this.Controls.Add(this.IntersectionButton);
            this.Controls.Add(this.NewTableButton);
            this.Controls.Add(this.TableListBox);
            this.Controls.Add(this.TableListLabel);
            this.Name = "DatabaseForm";
            this.Text = "DatabaseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TableListLabel;
        private System.Windows.Forms.ListBox TableListBox;
        private System.Windows.Forms.Button NewTableButton;
        private System.Windows.Forms.Button IntersectionButton;
        private System.Windows.Forms.ComboBox LeftTableComboBox;
        private System.Windows.Forms.ComboBox RightTableComboBox;
        private System.Windows.Forms.Label LeftTableLabel;
        private System.Windows.Forms.Label RightTableLabel;
        private System.Windows.Forms.Button RenameButton;
        private System.Windows.Forms.TextBox RenameTextBox;
    }
}