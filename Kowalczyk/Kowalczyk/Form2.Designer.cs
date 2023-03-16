namespace Kowalczyk
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnLogo1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogo1
            // 
            this.btnLogo1.Image = ((System.Drawing.Image)(resources.GetObject("btnLogo1.Image")));
            this.btnLogo1.Location = new System.Drawing.Point(13, 13);
            this.btnLogo1.Name = "btnLogo1";
            this.btnLogo1.Size = new System.Drawing.Size(500, 75);
            this.btnLogo1.TabIndex = 1;
            this.btnLogo1.UseVisualStyleBackColor = true;
            this.btnLogo1.Click += new System.EventHandler(this.btnLogo1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogo1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogo1;
    }
}