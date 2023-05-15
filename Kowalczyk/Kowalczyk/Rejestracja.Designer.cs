namespace Kowalczyk
{
    partial class Rej
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rej));
            this.label1 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.haslo = new System.Windows.Forms.TextBox();
            this.Phaslo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.Zatwierdz = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.passHide = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // login
            // 
            resources.ApplyResources(this.login, "login");
            this.login.Name = "login";
            // 
            // haslo
            // 
            resources.ApplyResources(this.haslo, "haslo");
            this.haslo.Name = "haslo";
            // 
            // Phaslo
            // 
            resources.ApplyResources(this.Phaslo, "Phaslo");
            this.Phaslo.Name = "Phaslo";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button_exit
            // 
            resources.ApplyResources(this.button_exit, "button_exit");
            this.button_exit.Name = "button_exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click_1);
            // 
            // Zatwierdz
            // 
            resources.ApplyResources(this.Zatwierdz, "Zatwierdz");
            this.Zatwierdz.Name = "Zatwierdz";
            this.Zatwierdz.UseVisualStyleBackColor = true;
            this.Zatwierdz.Click += new System.EventHandler(this.Zatwierdz_Click_1);
            // 
            // btnHide
            // 
            resources.ApplyResources(this.btnHide, "btnHide");
            this.btnHide.Name = "btnHide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHide_MouseDown);
            this.btnHide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnHide_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // passHide
            // 
            resources.ApplyResources(this.passHide, "passHide");
            this.passHide.Name = "passHide";
            // 
            // Rej
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.Controls.Add(this.passHide);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.Zatwierdz);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Phaslo);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label1);
            this.Name = "Rej";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox haslo;
        private System.Windows.Forms.TextBox Phaslo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button Zatwierdz;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox passHide;
    }
}