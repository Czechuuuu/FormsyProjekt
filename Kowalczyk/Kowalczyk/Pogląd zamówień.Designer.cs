namespace Kowalczyk
{
    partial class PoglądZamówień
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
            this.listazam = new System.Windows.Forms.ListBox();
            this.button_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IOZ = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listazam
            // 
            this.listazam.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.listazam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listazam.FormattingEnabled = true;
            this.listazam.ItemHeight = 20;
            this.listazam.Location = new System.Drawing.Point(615, 39);
            this.listazam.Name = "listazam";
            this.listazam.Size = new System.Drawing.Size(426, 424);
            this.listazam.TabIndex = 32;
            this.listazam.SelectedIndexChanged += new System.EventHandler(this.ListaU_SelectedIndexChanged);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(57, 475);
            this.button_exit.Margin = new System.Windows.Forms.Padding(4);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(100, 28);
            this.button_exit.TabIndex = 33;
            this.button_exit.Text = "Wyjście";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(610, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "Obecne zamówienia";
            // 
            // IOZ
            // 
            this.IOZ.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.IOZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IOZ.FormattingEnabled = true;
            this.IOZ.ItemHeight = 20;
            this.IOZ.Location = new System.Drawing.Point(142, 39);
            this.IOZ.Name = "IOZ";
            this.IOZ.Size = new System.Drawing.Size(426, 424);
            this.IOZ.TabIndex = 35;
            this.IOZ.SelectedIndexChanged += new System.EventHandler(this.IOZ_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(137, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 29);
            this.label2.TabIndex = 36;
            this.label2.Text = "Informacje odnośnie zamawiających";
            // 
            // PoglądZamówień
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IOZ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.listazam);
            this.Name = "PoglądZamówień";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PoglądZamówień_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listazam;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox IOZ;
        private System.Windows.Forms.Label label2;
    }
}