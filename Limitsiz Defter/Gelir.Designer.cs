namespace Limitsiz_Defter
{
    partial class Gelir
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
            this.gtarihidtp = new System.Windows.Forms.DateTimePicker();
            this.gaciklamartb = new System.Windows.Forms.RichTextBox();
            this.giptalpb = new System.Windows.Forms.PictureBox();
            this.gkaydetpb = new System.Windows.Forms.PictureBox();
            this.gturucb = new System.Windows.Forms.ComboBox();
            this.gtutarrtb = new System.Windows.Forms.RichTextBox();
            this.gaciklamalbl = new System.Windows.Forms.Label();
            this.gtarihlbl = new System.Windows.Forms.Label();
            this.gturulbl = new System.Windows.Forms.Label();
            this.gtutarlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.giptalpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gkaydetpb)).BeginInit();
            this.SuspendLayout();
            // 
            // gtarihidtp
            // 
            this.gtarihidtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gtarihidtp.Location = new System.Drawing.Point(268, 198);
            this.gtarihidtp.Name = "gtarihidtp";
            this.gtarihidtp.Size = new System.Drawing.Size(225, 35);
            this.gtarihidtp.TabIndex = 0;
            // 
            // gaciklamartb
            // 
            this.gaciklamartb.Location = new System.Drawing.Point(268, 40);
            this.gaciklamartb.Name = "gaciklamartb";
            this.gaciklamartb.ShortcutsEnabled = false;
            this.gaciklamartb.Size = new System.Drawing.Size(225, 115);
            this.gaciklamartb.TabIndex = 1;
            this.gaciklamartb.Text = " ";
            // 
            // giptalpb
            // 
            this.giptalpb.BackColor = System.Drawing.Color.Transparent;
            this.giptalpb.BackgroundImage = global::Limitsiz_Defter.Properties.Resources.iptal1;
            this.giptalpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.giptalpb.Location = new System.Drawing.Point(265, 424);
            this.giptalpb.Name = "giptalpb";
            this.giptalpb.Size = new System.Drawing.Size(100, 50);
            this.giptalpb.TabIndex = 59;
            this.giptalpb.TabStop = false;
            // 
            // gkaydetpb
            // 
            this.gkaydetpb.BackColor = System.Drawing.Color.Transparent;
            this.gkaydetpb.BackgroundImage = global::Limitsiz_Defter.Properties.Resources.kaydet1;
            this.gkaydetpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gkaydetpb.Location = new System.Drawing.Point(393, 424);
            this.gkaydetpb.Name = "gkaydetpb";
            this.gkaydetpb.Size = new System.Drawing.Size(100, 50);
            this.gkaydetpb.TabIndex = 58;
            this.gkaydetpb.TabStop = false;
            this.gkaydetpb.Click += new System.EventHandler(this.Gkaydetpb_Click);
            // 
            // gturucb
            // 
            this.gturucb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gturucb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gturucb.FormattingEnabled = true;
            this.gturucb.Location = new System.Drawing.Point(268, 275);
            this.gturucb.Name = "gturucb";
            this.gturucb.Size = new System.Drawing.Size(225, 37);
            this.gturucb.TabIndex = 60;
            // 
            // gtutarrtb
            // 
            this.gtutarrtb.Location = new System.Drawing.Point(268, 352);
            this.gtutarrtb.Name = "gtutarrtb";
            this.gtutarrtb.ShortcutsEnabled = false;
            this.gtutarrtb.Size = new System.Drawing.Size(225, 66);
            this.gtutarrtb.TabIndex = 61;
            this.gtutarrtb.Text = " ";
            this.gtutarrtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gtutarrtb_KeyPress);
            // 
            // gaciklamalbl
            // 
            this.gaciklamalbl.AutoSize = true;
            this.gaciklamalbl.BackColor = System.Drawing.Color.Transparent;
            this.gaciklamalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gaciklamalbl.ForeColor = System.Drawing.Color.White;
            this.gaciklamalbl.Location = new System.Drawing.Point(267, 17);
            this.gaciklamalbl.Name = "gaciklamalbl";
            this.gaciklamalbl.Size = new System.Drawing.Size(81, 20);
            this.gaciklamalbl.TabIndex = 62;
            this.gaciklamalbl.Text = "Açıklama";
            // 
            // gtarihlbl
            // 
            this.gtarihlbl.AutoSize = true;
            this.gtarihlbl.BackColor = System.Drawing.Color.Transparent;
            this.gtarihlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gtarihlbl.ForeColor = System.Drawing.Color.White;
            this.gtarihlbl.Location = new System.Drawing.Point(267, 175);
            this.gtarihlbl.Name = "gtarihlbl";
            this.gtarihlbl.Size = new System.Drawing.Size(49, 20);
            this.gtarihlbl.TabIndex = 63;
            this.gtarihlbl.Text = "Tarih";
            // 
            // gturulbl
            // 
            this.gturulbl.AutoSize = true;
            this.gturulbl.BackColor = System.Drawing.Color.Transparent;
            this.gturulbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gturulbl.ForeColor = System.Drawing.Color.White;
            this.gturulbl.Location = new System.Drawing.Point(267, 252);
            this.gturulbl.Name = "gturulbl";
            this.gturulbl.Size = new System.Drawing.Size(107, 20);
            this.gturulbl.TabIndex = 64;
            this.gturulbl.Text = "Ödeme Türü";
            // 
            // gtutarlbl
            // 
            this.gtutarlbl.AutoSize = true;
            this.gtutarlbl.BackColor = System.Drawing.Color.Transparent;
            this.gtutarlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gtutarlbl.ForeColor = System.Drawing.Color.White;
            this.gtutarlbl.Location = new System.Drawing.Point(267, 329);
            this.gtutarlbl.Name = "gtutarlbl";
            this.gtutarlbl.Size = new System.Drawing.Size(51, 20);
            this.gtutarlbl.TabIndex = 65;
            this.gtutarlbl.Text = "Tutar";
            // 
            // Gelir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Limitsiz_Defter.Properties.Resources._1__3_4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gtutarlbl);
            this.Controls.Add(this.gturulbl);
            this.Controls.Add(this.gtarihlbl);
            this.Controls.Add(this.gaciklamalbl);
            this.Controls.Add(this.gtutarrtb);
            this.Controls.Add(this.gturucb);
            this.Controls.Add(this.giptalpb);
            this.Controls.Add(this.gkaydetpb);
            this.Controls.Add(this.gaciklamartb);
            this.Controls.Add(this.gtarihidtp);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Gelir";
            this.Text = "Gelir";
            this.Load += new System.EventHandler(this.Gelir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.giptalpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gkaydetpb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker gtarihidtp;
        private System.Windows.Forms.RichTextBox gaciklamartb;
        private System.Windows.Forms.PictureBox giptalpb;
        private System.Windows.Forms.PictureBox gkaydetpb;
        private System.Windows.Forms.ComboBox gturucb;
        private System.Windows.Forms.RichTextBox gtutarrtb;
        private System.Windows.Forms.Label gaciklamalbl;
        private System.Windows.Forms.Label gtarihlbl;
        private System.Windows.Forms.Label gturulbl;
        private System.Windows.Forms.Label gtutarlbl;
    }
}