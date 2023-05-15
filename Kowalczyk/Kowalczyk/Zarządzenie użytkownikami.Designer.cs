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
            this.ListaU = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(75, 392);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 9;
            this.button_exit.Text = "Wyjście";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // DU
            // 
            this.DU.FlatAppearance.BorderSize = 0;
            this.DU.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DU.Location = new System.Drawing.Point(75, 32);
            this.DU.Name = "DU";
            this.DU.Size = new System.Drawing.Size(220, 80);
            this.DU.TabIndex = 28;
            this.DU.Text = "Dodanie użytkownika";
            this.DU.UseVisualStyleBackColor = true;
            this.DU.Click += new System.EventHandler(this.DU_Click);
            // 
            // UU
            // 
            this.UU.FlatAppearance.BorderSize = 0;
            this.UU.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UU.Location = new System.Drawing.Point(75, 119);
            this.UU.Name = "UU";
            this.UU.Size = new System.Drawing.Size(220, 80);
            this.UU.TabIndex = 29;
            this.UU.Text = "Usunięcie użytkownika";
            this.UU.UseVisualStyleBackColor = true;
            this.UU.Click += new System.EventHandler(this.UU_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(75, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 80);
            this.button2.TabIndex = 30;
            this.button2.Text = "Zmiana danych użytkownika";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListaU
            // 
            this.ListaU.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ListaU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListaU.FormattingEnabled = true;
            this.ListaU.ItemHeight = 17;
            this.ListaU.Location = new System.Drawing.Point(417, 47);
            this.ListaU.Margin = new System.Windows.Forms.Padding(2);
            this.ListaU.Name = "ListaU";
            this.ListaU.Size = new System.Drawing.Size(282, 344);
            this.ListaU.TabIndex = 31;
            this.ListaU.SelectedIndexChanged += new System.EventHandler(this.ListaU_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(413, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "Lista użytkowników";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(75, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 80);
            this.button1.TabIndex = 33;
            this.button1.Text = "Podgląd zamówień";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ZU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListaU);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.UU);
            this.Controls.Add(this.DU);
            this.Controls.Add(this.button_exit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ZU";
            this.Text = "Zarządzanie Użytkownikami";
            this.Load += new System.EventHandler(this.ZU_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button DU;
        private System.Windows.Forms.Button UU;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ListBox ListaU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}