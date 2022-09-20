namespace Limitsiz_Defter
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.kullanicirtb = new System.Windows.Forms.RichTextBox();
            this.sifrertb = new System.Windows.Forms.RichTextBox();
            this.kullanicilbl = new System.Windows.Forms.Label();
            this.sifrelbl = new System.Windows.Forms.Label();
            this.girispb = new System.Windows.Forms.PictureBox();
            this.cikispb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.girispb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikispb)).BeginInit();
            this.SuspendLayout();
            // 
            // kullanicirtb
            // 
            this.kullanicirtb.Font = new System.Drawing.Font("Montserrat ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullanicirtb.Location = new System.Drawing.Point(277, 270);
            this.kullanicirtb.Multiline = false;
            this.kullanicirtb.Name = "kullanicirtb";
            this.kullanicirtb.ShortcutsEnabled = false;
            this.kullanicirtb.Size = new System.Drawing.Size(355, 82);
            this.kullanicirtb.TabIndex = 0;
            this.kullanicirtb.Text = "kortel";
            // 
            // sifrertb
            // 
            this.sifrertb.Font = new System.Drawing.Font("Montserrat ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifrertb.Location = new System.Drawing.Point(277, 372);
            this.sifrertb.Multiline = false;
            this.sifrertb.Name = "sifrertb";
            this.sifrertb.ShortcutsEnabled = false;
            this.sifrertb.Size = new System.Drawing.Size(355, 82);
            this.sifrertb.TabIndex = 1;
            this.sifrertb.Text = "kortel123";
            // 
            // kullanicilbl
            // 
            this.kullanicilbl.AutoSize = true;
            this.kullanicilbl.BackColor = System.Drawing.Color.Transparent;
            this.kullanicilbl.Font = new System.Drawing.Font("Montserrat Black", 31F, System.Drawing.FontStyle.Bold);
            this.kullanicilbl.ForeColor = System.Drawing.Color.White;
            this.kullanicilbl.Location = new System.Drawing.Point(22, 280);
            this.kullanicilbl.Name = "kullanicilbl";
            this.kullanicilbl.Size = new System.Drawing.Size(249, 58);
            this.kullanicilbl.TabIndex = 3;
            this.kullanicilbl.Text = "Kullanıcı :";
            // 
            // sifrelbl
            // 
            this.sifrelbl.AutoSize = true;
            this.sifrelbl.BackColor = System.Drawing.Color.Transparent;
            this.sifrelbl.Font = new System.Drawing.Font("Montserrat Black", 31F, System.Drawing.FontStyle.Bold);
            this.sifrelbl.ForeColor = System.Drawing.Color.White;
            this.sifrelbl.Location = new System.Drawing.Point(20, 382);
            this.sifrelbl.Name = "sifrelbl";
            this.sifrelbl.Size = new System.Drawing.Size(251, 58);
            this.sifrelbl.TabIndex = 4;
            this.sifrelbl.Text = "Şifre        :";
            // 
            // girispb
            // 
            this.girispb.BackColor = System.Drawing.Color.Transparent;
            this.girispb.BackgroundImage = global::Limitsiz_Defter.Properties.Resources.tick1;
            this.girispb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.girispb.Location = new System.Drawing.Point(532, 460);
            this.girispb.Name = "girispb";
            this.girispb.Size = new System.Drawing.Size(100, 89);
            this.girispb.TabIndex = 5;
            this.girispb.TabStop = false;
            this.girispb.Click += new System.EventHandler(this.girispb_Click);
            // 
            // cikispb
            // 
            this.cikispb.BackColor = System.Drawing.Color.Transparent;
            this.cikispb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cikispb.BackgroundImage")));
            this.cikispb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cikispb.Location = new System.Drawing.Point(277, 460);
            this.cikispb.Name = "cikispb";
            this.cikispb.Size = new System.Drawing.Size(100, 89);
            this.cikispb.TabIndex = 6;
            this.cikispb.TabStop = false;
            this.cikispb.Click += new System.EventHandler(this.cikispb_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Limitsiz_Defter.Properties.Resources.limiitsizdefter_giris_bg1;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.cikispb);
            this.Controls.Add(this.girispb);
            this.Controls.Add(this.sifrelbl);
            this.Controls.Add(this.kullanicilbl);
            this.Controls.Add(this.sifrertb);
            this.Controls.Add(this.kullanicirtb);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Giris";
            this.Text = "Limitsiz Defter | Giriş";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Giris_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.girispb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikispb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox kullanicirtb;
        private System.Windows.Forms.RichTextBox sifrertb;
        private System.Windows.Forms.Label kullanicilbl;
        private System.Windows.Forms.Label sifrelbl;
        private System.Windows.Forms.PictureBox girispb;
        private System.Windows.Forms.PictureBox cikispb;
    }
}

