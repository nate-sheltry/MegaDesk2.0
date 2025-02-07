namespace MegaDesk
{
    partial class SearchQuotes
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
            this.comboMaterial = new System.Windows.Forms.ComboBox();
            this.gridQuotes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // backToMenuBtn
            // 
            this.backToMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMenuBtn.Location = new System.Drawing.Point(12, 238);
            this.backToMenuBtn.Name = "backToMenuBtn";
            this.backToMenuBtn.Size = new System.Drawing.Size(128, 34);
            this.backToMenuBtn.TabIndex = 2;
            this.backToMenuBtn.Text = "&Back To Menu";
            this.backToMenuBtn.UseVisualStyleBackColor = true;
            this.backToMenuBtn.Click += new System.EventHandler(this.backToMenuBtn_Click);
            // 
            // comboMaterial
            // 
            this.comboMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMaterial.Location = new System.Drawing.Point(12, 12);
            this.comboMaterial.Name = "comboMaterial";
            this.comboMaterial.Size = new System.Drawing.Size(121, 20);
            this.comboMaterial.TabIndex = 1;
            this.comboMaterial.SelectedIndexChanged += new System.EventHandler(this.comboMaterial_SelectedIndexChanged);
            // 
            // gridQuotes
            // 
            this.gridQuotes.Location = new System.Drawing.Point(12, 52);
            this.gridQuotes.Name = "gridQuotes";
            this.gridQuotes.Size = new System.Drawing.Size(372, 180);
            this.gridQuotes.TabIndex = 0;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 283);
            this.Controls.Add(this.gridQuotes);
            this.Controls.Add(this.comboMaterial);
            this.Controls.Add(this.backToMenuBtn);
            this.Name = "SearchQuotes";
            this.Text = "MegaDesk - Nathaniel Dunham";
            ((System.ComponentModel.ISupportInitialize)(this.gridQuotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backToMenuBtn;
        private System.Windows.Forms.ComboBox comboMaterial;
        private System.Windows.Forms.DataGridView gridQuotes;
    }
}