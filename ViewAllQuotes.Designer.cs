﻿namespace MegaDesk
{
    partial class ViewAllQuotes
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
            this.backToMenuBtn = new System.Windows.Forms.Button();
            this.gridAllQuotes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridAllQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // backToMenuBtn
            // 
            this.backToMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMenuBtn.Location = new System.Drawing.Point(12, 258);
            this.backToMenuBtn.Name = "backToMenuBtn";
            this.backToMenuBtn.Size = new System.Drawing.Size(128, 37);
            this.backToMenuBtn.TabIndex = 2;
            this.backToMenuBtn.Text = "&Back To Menu";
            this.backToMenuBtn.UseVisualStyleBackColor = true;
            this.backToMenuBtn.Click += new System.EventHandler(this.backToMenuBtn_Click);
            // 
            // gridAllQuotes
            // 
            this.gridAllQuotes.Location = new System.Drawing.Point(12, 12);
            this.gridAllQuotes.Name = "gridAllQuotes";
            this.gridAllQuotes.Size = new System.Drawing.Size(372, 240);
            this.gridAllQuotes.TabIndex = 3;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 307);
            this.Controls.Add(this.gridAllQuotes);
            this.Controls.Add(this.backToMenuBtn);
            this.Name = "ViewAllQuotes";
            this.Text = "MegaDesk - Nathaniel Dunham";
            ((System.ComponentModel.ISupportInitialize)(this.gridAllQuotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backToMenuBtn;
        private System.Windows.Forms.DataGridView gridAllQuotes;
    }
}