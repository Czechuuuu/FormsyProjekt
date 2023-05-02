namespace Kowalczyk
{
    partial class ZDU2
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
            this.label1 = new System.Windows.Forms.Label();
            this.komuzmienicdane = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ListaU = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.newlogin = new System.Windows.Forms.TextBox();
            this.newpass = new System.Windows.Forms.TextBox();
            this.asd = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(40, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID użytkownika, którego dane mają zostać zmienione\r\n";
            // 
            // komuzmienicdane
            // 
            this.komuzmienicdane.Location = new System.Drawing.Point(45, 101);
            this.komuzmienicdane.Margin = new System.Windows.Forms.Padding(4);
            this.komuzmienicdane.Name = "komuzmienicdane";
            this.komuzmienicdane.Size = new System.Drawing.Size(100, 22);
            this.komuzmienicdane.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(744, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Lista użytkowników";
            // 
            // ListaU
            // 
            this.ListaU.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ListaU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListaU.FormattingEnabled = true;
            this.ListaU.ItemHeight = 20;
            this.ListaU.Location = new System.Drawing.Point(670, 83);
            this.ListaU.Name = "ListaU";
            this.ListaU.Size = new System.Drawing.Size(375, 424);
            this.ListaU.TabIndex = 20;
            this.ListaU.SelectedIndexChanged += new System.EventHandler(this.ListaU_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(40, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nowy login użytkownika";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(40, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 29);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nowe hasło użytkownika";
            // 
            // newlogin
            // 
            this.newlogin.Location = new System.Drawing.Point(45, 183);
            this.newlogin.Margin = new System.Windows.Forms.Padding(4);
            this.newlogin.Name = "newlogin";
            this.newlogin.Size = new System.Drawing.Size(218, 22);
            this.newlogin.TabIndex = 23;
            // 
            // newpass
            // 
            this.newpass.Location = new System.Drawing.Point(45, 264);
            this.newpass.Margin = new System.Windows.Forms.Padding(4);
            this.newpass.Name = "newpass";
            this.newpass.Size = new System.Drawing.Size(218, 22);
            this.newpass.TabIndex = 24;
            // 
            // asd
            // 
            this.asd.Location = new System.Drawing.Point(45, 321);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(100, 28);
            this.asd.TabIndex = 25;
            this.asd.Text = "Zatwierdz ";
            this.asd.UseVisualStyleBackColor = true;
            this.asd.Click += new System.EventHandler(this.asd_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(45, 402);
            this.button_exit.Margin = new System.Windows.Forms.Padding(4);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(100, 28);
            this.button_exit.TabIndex = 26;
            this.button_exit.Text = "Wyjście";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // ZDU2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.asd);
            this.Controls.Add(this.newpass);
            this.Controls.Add(this.newlogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListaU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.komuzmienicdane);
            this.Controls.Add(this.label1);
            this.Name = "ZDU2";
            this.Text = "Zmiana danych użytkownika";
            this.Load += new System.EventHandler(this.ZDU2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox komuzmienicdane;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListBox ListaU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newlogin;
        private System.Windows.Forms.TextBox newpass;
        private System.Windows.Forms.Button asd;
        private System.Windows.Forms.Button button_exit;
    }
}