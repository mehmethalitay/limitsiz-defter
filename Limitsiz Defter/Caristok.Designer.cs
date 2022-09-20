namespace Limitsiz_Defter
{
    partial class Caristok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caristok));
            this.ssogcbx = new System.Windows.Forms.CheckBox();
            this.saralbl = new System.Windows.Forms.Label();
            this.sarartb = new System.Windows.Forms.RichTextBox();
            this.syazirpb = new System.Windows.Forms.PictureBox();
            this.sraporpb = new System.Windows.Forms.PictureBox();
            this.ssontarihlbl = new System.Windows.Forms.Label();
            this.silktarihlbl = new System.Windows.Forms.Label();
            this.ssontarihdtp = new System.Windows.Forms.DateTimePicker();
            this.silktarihdtp = new System.Windows.Forms.DateTimePicker();
            this.sfaturagw = new System.Windows.Forms.DataGridView();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.syazirpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sraporpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfaturagw)).BeginInit();
            this.SuspendLayout();
            // 
            // ssogcbx
            // 
            this.ssogcbx.AutoSize = true;
            this.ssogcbx.BackColor = System.Drawing.Color.Transparent;
            this.ssogcbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ssogcbx.ForeColor = System.Drawing.Color.White;
            this.ssogcbx.Location = new System.Drawing.Point(554, 36);
            this.ssogcbx.Name = "ssogcbx";
            this.ssogcbx.Size = new System.Drawing.Size(218, 29);
            this.ssogcbx.TabIndex = 50;
            this.ssogcbx.Text = "Sıfır Olanları Göster";
            this.ssogcbx.UseVisualStyleBackColor = false;
            // 
            // saralbl
            // 
            this.saralbl.AutoSize = true;
            this.saralbl.BackColor = System.Drawing.Color.Transparent;
            this.saralbl.Font = new System.Drawing.Font("Paddington", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saralbl.ForeColor = System.Drawing.Color.White;
            this.saralbl.Location = new System.Drawing.Point(216, 10);
            this.saralbl.Name = "saralbl";
            this.saralbl.Size = new System.Drawing.Size(36, 20);
            this.saralbl.TabIndex = 49;
            this.saralbl.Text = "Ara";
            // 
            // sarartb
            // 
            this.sarartb.Location = new System.Drawing.Point(220, 36);
            this.sarartb.Name = "sarartb";
            this.sarartb.ShortcutsEnabled = false;
            this.sarartb.Size = new System.Drawing.Size(312, 32);
            this.sarartb.TabIndex = 48;
            this.sarartb.Text = "";
            // 
            // syazirpb
            // 
            this.syazirpb.BackColor = System.Drawing.Color.Transparent;
            this.syazirpb.BackgroundImage = global::Limitsiz_Defter.Properties.Resources.yazdir1;
            this.syazirpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.syazirpb.Location = new System.Drawing.Point(326, 75);
            this.syazirpb.Name = "syazirpb";
            this.syazirpb.Size = new System.Drawing.Size(100, 50);
            this.syazirpb.TabIndex = 47;
            this.syazirpb.TabStop = false;
            this.syazirpb.Click += new System.EventHandler(this.syazirpb_Click);
            // 
            // sraporpb
            // 
            this.sraporpb.BackColor = System.Drawing.Color.Transparent;
            this.sraporpb.BackgroundImage = global::Limitsiz_Defter.Properties.Resources.rapor1;
            this.sraporpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sraporpb.Location = new System.Drawing.Point(220, 75);
            this.sraporpb.Name = "sraporpb";
            this.sraporpb.Size = new System.Drawing.Size(100, 50);
            this.sraporpb.TabIndex = 45;
            this.sraporpb.TabStop = false;
            this.sraporpb.Click += new System.EventHandler(this.sraporpb_Click);
            // 
            // ssontarihlbl
            // 
            this.ssontarihlbl.AutoSize = true;
            this.ssontarihlbl.BackColor = System.Drawing.Color.Transparent;
            this.ssontarihlbl.Font = new System.Drawing.Font("Paddington", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ssontarihlbl.ForeColor = System.Drawing.Color.White;
            this.ssontarihlbl.Location = new System.Drawing.Point(10, 70);
            this.ssontarihlbl.Name = "ssontarihlbl";
            this.ssontarihlbl.Size = new System.Drawing.Size(77, 20);
            this.ssontarihlbl.TabIndex = 44;
            this.ssontarihlbl.Text = "Son Tarih";
            // 
            // silktarihlbl
            // 
            this.silktarihlbl.AutoSize = true;
            this.silktarihlbl.BackColor = System.Drawing.Color.Transparent;
            this.silktarihlbl.Font = new System.Drawing.Font("Paddington", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silktarihlbl.ForeColor = System.Drawing.Color.White;
            this.silktarihlbl.Location = new System.Drawing.Point(10, 13);
            this.silktarihlbl.Name = "silktarihlbl";
            this.silktarihlbl.Size = new System.Drawing.Size(68, 20);
            this.silktarihlbl.TabIndex = 43;
            this.silktarihlbl.Text = "İlk Tarih";
            // 
            // ssontarihdtp
            // 
            this.ssontarihdtp.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ssontarihdtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ssontarihdtp.Location = new System.Drawing.Point(14, 93);
            this.ssontarihdtp.Name = "ssontarihdtp";
            this.ssontarihdtp.Size = new System.Drawing.Size(200, 32);
            this.ssontarihdtp.TabIndex = 42;
            // 
            // silktarihdtp
            // 
            this.silktarihdtp.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silktarihdtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.silktarihdtp.Location = new System.Drawing.Point(14, 36);
            this.silktarihdtp.Name = "silktarihdtp";
            this.silktarihdtp.Size = new System.Drawing.Size(200, 32);
            this.silktarihdtp.TabIndex = 41;
            // 
            // sfaturagw
            // 
            this.sfaturagw.AllowUserToAddRows = false;
            this.sfaturagw.AllowUserToDeleteRows = false;
            this.sfaturagw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sfaturagw.Location = new System.Drawing.Point(14, 131);
            this.sfaturagw.Name = "sfaturagw";
            this.sfaturagw.ReadOnly = true;
            this.sfaturagw.Size = new System.Drawing.Size(760, 419);
            this.sfaturagw.TabIndex = 40;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Caristok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Limitsiz_Defter.Properties.Resources._1__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ssogcbx);
            this.Controls.Add(this.saralbl);
            this.Controls.Add(this.sarartb);
            this.Controls.Add(this.syazirpb);
            this.Controls.Add(this.sraporpb);
            this.Controls.Add(this.ssontarihlbl);
            this.Controls.Add(this.silktarihlbl);
            this.Controls.Add(this.ssontarihdtp);
            this.Controls.Add(this.silktarihdtp);
            this.Controls.Add(this.sfaturagw);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Caristok";
            this.Text = "Caristok";
            this.Load += new System.EventHandler(this.Caristok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.syazirpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sraporpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfaturagw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ssogcbx;
        private System.Windows.Forms.Label saralbl;
        private System.Windows.Forms.RichTextBox sarartb;
        private System.Windows.Forms.PictureBox syazirpb;
        private System.Windows.Forms.PictureBox sraporpb;
        private System.Windows.Forms.Label ssontarihlbl;
        private System.Windows.Forms.Label silktarihlbl;
        private System.Windows.Forms.DateTimePicker ssontarihdtp;
        private System.Windows.Forms.DateTimePicker silktarihdtp;
        private System.Windows.Forms.DataGridView sfaturagw;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}