using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Collections;

namespace Limitsiz_Defter
{
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }
        public string gidenmusteri,gidenmusteriid;
       
        SQLiteCommand cmd;
        SQLiteDataAdapter da;
        DataSet ds;
        SQLiteConnection baglan = new SQLiteConnection(@"Data Source=limitsizdefter;Version=3;");
        msgbx msgbx;
        StringFormat strFormat;
        ArrayList arrColumnLefts = new ArrayList();
        ArrayList arrColumnWidths = new ArrayList();
        int iCellHeight = 0;
        int iTotalWidth = 0;
        int iRow = 0;
        bool bFirstPage = false;
        bool bNewPage = false;
        int iHeaderHeight = 0;
        void GetList()
        {
            try
            {
                da = new SQLiteDataAdapter("Select *From musteriler", baglan);
                ds = new DataSet();
                if (baglan.State != ConnectionState.Open) baglan.Open();
                da.Fill(ds, "musteriler");
                musterilerdtgw.DataSource = ds.Tables["musteriler"];
                baglan.Close();
            }
            catch (Exception sa)
            {
                MessageBox.Show("Program Sağlayıcınızla Görüşün" + sa.ToString());
            }

        }
        private void Musteriler_Load(object sender, EventArgs e)
        {
            GetList();
            mkaydetpb.Visible = false;
            miptalpb.Visible = false;
            mduzenlepb.Visible = true;
            toplayıcı();
        }
        public void toplayıcı()
        {
            double topla = 0, alin =0, baki = 0;
            for (int i = 0; i < musterilerdtgw.Rows.Count; ++i)
            {
                topla += Convert.ToDouble(musterilerdtgw.Rows[i].Cells[6].Value);
                alin += Convert.ToDouble(musterilerdtgw.Rows[i].Cells[7].Value);
                baki += Convert.ToDouble(musterilerdtgw.Rows[i].Cells[8].Value);
            }
            toplam.Text = topla.ToString() + " ₺";
            alinan.Text = alin.ToString() + " ₺";
            kalan.Text = baki.ToString() + " ₺";
        }

        string idgetir;
        private void Musterilerdtgw_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            idgetir = ds.Tables["musteriler"].Rows[e.RowIndex]["id"].ToString();
            madsoyadrtb.Text = ds.Tables["musteriler"].Rows[e.RowIndex]["adsoyad"].ToString();
            mtelefonrtb.Text = ds.Tables["musteriler"].Rows[e.RowIndex]["telefon"].ToString();
            madresrtb.Text = ds.Tables["musteriler"].Rows[e.RowIndex]["adres"].ToString();
            mfirmartb.Text = ds.Tables["musteriler"].Rows[e.RowIndex]["firma"].ToString();
            mmailrtb.Text = ds.Tables["musteriler"].Rows[e.RowIndex]["mail"].ToString();
}
        private void Mduzenlepb_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is RichTextBox)
                {
                    RichTextBox tbox = (RichTextBox)item;
                    tbox.Enabled = true;
                }
            }//Etkinleştirme görevlisi Görevlisi
            mkaydetpb.Visible = true;
            miptalpb.Visible = true;
            mduzenlepb.Visible = false;
            

        }

        private void Mkaydetpb_Click(object sender, EventArgs e)
        {
            /*İŞLEMLER*/

            msgbx = new msgbx(msgbx.Durum.soru, "Değişiklikleri kaydetmek istiyor musunuz ?",msgbx.Butonlar.evethayir);
            DialogResult kaydet = msgbx.ShowDialog();
            if (kaydet == DialogResult.Yes)
            {
                try
                {
                    cmd = new SQLiteCommand();
                    if (baglan.State != ConnectionState.Open) baglan.Open();
                    cmd.Connection = baglan;
                    cmd.CommandText = "update musteriler set adsoyad=@adsoyad,telefon=@telefon,adres=@adres,firma=@firma,mail=@mail where id=" + idgetir + " ";
                    cmd.Parameters.AddWithValue("adsoyad", madsoyadrtb.Text);
                    cmd.Parameters.AddWithValue("telefon", mtelefonrtb.Text);
                    cmd.Parameters.AddWithValue("adres", madresrtb.Text);
                    cmd.Parameters.AddWithValue("firma", mfirmartb.Text);
                    cmd.Parameters.AddWithValue("mail", mmailrtb.Text);
                    cmd.ExecuteNonQuery();
                    baglan.Close();
                    GetList();
                    toplayıcı();
                }
                catch (Exception sa)
                {
                    MessageBox.Show("Lütfen Program Sağlayıcınızla Görüşün \n" + sa.ToString());
                }

                /*İŞLEMLER*/

                foreach (Control item in this.Controls)
                {
                    if (item is RichTextBox)
                    {
                        RichTextBox tbox = (RichTextBox)item;
                        tbox.Enabled = false;
                    }
                }//Etkinleştirme görevlisi Görevlisi
                mkaydetpb.Visible = false;
                miptalpb.Visible = false;
                mduzenlepb.Visible = true;

            }
            
        }

        private void Marartb_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                try
                {
                    da = new SQLiteDataAdapter("Select *From Musteriler where adsoyad like '" + marartb.Text + "%'AND bakiye >0", baglan);
                    ds = new DataSet();
                    if (baglan.State != ConnectionState.Open) baglan.Open();
                    da.Fill(ds, "musteriler");
                    musterilerdtgw.DataSource = ds.Tables["musteriler"];
                    baglan.Close();
                }
                catch (Exception sa)
                {
                    MessageBox.Show("Program Sağlayıcınızla Görüşün" + sa.ToString());
                }
            }
            else
            {
                try
                {
                    da = new SQLiteDataAdapter("Select *From Musteriler where adsoyad like '" + marartb.Text + "%'", baglan);
                    ds = new DataSet();
                    if (baglan.State != ConnectionState.Open) baglan.Open();
                    da.Fill(ds, "musteriler");
                    musterilerdtgw.DataSource = ds.Tables["musteriler"];
                    baglan.Close();
                }
                catch (Exception sa)
                {
                    MessageBox.Show("Program Sağlayıcınızla Görüşün" + sa.ToString());
                }
            }
           

        }

        private void Msilpb_Click(object sender, EventArgs e)
        {
            
            try
            {
                msgbx msgbox = new msgbx(msgbx.Durum.soru,"Silmek İstediğinizden Emin misiniz?",msgbx.Butonlar.evethayir);
                DialogResult d = msgbox.ShowDialog();
                if (d == DialogResult.Yes)
                {
                    if (baglan.State != ConnectionState.Open) baglan.Open();
                    cmd = new SQLiteCommand("Delete From musteriler where id='" + idgetir + "'", baglan);
                    cmd.ExecuteNonQuery();
                    baglan.Close();
                    GetList();
                    temizlikgorevlisi();
                    toplayıcı();
                }

            }
            catch (Exception sa)
            {
                MessageBox.Show("Lütfen Program Sağlayıcınızla Görüşün \n" + sa.ToString());
            }
        }

        private void Msatispb_Click(object sender, EventArgs e)
        {
            if (musterilerdtgw.SelectedRows.Count>0)
            {
                Satisyap stsyap = new Satisyap(idgetir, madsoyadrtb.Text, mtelefonrtb.Text, mfirmartb.Text, mmailrtb.Text);
                this.Visible = false;
                stsyap.ShowDialog();
                this.Visible = true; 
            }
            toplayıcı();
        }

        public void temizlikgorevlisi()
        {
            foreach (Control item in this.Controls)
            {
                if (item is RichTextBox)
                {
                    RichTextBox tbox = (RichTextBox)item;
                    tbox.Enabled = false;
                }
            }
        }

        private void miptalpb_Click(object sender, EventArgs e)
        {
            toplayıcı();
            temizlikgorevlisi();
            mkaydetpb.Visible = false;
            miptalpb.Visible = false;
            mduzenlepb.Visible = true;
        }

        private void mtelefonrtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void mraporpb_Click(object sender, EventArgs e)
        {
            toplayıcı();
            PrintPreviewDialog onizleme = new PrintPreviewDialog();
            onizleme.Document = printDocument1;
            onizleme.ShowDialog();
        }

        private void Musteriler_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                try
                {
                    da = new SQLiteDataAdapter("Select *From Musteriler where adsoyad like '" + marartb.Text + "%'AND bakiye >0", baglan);
                    ds = new DataSet();
                    if (baglan.State != ConnectionState.Open) baglan.Open();
                    da.Fill(ds, "musteriler");
                    musterilerdtgw.DataSource = ds.Tables["musteriler"];
                    baglan.Close();
                }
                catch (Exception sa)
                {
                    MessageBox.Show("Program Sağlayıcınızla Görüşün" + sa.ToString());
                }
            }
            else
            {
                try
                {
                    da = new SQLiteDataAdapter("Select *From Musteriler where adsoyad like '" + marartb.Text + "%'", baglan);
                    ds = new DataSet();
                    if (baglan.State != ConnectionState.Open) baglan.Open();
                    da.Fill(ds, "musteriler");
                    musterilerdtgw.DataSource = ds.Tables["musteriler"];
                    baglan.Close();
                }
                catch (Exception sa)
                {
                    MessageBox.Show("Program Sağlayıcınızla Görüşün" + sa.ToString());
                }
            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in musterilerdtgw.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                int iLeftMargin = e.MarginBounds.Left;
                int iTopMargin = e.MarginBounds.Top;
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;
                bFirstPage = true;

                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in musterilerdtgw.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;


                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }

                while (iRow <= musterilerdtgw.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = musterilerdtgw.Rows[iRow];

                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;

                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {

                            e.Graphics.DrawString("Çıktı Başlığı", new Font(musterilerdtgw.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Çıktı Başlığı", new Font(musterilerdtgw.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                            e.Graphics.DrawString(strDate, new Font(musterilerdtgw.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(musterilerdtgw.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Limtisiz Defter", new Font(new Font(musterilerdtgw.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);


                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in musterilerdtgw.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;

                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }

                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }


                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void Mtahsilatpb_Click(object sender, EventArgs e)
        {
            if (musterilerdtgw.SelectedRows.Count > 0)
            {
                Gelir glr = new Gelir(idgetir, madsoyadrtb.Text);
                this.Visible = false;
                glr.ShowDialog();
                this.Visible = true; 
            }
            toplayıcı();

        }
    }
}
