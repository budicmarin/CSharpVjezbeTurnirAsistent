namespace AsistentGUI
{
    partial class PrijavaTurnir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrijavaTurnir));
            this.Zapocni = new System.Windows.Forms.Button();
            this.Novi = new System.Windows.Forms.Button();
            this.Izaberi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Zapocni
            // 
            this.Zapocni.Location = new System.Drawing.Point(269, 246);
            this.Zapocni.Name = "Zapocni";
            this.Zapocni.Size = new System.Drawing.Size(274, 66);
            this.Zapocni.TabIndex = 0;
            this.Zapocni.Text = "Pokreni turnir";
            this.Zapocni.UseVisualStyleBackColor = true;
            // 
            // Novi
            // 
            this.Novi.Location = new System.Drawing.Point(269, 318);
            this.Novi.Name = "Novi";
            this.Novi.Size = new System.Drawing.Size(274, 66);
            this.Novi.TabIndex = 1;
            this.Novi.Text = "Novi Tunrir";
            this.Novi.UseVisualStyleBackColor = true;
            // 
            // Izaberi
            // 
            this.Izaberi.FormattingEnabled = true;
            this.Izaberi.Location = new System.Drawing.Point(269, 140);
            this.Izaberi.Name = "Izaberi";
            this.Izaberi.Size = new System.Drawing.Size(274, 24);
            this.Izaberi.TabIndex = 2;
            // 
            // PrijavaTurnir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Izaberi);
            this.Controls.Add(this.Novi);
            this.Controls.Add(this.Zapocni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrijavaTurnir";
            this.Text = "PrijavaTurnir";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Zapocni;
        private System.Windows.Forms.Button Novi;
        private System.Windows.Forms.ComboBox Izaberi;
    }
}