namespace lab1_1
{
    partial class TableForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.TableContentGrid = new System.Windows.Forms.DataGridView();
            this.EditButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableContentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(13, 28);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(140, 43);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save changes";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TableContentGrid
            // 
            this.TableContentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableContentGrid.Location = new System.Drawing.Point(13, 104);
            this.TableContentGrid.Name = "TableContentGrid";
            this.TableContentGrid.RowHeadersWidth = 51;
            this.TableContentGrid.RowTemplate.Height = 24;
            this.TableContentGrid.Size = new System.Drawing.Size(775, 334);
            this.TableContentGrid.TabIndex = 2;
            this.TableContentGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableContentGrid_CellClick);
            this.TableContentGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.TableContentGrid_CellValidating);
            this.TableContentGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.TableContentGrid_DataError);
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.Location = new System.Drawing.Point(181, 28);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(140, 43);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit columns";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.TableContentGrid);
            this.Controls.Add(this.SaveButton);
            this.Name = "TableForm";
            this.Text = "TableForm";
            ((System.ComponentModel.ISupportInitialize)(this.TableContentGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView TableContentGrid;
        private System.Windows.Forms.Button EditButton;
    }
}