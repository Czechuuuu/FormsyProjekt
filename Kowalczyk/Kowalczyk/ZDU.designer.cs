namespace Kowalczyk
{
    partial class ZDU
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
            this.ObecneHaslo = new System.Windows.Forms.Label();
            this.NoweHaslo = new System.Windows.Forms.Label();
            this.curpass = new System.Windows.Forms.TextBox();
            this.newpass = new System.Windows.Forms.TextBox();
            this.asd = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ObecneHaslo
            // 
            this.ObecneHaslo.AutoSize = true;
            this.ObecneHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObecneHaslo.Location = new System.Drawing.Point(124, 201);
            this.ObecneHaslo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ObecneHaslo.Name = "ObecneHaslo";
            this.ObecneHaslo.Size = new System.Drawing.Size(185, 29);
            this.ObecneHaslo.TabIndex = 2;
            this.ObecneHaslo.Text = "Obecne hasło:";
            // 
            // NoweHaslo
            // 
            this.NoweHaslo.AutoSize = true;
            this.NoweHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoweHaslo.Location = new System.Drawing.Point(124, 270);
            this.NoweHaslo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NoweHaslo.Name = "NoweHaslo";
            this.NoweHaslo.Size = new System.Drawing.Size(161, 29);
            this.NoweHaslo.TabIndex = 3;
            this.NoweHaslo.Text = "Nowe hasło:";
            // 
            // curpass
            // 
            this.curpass.Location = new System.Drawing.Point(393, 206);
            this.curpass.Margin = new System.Windows.Forms.Padding(4);
            this.curpass.Name = "curpass";
            this.curpass.Size = new System.Drawing.Size(291, 22);
            this.curpass.TabIndex = 4;
            this.curpass.TextChanged += new System.EventHandler(this.curpass_TextChanged);
            // 
            // newpass
            // 
            this.newpass.Location = new System.Drawing.Point(393, 270);
            this.newpass.Margin = new System.Windows.Forms.Padding(4);
            this.newpass.Name = "newpass";
            this.newpass.Size = new System.Drawing.Size(291, 22);
            this.newpass.TabIndex = 5;
            // 
            // asd
            // 
            this.asd.Location = new System.Drawing.Point(556, 352);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(128, 28);
            this.asd.TabIndex = 6;
            this.asd.Text = "Zatwierdz zmiany";
            this.asd.UseVisualStyleBackColor = true;
            this.asd.Click += new System.EventHandler(this.asd_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(212, 352);
            this.button_exit.Margin = new System.Windows.Forms.Padding(4);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(100, 28);
            this.button_exit.TabIndex = 8;
            this.button_exit.Text = "Wyjście";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // ZDU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.asd);
            this.Controls.Add(this.newpass);
            this.Controls.Add(this.curpass);
            this.Controls.Add(this.NoweHaslo);
            this.Controls.Add(this.ObecneHaslo);
            this.Name = "ZDU";
            this.Text = "Zmiana danych";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ObecneHaslo;
        private System.Windows.Forms.Label NoweHaslo;
        private System.Windows.Forms.TextBox curpass;
        private System.Windows.Forms.TextBox newpass;
        private System.Windows.Forms.Button asd;
        private System.Windows.Forms.Button button_exit;
    }
}