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
    public partial class Kasa : Form
    {
        public Kasa()
        {
            InitializeComponent();
        }
        SQLiteCommand cmd;
        SQLiteDataAdapter da;
        DataSet ds;
        SQLiteConnection baglan = new SQLiteConnection(@"Data Source=limitsizdefter;Version=3;");
        StringFormat strFormat;
        ArrayList arrColumnLefts = new ArrayList();
        ArrayList arrColumnWidths = new ArrayList();
        int iCellHeight = 0;
        int iTotalWidth = 0;
        int iRow = 0;
        bool bFirstPage = false;
        bool bNewPage = false;
        int iHeaderHeight = 0;
        aktar akt = new aktar();
        void GetList()
        {
        
                da = new SQLiteDataAdapter("SELECT * FROM kasa ORDER BY id DESC LIMIT 100 ", baglan);
                ds = new DataSet();
                if (baglan.State != ConnectionState.Open) baglan.Open();
                da.Fill(ds, "kasa");
                kkasadtgw.DataSource = ds.Tables["kasa"];
                baglan.Close();
            
           

        }
        private void Kasa_Load(object sender, EventArgs e)
        {
            GetList();
            toplayıcı();
        }
        

        private void Kraporpb_Click(object sender, EventArgs e)
        {
            DateTime dt = Convert.ToDateTime(kilktarihdtp.Value);
            DateTime dt2 = Convert.ToDateTime(ksontarihdtp.Value);
            try
            {
                da = new SQLiteDataAdapter("select * from kasa where tarih between @tarih1 and @tarih2 ", baglan);
                da.SelectCommand.Parameters.AddWithValue("@tarih1", dt);
                da.SelectCommand.Parameters.AddWithValue("@tarih2",dt2);
                ds = new DataSet();
                if (baglan.State != ConnectionState.Open) baglan.Open();
                da.Fill(ds, "kasa");
                kkasadtgw.DataSource = ds.Tables["kasa"];
                baglan.Close();
                toplayıcı();
            }
            catch (Exception sa)
            {
                MessageBox.Show("Program Sağlayıcınızla Görüşün" + sa.ToString());
            }
            

        }

        private void Ksilpb_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State != ConnectionState.Open) baglan.Open();
                cmd = new SQLiteCommand("Delete From kasa where id='" + idgetir + "'", baglan);
                cmd.ExecuteNonQuery();
                baglan.Close();
                GetList();
                toplayıcı();

            }
            catch (Exception sa)
            {
                MessageBox.Show("Lütfen Program Sağlayıcınızla Görüşün \n" + sa.ToString());
            }
        }
        public void toplayıcı()
        {
            double topla = 0;
            for (int i = 0; i < kkasadtgw.Rows.Count; ++i)
            {
                topla += Convert.ToDouble(kkasadtgw.Rows[i].Cells[5].Value);
            }
            toplam.Text = topla.ToString()+" ₺" ;
        }
        string idgetir;
        private void Kkasadtgw_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            idgetir= ds.Tables["kasa"].Rows[e.RowIndex]["id"].ToString();
            
        }

        private void kyazdirpb_Click(object sender, EventArgs e)
        {
            toplayıcı();
            PrintPreviewDialog onizleme = new PrintPreviewDialog();
            onizleme.Document = printDocument1;
            onizleme.ShowDialog();
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
                foreach (DataGridViewColumn dgvGridCol in kkasadtgw.Columns)
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
                    foreach (DataGridViewColumn GridCol in kkasadtgw.Columns)
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

                while (iRow <= kkasadtgw.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = kkasadtgw.Rows[iRow];

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

                            e.Graphics.DrawString("Çıktı Başlığı", new Font(kkasadtgw.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Çıktı Başlığı", new Font(kkasadtgw.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                            e.Graphics.DrawString(strDate, new Font(kkasadtgw.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(kkasadtgw.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Limtisiz Defter", new Font(new Font(kkasadtgw.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);


                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in kkasadtgw.Columns)
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
    }
}
