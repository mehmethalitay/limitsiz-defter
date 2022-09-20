namespace Limitsiz_Defter
{
    partial class Fatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fatura));
            this.fyazirpb = new System.Windows.Forms.PictureBox();
            this.fsilpb = new System.Windows.Forms.PictureBox();
            this.fraporpb = new System.Windows.Forms.PictureBox();
            this.fsontarihlbl = new System.Windows.Forms.Label();
            this.filktarihlbl = new System.Windows.Forms.Label();
            this.ksontarihdtp = new System.Windows.Forms.DateTimePicker();
            this.kilktarihdtp = new System.Windows.Forms.DateTimePicker();
            this.ffaturagw = new System.Windows.Forms.DataGridView();
            this.farartb = new System.Windows.Forms.RichTextBox();
            this.faralbl = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.fyazirpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsilpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fraporpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ffaturagw)).BeginInit();
            this.SuspendLayout();
            // 
            // fyazirpb
            // 
            this.fyazirpb.BackColor = System.Drawing.Color.Transparent;
            this.fyazirpb.BackgroundImage = global::Limitsiz_Defter.Properties.Resources.yazdir1;
            this.fyazirpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fyazirpb.Location = new System.Drawing.Point(324, 74);
            this.fyazirpb.Name = "fyazirpb";
            this.fyazirpb.Size = new System.Drawing.Size(100, 50);
            this.fyazirpb.TabIndex = 26;
            this.fyazirpb.TabStop = false;
            this.fyazirpb.Click += new System.EventHandler(this.Fyazirpb_Click);
            // 
            // fsilpb
            // 
            this.fsilpb.BackColor = System.Drawing.Color.Transparent;
            this.fsilpb.BackgroundImage = global::Limitsiz_Defter.Properties.Resources.sil1;
            this.fsilpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fsilpb.Location = new System.Drawing.Point(430, 74);
            this.fsilpb.Name = "fsilpb";
            this.fsilpb.Size = new System.Drawing.Size(100, 50);
            this.fsilpb.TabIndex = 25;
            this.fsilpb.TabStop = false;
            this.fsilpb.Click += new System.EventHandler(this.Fsilpb_Click);
            // 
            // fraporpb
            // 
            this.fraporpb.BackColor = System.Drawing.Color.Transparent;
            this.fraporpb.BackgroundImage = global::Limitsiz_Defter.Properties.Resources.rapor1;
            this.fraporpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fraporpb.Location = new System.Drawing.Point(218, 74);
            this.fraporpb.Name = "fraporpb";
            this.fraporpb.Size = new System.Drawing.Size(100, 50);
            this.fraporpb.TabIndex = 24;
            this.fraporpb.TabStop = false;
            this.fraporpb.Click += new System.EventHandler(this.Fraporpb_Click);
            // 
            // fsontarihlbl
            // 
            this.fsontarihlbl.AutoSize = true;
            this.fsontarihlbl.BackColor = System.Drawing.Color.Transparent;
            this.fsontarihlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fsontarihlbl.ForeColor = System.Drawing.Color.White;
            this.fsontarihlbl.Location = new System.Drawing.Point(214, 12);
            this.fsontarihlbl.Name = "fsontarihlbl";
            this.fsontarihlbl.Size = new System.Drawing.Size(86, 20);
            this.fsontarihlbl.TabIndex = 23;
            this.fsontarihlbl.Text = "Son Tarih";
            // 
            // filktarihlbl
            // 
            this.filktarihlbl.AutoSize = true;
            this.filktarihlbl.BackColor = System.Drawing.Color.Transparent;
            this.filktarihlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filktarihlbl.ForeColor = System.Drawing.Color.White;
            this.filktarihlbl.Location = new System.Drawing.Point(8, 12);
            this.filktarihlbl.Name = "filktarihlbl";
            this.filktarihlbl.Size = new System.Drawing.Size(73, 20);
            this.filktarihlbl.TabIndex = 22;
            this.filktarihlbl.Text = "İlk Tarih";
            // 
            // ksontarihdtp
            // 
            this.ksontarihdtp.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ksontarihdtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ksontarihdtp.Location = new System.Drawing.Point(218, 35);
            this.ksontarihdtp.Name = "ksontarihdtp";
            this.ksontarihdtp.Size = new System.Drawing.Size(200, 32);
            this.ksontarihdtp.TabIndex = 21;
            // 
            // kilktarihdtp
            // 
            this.kilktarihdtp.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kilktarihdtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.kilktarihdtp.Location = new System.Drawing.Point(12, 35);
            this.kilktarihdtp.Name = "kilktarihdtp";
            this.kilktarihdtp.Size = new System.Drawing.Size(200, 32);
            this.kilktarihdtp.TabIndex = 20;
            // 
            // ffaturagw
            // 
            this.ffaturagw.AllowUserToAddRows = false;
            this.ffaturagw.AllowUserToDeleteRows = false;
            this.ffaturagw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ffaturagw.Location = new System.Drawing.Point(12, 130);
            this.ffaturagw.Name = "ffaturagw";
            this.ffaturagw.ReadOnly = true;
            this.ffaturagw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ffaturagw.Size = new System.Drawing.Size(760, 400);
            this.ffaturagw.TabIndex = 19;
            this.ffaturagw.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Ffaturagw_RowEnter);
            // 
            // farartb
            // 
            this.farartb.Location = new System.Drawing.Point(424, 35);
            this.farartb.Name = "farartb";
            this.farartb.ShortcutsEnabled = false;
            this.farartb.Size = new System.Drawing.Size(312, 32);
            this.farartb.TabIndex = 27;
            this.farartb.Text = "";
            // 
            // faralbl
            // 
            this.faralbl.AutoSize = true;
            this.faralbl.BackColor = System.Drawing.Color.Transparent;
            this.faralbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.faralbl.ForeColor = System.Drawing.Color.White;
            this.faralbl.Location = new System.Drawing.Point(420, 9);
            this.faralbl.Name = "faralbl";
            this.faralbl.Size = new System.Drawing.Size(37, 20);
            this.faralbl.TabIndex = 28;
            this.faralbl.Text = "Ara";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.PrintDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
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
            // Fatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Limitsiz_Defter.Properties.Resources._1__3_9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.faralbl);
            this.Controls.Add(this.farartb);
            this.Controls.Add(this.fyazirpb);
            this.Controls.Add(this.fsilpb);
            this.Controls.Add(this.fraporpb);
            this.Controls.Add(this.fsontarihlbl);
            this.Controls.Add(this.filktarihlbl);
            this.Controls.Add(this.ksontarihdtp);
            this.Controls.Add(this.kilktarihdtp);
            this.Controls.Add(this.ffaturagw);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Fatura";
            this.Text = "Fatura";
            this.Load += new System.EventHandler(this.Fatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fyazirpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsilpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fraporpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ffaturagw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fyazirpb;
        private System.Windows.Forms.PictureBox fsilpb;
        private System.Windows.Forms.PictureBox fraporpb;
        private System.Windows.Forms.Label fsontarihlbl;
        private System.Windows.Forms.Label filktarihlbl;
        private System.Windows.Forms.DateTimePicker ksontarihdtp;
        private System.Windows.Forms.DateTimePicker kilktarihdtp;
        private System.Windows.Forms.DataGridView ffaturagw;
        private System.Windows.Forms.RichTextBox farartb;
        private System.Windows.Forms.Label faralbl;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}