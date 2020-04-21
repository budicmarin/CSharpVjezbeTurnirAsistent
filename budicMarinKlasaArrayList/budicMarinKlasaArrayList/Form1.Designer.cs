namespace budicMarinKlasaArrayList
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
            this.buttonNovi = new System.Windows.Forms.Button();
            this.buttonUnesi = new System.Windows.Forms.Button();
            this.textBoxNovi = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNovi
            // 
            this.buttonNovi.Location = new System.Drawing.Point(12, 12);
            this.buttonNovi.Name = "buttonNovi";
            this.buttonNovi.Size = new System.Drawing.Size(198, 23);
            this.buttonNovi.TabIndex = 0;
            this.buttonNovi.Text = "Novi Automobil";
            this.buttonNovi.UseVisualStyleBackColor = true;
            this.buttonNovi.Click += new System.EventHandler(this.ButtonNovi_Click);
            // 
            // buttonUnesi
            // 
            this.buttonUnesi.Enabled = false;
            this.buttonUnesi.Location = new System.Drawing.Point(230, 41);
            this.buttonUnesi.Name = "buttonUnesi";
            this.buttonUnesi.Size = new System.Drawing.Size(75, 23);
            this.buttonUnesi.TabIndex = 1;
            this.buttonUnesi.Text = "Unesi";
            this.buttonUnesi.UseVisualStyleBackColor = true;
            this.buttonUnesi.Click += new System.EventHandler(this.ButtonUnesi_Click);
            // 
            // textBoxNovi
            // 
            this.textBoxNovi.Enabled = false;
            this.textBoxNovi.Location = new System.Drawing.Point(12, 41);
            this.textBoxNovi.Multiline = true;
            this.textBoxNovi.Name = "textBoxNovi";
            this.textBoxNovi.Size = new System.Drawing.Size(198, 23);
            this.textBoxNovi.TabIndex = 2;
            this.textBoxNovi.TextChanged += new System.EventHandler(this.TextBoxNovi_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 83);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(306, 306);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Location = new System.Drawing.Point(12, 396);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(75, 23);
            this.buttonObrisi.TabIndex = 4;
            this.buttonObrisi.Text = "Obriši";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.ButtonObrisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 450);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBoxNovi);
            this.Controls.Add(this.buttonUnesi);
            this.Controls.Add(this.buttonNovi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNovi;
        private System.Windows.Forms.Button buttonUnesi;
        private System.Windows.Forms.TextBox textBoxNovi;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonObrisi;
    }
}

