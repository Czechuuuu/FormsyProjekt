namespace Kowalczyk
{
    partial class UU
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
            this.kogousunac = new System.Windows.Forms.TextBox();
            this.button_exit = new System.Windows.Forms.Button();
            this.ListaU = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.asd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(76, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID użytkownika, którego chcesz usunąć";
            // 
            // kogousunac
            // 
            this.kogousunac.Location = new System.Drawing.Point(80, 194);
            this.kogousunac.Name = "kogousunac";
            this.kogousunac.Size = new System.Drawing.Size(76, 20);
            this.kogousunac.TabIndex = 14;
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(80, 336);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 16;
            this.button_exit.Text = "Wyjście";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // ListaU
            // 
            this.ListaU.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ListaU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListaU.FormattingEnabled = true;
            this.ListaU.ItemHeight = 17;
            this.ListaU.Location = new System.Drawing.Point(474, 77);
            this.ListaU.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListaU.Name = "ListaU";
            this.ListaU.Size = new System.Drawing.Size(282, 344);
            this.ListaU.TabIndex = 17;
            this.ListaU.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(470, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Lista użytkowników";
            // 
            // asd
            // 
            this.asd.Location = new System.Drawing.Point(80, 218);
            this.asd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(75, 23);
            this.asd.TabIndex = 19;
            this.asd.Text = "Zatwierdz ";
            this.asd.UseVisualStyleBackColor = true;
            this.asd.Click += new System.EventHandler(this.asd_Click);
            // 
            // UU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.asd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListaU);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.kogousunac);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UU";
            this.Text = "Usunięcie użytkownika";
            this.Load += new System.EventHandler(this.UU_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kogousunac;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button asd;
        public System.Windows.Forms.ListBox ListaU;
    }
}