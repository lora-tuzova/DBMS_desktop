namespace lab1_1
{
    partial class IntersectTableForm
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
            this.TableContentGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TableContentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TableContentGrid
            // 
            this.TableContentGrid.AllowUserToAddRows = false;
            this.TableContentGrid.AllowUserToDeleteRows = false;
            this.TableContentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableContentGrid.Location = new System.Drawing.Point(13, 58);
            this.TableContentGrid.Name = "TableContentGrid";
            this.TableContentGrid.ReadOnly = true;
            this.TableContentGrid.RowHeadersWidth = 51;
            this.TableContentGrid.RowTemplate.Height = 24;
            this.TableContentGrid.Size = new System.Drawing.Size(775, 334);
            this.TableContentGrid.TabIndex = 3;
            // 
            // IntersectTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TableContentGrid);
            this.Name = "IntersectTableForm";
            this.Text = "IntersectTableForm";
            ((System.ComponentModel.ISupportInitialize)(this.TableContentGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TableContentGrid;
    }
}