namespace Limitsiz_Defter
{
    partial class Kasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kasa));
            this.kkasadtgw = new System.Windows.Forms.DataGridView();
            this.kilktarihdtp = new System.Windows.Forms.DateTimePicker();
            this.ksontarihdtp = new System.Windows.Forms.DateTimePicker();
            this.kilktarihlbl = new System.Windows.Forms.Label();
            this.ksontarihlbl = new System.Windows.Forms.Label();
            this.kraporpb = new System.Windows.Forms.PictureBox();
            this.ksilpb = new System.Windows.Forms.PictureBox();
            this.kyazdirpb = new System.Windows.Forms.PictureBox();
            this.kbakiyelbl = new System.Windows.Forms.Label();
            this.kalinanlbl = new System.Windows.Forms.Label();
            this.ktoplamlbl = new System.Windows.Forms.Label();
            this.kalan = new System.Windows.Forms.Label();
            this.toplam = new System.Windows.Forms.Label();
            this.alinan = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.kkasadtgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kraporpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksilpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyazdirpb)).BeginInit();
            this.SuspendLayout();
            // 
            // kkasadtgw
            // 
            this.kkasadtgw.AllowUserToAddRows = false;
            this.kkasadtgw.AllowUserToDeleteRows = false;
            this.kkasadtgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kkasadtgw.Location = new System.Drawing.Point(12, 70);
            this.kkasadtgw.Name = "kkasadtgw";
            this.kkasadtgw.ReadOnly = true;
            this.kkasadtgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kkasadtgw.Size = new System.Drawing.Size(760, 453);
            this.kkasadtgw.TabIndex = 0;
            this.kkasadtgw.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Kkasadtgw_RowEnter);
            // 
            // kilktarihdtp
            // 
            this.kilktarihdtp.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kilktarihdtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.kilktarihdtp.Location = new System.Drawing.Point(18, 31);
            this.kilktarihdtp.Name = "kilktarihdtp";
            this.kilktarihdtp.Size = new System.Drawing.Size(200, 32);
            this.kilktarihdtp.TabIndex = 1;
            // 
            // ksontarihdtp
            // 
            this.ksontarihdtp.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ksontarihdtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ksontarihdtp.Location = new System.Drawing.Point(224, 32);
            this.ksontarihdtp.Name = "ksontarihdtp";
            this.ksontarihdtp.Size = new System.Drawing.Size(200, 32);
            this.ksontarihdtp.TabIndex = 2;
            // 
            // kilktarihlbl
            // 
            this.kilktarihlbl.AutoSize = true;
            this.kilktarihlbl.BackColor = System.Drawing.Color.Transparent;
            this.kilktarihlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kilktarihlbl.ForeColor = System.Drawing.Color.White;
            this.kilktarihlbl.Location = new System.Drawing.Point(8, 8);
            this.kilktarihlbl.Name = "kilktarihlbl";
            this.kilktarihlbl.Size = new System.Drawing.Size(73, 20);
            this.kilktarihlbl.TabIndex = 14;
            this.kilktarihlbl.Text = "İlk Tarih";
            // 
            // ksontarihlbl
            // 
            this.ksontarihlbl.AutoSize = true;
            this.ksontarihlbl.BackColor = System.Drawing.Color.Transparent;
            this.ksontarihlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ksontarihlbl.ForeColor = System.Drawing.Color.White;
            this.ksontarihlbl.Location = new System.Drawing.Point(220, 9);
            this.ksontarihlbl.Name = "ksontarihlbl";
            this.ksontarihlbl.Size = new System.Drawing.Size(86, 20);
            this.ksontarihlbl.TabIndex = 15;
            this.ksontarihlbl.Text = "Son Tarih";
            // 
            // kraporpb
            // 
            this.kraporpb.BackColor = System.Drawing.Color.Transparent;
            this.kraporpb.BackgroundImage = global::Limitsiz_Defter.Properties.Resources.rapor1;
            this.kraporpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kraporpb.Location = new System.Drawing.Point(430, 14);
            this.kraporpb.Name = "kraporpb";
            this.kraporpb.Size = new System.Drawing.Size(100, 50);
            this.kraporpb.TabIndex = 16;
            this.kraporpb.TabStop = false;
            this.kraporpb.Click += new System.EventHandler(this.Kraporpb_Click);
            // 
            // ksilpb
            // 
            this.ksilpb.BackColor = System.Drawing.Color.Transparent;
            this.ksilpb.BackgroundImage = global::Limitsiz_Defter.Properties.Resources.sil1;
            this.ksilpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ksilpb.Location = new System.Drawing.Point(642, 14);
            this.ksilpb.Name = "ksilpb";
            this.ksilpb.Size = new System.Drawing.Size(100, 50);
            this.ksilpb.TabIndex = 17;
            this.ksilpb.TabStop = false;
            this.ksilpb.Click += new System.EventHandler(this.Ksilpb_Click);
            // 
            // kyazdirpb
            // 
            this.kyazdirpb.BackColor = System.Drawing.Color.Transparent;
            this.kyazdirpb.BackgroundImage = global::Limitsiz_Defter.Properties.Resources.yazdir1;
            this.kyazdirpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kyazdirpb.Location = new System.Drawing.Point(536, 14);
            this.kyazdirpb.Name = "kyazdirpb";
            this.kyazdirpb.Size = new System.Drawing.Size(100, 50);
            this.kyazdirpb.TabIndex = 18;
            this.kyazdirpb.TabStop = false;
            this.kyazdirpb.Click += new System.EventHandler(this.kyazdirpb_Click);
            // 
            // kbakiyelbl
            // 
            this.kbakiyelbl.AutoSize = true;
            this.kbakiyelbl.BackColor = System.Drawing.Color.Transparent;
            this.kbakiyelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kbakiyelbl.ForeColor = System.Drawing.Color.White;
            this.kbakiyelbl.Location = new System.Drawing.Point(288, 526);
            this.kbakiyelbl.Name = "kbakiyelbl";
            this.kbakiyelbl.Size = new System.Drawing.Size(60, 16);
            this.kbakiyelbl.TabIndex = 31;
            this.kbakiyelbl.Text = "Bakiye:";
            // 
            // kalinanlbl
            // 
            this.kalinanlbl.AutoSize = true;
            this.kalinanlbl.BackColor = System.Drawing.Color.Transparent;
            this.kalinanlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kalinanlbl.ForeColor = System.Drawing.Color.White;
            this.kalinanlbl.Location = new System.Drawing.Point(158, 526);
            this.kalinanlbl.Name = "kalinanlbl";
            this.kalinanlbl.Size = new System.Drawing.Size(55, 16);
            this.kalinanlbl.TabIndex = 30;
            this.kalinanlbl.Text = "Alınan:";
            // 
            // ktoplamlbl
            // 
            this.ktoplamlbl.AutoSize = true;
            this.ktoplamlbl.BackColor = System.Drawing.Color.Transparent;
            this.ktoplamlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ktoplamlbl.ForeColor = System.Drawing.Color.White;
            this.ktoplamlbl.Location = new System.Drawing.Point(15, 526);
            this.ktoplamlbl.Name = "ktoplamlbl";
            this.ktoplamlbl.Size = new System.Drawing.Size(65, 16);
            this.ktoplamlbl.TabIndex = 29;
            this.ktoplamlbl.Text = "Toplam:";
            // 
            // kalan
            // 
            this.kalan.AutoSize = true;
            this.kalan.BackColor = System.Drawing.Color.Transparent;
            this.kalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kalan.ForeColor = System.Drawing.Color.Chartreuse;
            this.kalan.Location = new System.Drawing.Point(344, 526);
            this.kalan.Name = "kalan";
            this.kalan.Size = new System.Drawing.Size(16, 16);
            this.kalan.TabIndex = 28;
            this.kalan.Text = "0";
            // 
            // toplam
            // 
            this.toplam.AutoSize = true;
            this.toplam.BackColor = System.Drawing.Color.Transparent;
            this.toplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplam.ForeColor = System.Drawing.Color.Chartreuse;
            this.toplam.Location = new System.Drawing.Point(76, 526);
            this.toplam.Name = "toplam";
            this.toplam.Size = new System.Drawing.Size(16, 16);
            this.toplam.TabIndex = 27;
            this.toplam.Text = "0";
            // 
            // alinan
            // 
            this.alinan.AutoSize = true;
            this.alinan.BackColor = System.Drawing.Color.Transparent;
            this.alinan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alinan.ForeColor = System.Drawing.Color.Chartreuse;
            this.alinan.Location = new System.Drawing.Point(209, 526);
            this.alinan.Name = "alinan";
            this.alinan.Size = new System.Drawing.Size(16, 16);
            this.alinan.TabIndex = 26;
            this.alinan.Text = "0";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Kasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Limitsiz_Defter.Properties.Resources._1__3_7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.kbakiyelbl);
            this.Controls.Add(this.kalinanlbl);
            this.Controls.Add(this.ktoplamlbl);
            this.Controls.Add(this.kalan);
            this.Controls.Add(this.toplam);
            this.Controls.Add(this.alinan);
            this.Controls.Add(this.kyazdirpb);
            this.Controls.Add(this.ksilpb);
            this.Controls.Add(this.kraporpb);
            this.Controls.Add(this.ksontarihlbl);
            this.Controls.Add(this.kilktarihlbl);
            this.Controls.Add(this.ksontarihdtp);
            this.Controls.Add(this.kilktarihdtp);
            this.Controls.Add(this.kkasadtgw);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Kasa";
            this.Text = "Kasa";
            this.Load += new System.EventHandler(this.Kasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kkasadtgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kraporpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksilpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyazdirpb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView kkasadtgw;
        private System.Windows.Forms.DateTimePicker kilktarihdtp;
        private System.Windows.Forms.DateTimePicker ksontarihdtp;
        private System.Windows.Forms.Label kilktarihlbl;
        private System.Windows.Forms.Label ksontarihlbl;
        private System.Windows.Forms.PictureBox kraporpb;
        private System.Windows.Forms.PictureBox ksilpb;
        private System.Windows.Forms.PictureBox kyazdirpb;
        private System.Windows.Forms.Label kbakiyelbl;
        private System.Windows.Forms.Label kalinanlbl;
        private System.Windows.Forms.Label ktoplamlbl;
        private System.Windows.Forms.Label kalan;
        private System.Windows.Forms.Label toplam;
        private System.Windows.Forms.Label alinan;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}