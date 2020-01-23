namespace budicMarinWindowsForm
{
    partial class Form1
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
            this.citaj = new System.Windows.Forms.Button();
            this.brisi = new System.Windows.Forms.Button();
            this.spremi = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // citaj
            // 
            this.citaj.Location = new System.Drawing.Point(13, 43);
            this.citaj.Name = "citaj";
            this.citaj.Size = new System.Drawing.Size(75, 23);
            this.citaj.TabIndex = 0;
            this.citaj.Text = "Čitaj";
            this.citaj.UseVisualStyleBackColor = true;
            this.citaj.Click += new System.EventHandler(this.Citaj_Click);
            // 
            // brisi
            // 
            this.brisi.Location = new System.Drawing.Point(625, 43);
            this.brisi.Name = "brisi";
            this.brisi.Size = new System.Drawing.Size(75, 23);
            this.brisi.TabIndex = 1;
            this.brisi.Text = "Briši";
            this.brisi.UseVisualStyleBackColor = true;
            this.brisi.Click += new System.EventHandler(this.Brisi_Click);
            // 
            // spremi
            // 
            this.spremi.Location = new System.Drawing.Point(13, 388);
            this.spremi.Name = "spremi";
            this.spremi.Size = new System.Drawing.Size(75, 23);
            this.spremi.TabIndex = 2;
            this.spremi.Text = "Spremi";
            this.spremi.UseVisualStyleBackColor = true;
            this.spremi.Click += new System.EventHandler(this.Spremi_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 74);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(687, 304);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.spremi);
            this.Controls.Add(this.brisi);
            this.Controls.Add(this.citaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button citaj;
        private System.Windows.Forms.Button brisi;
        private System.Windows.Forms.Button spremi;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

