namespace SnakeGame
{
    partial class FormAddRecord
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonSaveRecord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(69, 149);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(391, 40);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // buttonSaveRecord
            // 
            this.buttonSaveRecord.FlatAppearance.BorderSize = 0;
            this.buttonSaveRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveRecord.Location = new System.Drawing.Point(69, 212);
            this.buttonSaveRecord.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSaveRecord.Name = "buttonSaveRecord";
            this.buttonSaveRecord.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonSaveRecord.Size = new System.Drawing.Size(193, 53);
            this.buttonSaveRecord.TabIndex = 1;
            this.buttonSaveRecord.Text = "Сохранить";
            this.buttonSaveRecord.UseVisualStyleBackColor = true;
            this.buttonSaveRecord.Click += new System.EventHandler(this.buttonSaveRecord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите ваше имя:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(270, 212);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonCancel.Size = new System.Drawing.Size(190, 53);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormAddRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(574, 314);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaveRecord);
            this.Controls.Add(this.textBoxName);
            this.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FormAddRecord";
            this.Text = "Сохранить рекорд";
            this.Load += new System.EventHandler(this.FormAddRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonSaveRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
    }
}