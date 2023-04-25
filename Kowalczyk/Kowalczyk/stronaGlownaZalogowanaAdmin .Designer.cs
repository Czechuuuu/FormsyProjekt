namespace Kowalczyk
{
    partial class stronaGlownaZalogowanaA
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
            this.ZDU = new System.Windows.Forms.Button();
            this.ZU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ZDU
            // 
            this.ZDU.FlatAppearance.BorderSize = 0;
            this.ZDU.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZDU.Location = new System.Drawing.Point(786, 55);
            this.ZDU.Margin = new System.Windows.Forms.Padding(4);
            this.ZDU.Name = "ZDU";
            this.ZDU.Size = new System.Drawing.Size(293, 98);
            this.ZDU.TabIndex = 27;
            this.ZDU.Text = "Zmiana danych użytkownika";
            this.ZDU.UseVisualStyleBackColor = true;
            this.ZDU.Click += new System.EventHandler(this.ZDU_Click);
            // 
            // ZU
            // 
            this.ZU.FlatAppearance.BorderSize = 0;
            this.ZU.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZU.Location = new System.Drawing.Point(786, 188);
            this.ZU.Margin = new System.Windows.Forms.Padding(4);
            this.ZU.Name = "ZU";
            this.ZU.Size = new System.Drawing.Size(293, 98);
            this.ZU.TabIndex = 28;
            this.ZU.Text = "Zarządzanie użytkownikami";
            this.ZU.UseVisualStyleBackColor = true;
            this.ZU.Click += new System.EventHandler(this.button1_Click);
            // 
            // stronaGlownaZalogowanaA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 751);
            this.Controls.Add(this.ZU);
            this.Controls.Add(this.ZDU);
            this.Name = "stronaGlownaZalogowanaA";
            this.Text = "stronaGlownaZalogowanaAdmin ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ZDU;
        private System.Windows.Forms.Button ZU;
    }
}