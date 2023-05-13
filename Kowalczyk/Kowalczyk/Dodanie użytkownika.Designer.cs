namespace Kowalczyk
{
    partial class DU
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.haslo = new System.Windows.Forms.TextBox();
            this.asd = new System.Windows.Forms.Button();
            this.ListaU = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(52, 370);
            this.button_exit.Margin = new System.Windows.Forms.Padding(4);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(100, 28);
            this.button_exit.TabIndex = 10;
            this.button_exit.Text = "Wyjście";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(47, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Login nowego użytkownika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(47, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hasło nowego użytkownika";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(52, 116);
            this.login.Margin = new System.Windows.Forms.Padding(4);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(291, 22);
            this.login.TabIndex = 13;
            this.login.TextChanged += new System.EventHandler(this.user_TextChanged);
            // 
            // haslo
            // 
            this.haslo.Location = new System.Drawing.Point(52, 228);
            this.haslo.Margin = new System.Windows.Forms.Padding(4);
            this.haslo.Name = "haslo";
            this.haslo.Size = new System.Drawing.Size(291, 22);
            this.haslo.TabIndex = 14;
            // 
            // asd
            // 
            this.asd.Location = new System.Drawing.Point(52, 289);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(128, 28);
            this.asd.TabIndex = 16;
            this.asd.Text = "Zatwierdz ";
            this.asd.UseVisualStyleBackColor = true;
            this.asd.Click += new System.EventHandler(this.asd_Click);
            // 
            // ListaU
            // 
            this.ListaU.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ListaU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListaU.FormattingEnabled = true;
            this.ListaU.ItemHeight = 20;
            this.ListaU.Location = new System.Drawing.Point(578, 72);
            this.ListaU.Name = "ListaU";
            this.ListaU.Size = new System.Drawing.Size(375, 424);
            this.ListaU.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(573, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 29);
            this.label3.TabIndex = 33;
            this.label3.Text = "Lista użytkowników";
            // 
            // DU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListaU);
            this.Controls.Add(this.asd);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_exit);
            this.Name = "DU";
            this.Text = "Dodanie użytkownika";
            this.Load += new System.EventHandler(this.DU_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox haslo;
        private System.Windows.Forms.Button asd;
        public System.Windows.Forms.ListBox ListaU;
        private System.Windows.Forms.Label label3;
    }
}