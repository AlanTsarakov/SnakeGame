namespace SnakeGame
{
    partial class FormTop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTop));
            this.dataGridViewTop = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTop)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTop
            // 
            this.dataGridViewTop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTop.ColumnHeadersVisible = false;
            this.dataGridViewTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTop.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTop.Name = "dataGridViewTop";
            this.dataGridViewTop.RowHeadersVisible = false;
            this.dataGridViewTop.RowHeadersWidth = 51;
            this.dataGridViewTop.RowTemplate.Height = 24;
            this.dataGridViewTop.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewTop.TabIndex = 0;
            // 
            // FormTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTop";
            this.Text = "Рейтинговая таблица";
            this.Load += new System.EventHandler(this.FormTop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTop;
    }
}