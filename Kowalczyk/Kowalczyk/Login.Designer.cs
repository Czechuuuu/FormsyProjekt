namespace Kowalczyk
{
    partial class Login
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.passHide = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPassHide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logowanie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwa użytkownika:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasło:";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(295, 167);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(219, 20);
            this.user.TabIndex = 3;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(295, 219);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(219, 20);
            this.pass.TabIndex = 4;
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(439, 286);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 23);
            this.button_login.TabIndex = 5;
            this.button_login.Text = "Zaloguj";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(97, 371);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 6;
            this.button_exit.Text = "Wyjście";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // passHide
            // 
            this.passHide.Location = new System.Drawing.Point(295, 219);
            this.passHide.Name = "passHide";
            this.passHide.Size = new System.Drawing.Size(219, 20);
            this.passHide.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPassHide
            // 
            this.btnPassHide.Location = new System.Drawing.Point(520, 217);
            this.btnPassHide.Name = "btnPassHide";
            this.btnPassHide.Size = new System.Drawing.Size(75, 23);
            this.btnPassHide.TabIndex = 8;
            this.btnPassHide.Text = "Pokaż hasło";
            this.btnPassHide.UseVisualStyleBackColor = true;
            this.btnPassHide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPassHide_MouseDown);
            this.btnPassHide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnPassHide_MouseUp);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPassHide);
            this.Controls.Add(this.passHide);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.TextBox passHide;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPassHide;
    }
}

