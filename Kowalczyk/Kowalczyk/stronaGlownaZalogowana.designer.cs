namespace Kowalczyk
{
    partial class stronaGlownaZalogowana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stronaGlownaZalogowana));
            System.Windows.Forms.Button btnWyloguj;
            this.buttonLogo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonKupony = new System.Windows.Forms.Button();
            this.buttonKontakt = new System.Windows.Forms.Button();
            this.buttonRestauracje = new System.Windows.Forms.Button();
            this.buttonKoszyk = new System.Windows.Forms.Button();
            this.ZDU = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            btnWyloguj = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogo
            // 
            this.buttonLogo.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogo.Image")));
            this.buttonLogo.Location = new System.Drawing.Point(10, 11);
            this.buttonLogo.Name = "buttonLogo";
            this.buttonLogo.Size = new System.Drawing.Size(500, 75);
            this.buttonLogo.TabIndex = 23;
            this.buttonLogo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.buttonMenu);
            this.panel1.Controls.Add(this.buttonKupony);
            this.panel1.Controls.Add(this.buttonKontakt);
            this.panel1.Controls.Add(this.buttonRestauracje);
            this.panel1.Controls.Add(this.buttonKoszyk);
            this.panel1.Location = new System.Drawing.Point(10, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 90);
            this.panel1.TabIndex = 25;
            // 
            // buttonMenu
            // 
            this.buttonMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMenu.Location = new System.Drawing.Point(3, 5);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(220, 80);
            this.buttonMenu.TabIndex = 20;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseMnemonic = false;
            this.buttonMenu.UseVisualStyleBackColor = true;
            // 
            // buttonKupony
            // 
            this.buttonKupony.FlatAppearance.BorderSize = 0;
            this.buttonKupony.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKupony.Location = new System.Drawing.Point(229, 5);
            this.buttonKupony.Name = "buttonKupony";
            this.buttonKupony.Size = new System.Drawing.Size(220, 80);
            this.buttonKupony.TabIndex = 19;
            this.buttonKupony.Text = "Kupony";
            this.buttonKupony.UseVisualStyleBackColor = true;
            // 
            // buttonKontakt
            // 
            this.buttonKontakt.FlatAppearance.BorderSize = 0;
            this.buttonKontakt.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKontakt.Location = new System.Drawing.Point(919, 5);
            this.buttonKontakt.Name = "buttonKontakt";
            this.buttonKontakt.Size = new System.Drawing.Size(220, 80);
            this.buttonKontakt.TabIndex = 21;
            this.buttonKontakt.Text = "Kontakt";
            this.buttonKontakt.UseVisualStyleBackColor = true;
            // 
            // buttonRestauracje
            // 
            this.buttonRestauracje.FlatAppearance.BorderSize = 0;
            this.buttonRestauracje.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRestauracje.Location = new System.Drawing.Point(693, 5);
            this.buttonRestauracje.Name = "buttonRestauracje";
            this.buttonRestauracje.Size = new System.Drawing.Size(220, 80);
            this.buttonRestauracje.TabIndex = 17;
            this.buttonRestauracje.Text = "Nasze Restauracje";
            this.buttonRestauracje.UseVisualStyleBackColor = true;
            // 
            // buttonKoszyk
            // 
            this.buttonKoszyk.FlatAppearance.BorderSize = 0;
            this.buttonKoszyk.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKoszyk.Location = new System.Drawing.Point(460, 5);
            this.buttonKoszyk.Name = "buttonKoszyk";
            this.buttonKoszyk.Size = new System.Drawing.Size(220, 80);
            this.buttonKoszyk.TabIndex = 18;
            this.buttonKoszyk.Text = "Koszyk";
            this.buttonKoszyk.UseVisualStyleBackColor = true;
            // 
            // ZDU
            // 
            this.ZDU.FlatAppearance.BorderSize = 0;
            this.ZDU.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZDU.Location = new System.Drawing.Point(864, 198);
            this.ZDU.Name = "ZDU";
            this.ZDU.Size = new System.Drawing.Size(220, 80);
            this.ZDU.TabIndex = 26;
            this.ZDU.Text = "Zmiana danych użytkownika";
            this.ZDU.UseVisualStyleBackColor = true;
            this.ZDU.Click += new System.EventHandler(this.ZDU_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(58, 235);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(181, 134);
            this.listBox1.TabIndex = 27;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnWyloguj
            // 
            btnWyloguj.Location = new System.Drawing.Point(864, 314);
            btnWyloguj.Name = "btnWyloguj";
            btnWyloguj.Size = new System.Drawing.Size(220, 69);
            btnWyloguj.TabIndex = 28;
            btnWyloguj.Text = "Wyloguj";
            btnWyloguj.UseVisualStyleBackColor = true;
            btnWyloguj.Click += new System.EventHandler(this.btnWyloguj_Click);
            // 
            // stronaGlownaZalogowana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 610);
            this.Controls.Add(btnWyloguj);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ZDU);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonLogo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "stronaGlownaZalogowana";
            this.Text = "stronaGlownaZalogowana";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonKupony;
        private System.Windows.Forms.Button buttonKontakt;
        private System.Windows.Forms.Button buttonRestauracje;
        private System.Windows.Forms.Button buttonKoszyk;
        private System.Windows.Forms.Button ZDU;
        private System.Windows.Forms.ListBox listBox1;
    }
}