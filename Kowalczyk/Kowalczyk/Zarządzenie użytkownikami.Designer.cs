namespace Kowalczyk
{
    partial class ZU
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
            this.button_exit = new System.Windows.Forms.Button();
            this.DU = new System.Windows.Forms.Button();
            this.UU = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(100, 454);
            this.button_exit.Margin = new System.Windows.Forms.Padding(4);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(100, 28);
            this.button_exit.TabIndex = 9;
            this.button_exit.Text = "Wyjście";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // DU
            // 
            this.DU.FlatAppearance.BorderSize = 0;
            this.DU.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DU.Location = new System.Drawing.Point(100, 40);
            this.DU.Margin = new System.Windows.Forms.Padding(4);
            this.DU.Name = "DU";
            this.DU.Size = new System.Drawing.Size(293, 98);
            this.DU.TabIndex = 28;
            this.DU.Text = "Dodanie użytkownika";
            this.DU.UseVisualStyleBackColor = true;
            this.DU.Click += new System.EventHandler(this.DU_Click);
            // 
            // UU
            // 
            this.UU.FlatAppearance.BorderSize = 0;
            this.UU.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UU.Location = new System.Drawing.Point(100, 146);
            this.UU.Margin = new System.Windows.Forms.Padding(4);
            this.UU.Name = "UU";
            this.UU.Size = new System.Drawing.Size(293, 98);
            this.UU.TabIndex = 29;
            this.UU.Text = "Usunięcie użytkownika";
            this.UU.UseVisualStyleBackColor = true;
            this.UU.Click += new System.EventHandler(this.UU_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(100, 252);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(293, 98);
            this.button2.TabIndex = 30;
            this.button2.Text = "Zmiana danych użytkownika";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ZU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.UU);
            this.Controls.Add(this.DU);
            this.Controls.Add(this.button_exit);
            this.Name = "ZU";
            this.Text = "Zarządzanie Użytkownikami";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button DU;
        private System.Windows.Forms.Button UU;
        private System.Windows.Forms.Button button2;
    }
}