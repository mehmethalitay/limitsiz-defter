using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Limitsiz_Defter
{
    public partial class Urunler : Form
    {
        bool satisyapt;
        public Urunler(bool satisyap)
        {
            satisyapt = satisyap;
            InitializeComponent();
            uduzenlepb.Enabled = false;
            uadetlbl.Visible = true;
            uadetrtb.Visible = true;
            ueklepb.Visible = true;
            ukdvrtb.Visible = true;
            ukdvlbl.Visible = true;
            uiskontortb.Visible = true;
            uiskontolbl.Visible = true;
            uyuzdelbl.Visible = true;
            uyuzdelbl2.Visible = true;
            uarartb.Left = 14;
            uarartb.Width= 584;
            uaralbl.Text = "Barkod";
            uaralbl.Left = 292;
            uduzenlepb.Visible = false;
            usilpb.Visible = false;
            ukaydetpb.Visible = false;
            uarartb.Focus();
        }

        public string kkod, kbirim, kmaliyet, kurunadi, kstok, ksatis, kadet = "1", kisk, kkdv ;
        public string kod { get { return kkod; } set { kkod = value; } }
        public string birim { get { return kbirim; } set { kbirim = value; } }
        public string maliyet { get { return kmaliyet; } set { kmaliyet = value; } }
        public string urunadi { get { return kurunadi; } set { kurunadi = value; } }
        public string stok { get { return kstok; } set { kstok = value; } }
        public string satis { get { return ksatis; } set { ksatis = value; } }
        public string adet { get { return kadet; } set { kadet = value; } }
        public string isk { get { return kisk; } set { kisk = value; } }
        public string kdv { get { return kkdv; } set { kkdv = value; } }
        public Urunler()
        {
            InitializeComponent();
        }
        SQLiteDataAdapter da;
        SQLiteCommand cmd;
        DataSet ds;
        SQLiteConnection baglan = new SQLiteConnection(@"Data Source=limitsizdefter;Version=3;");
        void GetList()
        {
            try
            {
                da = new SQLiteDataAdapter("Select *From Urunler", baglan);
                ds = new DataSet();
                if (baglan.State != ConnectionState.Open) baglan.Open();
                da.Fill(ds, "urunler");
                musterilerdtgw.DataSource = ds.Tables["urunler"];
                baglan.Close();
            }
            catch (Exception sa)
            {
                MessageBox.Show("Program Sağlayıcınızla Görüşün"+sa.ToString());
            }
           
        }
        private void Urunler_Load(object sender, EventArgs e)
        {
            birimgetir(); GetList();
        }
        string idgetir;
        private void Musterilerdtgw_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            idgetir= ds.Tables["urunler"].Rows[e.RowIndex]["id"].ToString();
            ukodrtb.Text = ds.Tables["urunler"].Rows[e.RowIndex]["kod"].ToString();
            ubirimcb.Text = ds.Tables["urunler"].Rows[e.RowIndex]["birim"].ToString();
            umaliyetrtb.Text = ds.Tables["urunler"].Rows[e.RowIndex]["maliyet"].ToString();
            uadirtb.Text = ds.Tables["urunler"].Rows[e.RowIndex]["urunadi"].ToString();
            ustokrtb.Text = ds.Tables["urunler"].Rows[e.RowIndex]["stok"].ToString();
            usatisrtb.Text = ds.Tables["urunler"].Rows[e.RowIndex]["satis"].ToString();
        }
        void birimgetir()
        {
            try
            {
                
                if (baglan.State != ConnectionState.Open) baglan.Open();
                SQLiteCommand cmd = new SQLiteCommand("Select * From birim", baglan);
                SQLiteDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) //while’i tüm öğeleri seçmek için kullandık.
                {
                    ubirimcb.Items.Add(dr["birimadi"]);//verileri listboxa ekliyoruz .
                }
            }
            catch (Exception sa)
            {
                MessageBox.Show("Program Sağlayıcınızla Görüşün" + sa.ToString());
            }

        }
        private void Uduzenlepb_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is RichTextBox)
                {
                    RichTextBox tbox = (RichTextBox)item;
                    tbox.Enabled=true;
                }
            }//Etkinleştirme görevlisi Görevlisi

            ubirimcb.Enabled = true;
            uduzenlepb.Visible = false;
            ukaydetpb.Visible = true;
            uiptalpb.Visible = true;


        }

        private void miptalpb_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is RichTextBox)
                {
                    RichTextBox tbox = (RichTextBox)item;
                    tbox.Enabled = false;
                }
            }//Etkinleştirme görevlisi Görevlisi

            ubirimcb.Enabled = false;
            uduzenlepb.Visible = true;
            ukaydetpb.Visible = false;
            uiptalpb.Visible = false;
        }

        private void ustokrtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void umaliyetrtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void usatisrtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void ukdvrtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void uiskontortb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void uadetrtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void ueklepb_Click(object sender, EventArgs e)
        {
            if (uadetrtb.Text.Length==0)
            {
                uadetrtb.Text = "1";
            }
            if (ukdvrtb.Text.Length == 0)
            {
                ukdvrtb.Text = "18";
            }
            if (uiskontortb.Text.Length == 0)
            {
                uiskontortb.Text = "0";
            }
            if (satisyapt == true )
            {
                kod = ukodrtb.Text;
                birim = ubirimcb.Text;
                maliyet = umaliyetrtb.Text;
                urunadi = uadirtb.Text;
                stok = ustokrtb.Text;
                satis = usatisrtb.Text;
                adet = uadetrtb.Text;
                kdv = ukdvrtb.Text;
                isk = uiskontortb.Text;
                DialogResult = DialogResult.OK;
                this.Visible = false;
            }

        }

        private void uadetrtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void Ukaydetpb_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SQLiteCommand();
                if (baglan.State != ConnectionState.Open) baglan.Open();
                cmd.Connection  = baglan;
                cmd.CommandText = "update urunler set kod=@kod,birim=@birim,maliyet=@maliyet,urunadi=@urunadi,stok=@stok,satis=@satis where id=" + idgetir + " ";
                cmd.Parameters.AddWithValue("kod", ukodrtb.Text);
                cmd.Parameters.AddWithValue("birim", ubirimcb.Text);
                cmd.Parameters.AddWithValue("maliyet", umaliyetrtb.Text);
                cmd.Parameters.AddWithValue("urunadi", uadirtb.Text);
                cmd.Parameters.AddWithValue("stok", ustokrtb.Text);
                cmd.Parameters.AddWithValue("satis", usatisrtb.Text);
                cmd.ExecuteNonQuery();
                baglan.Close();
                GetList();
            }
            catch (Exception sa)
            {
                MessageBox.Show("Lütfen Program Sağlayıcınızla Görüşün \n" +sa.ToString());
            }
            foreach (Control item in this.Controls)
            {
                if (item is RichTextBox )
                {
                    RichTextBox tbox = (RichTextBox)item;
                    tbox.Enabled = false;
                }
            }//Etkinleştirme görevlisi Görevlisi
            uduzenlepb.Visible = true;
            ukaydetpb.Visible = false;
            uiptalpb.Visible = false;
            ubirimcb.Enabled = false;


        }

        private void Usilpb_Click(object sender, EventArgs e)
        {

            try
            {
                MessageBox.Show("Test");
                if (baglan.State != ConnectionState.Open) baglan.Open();
                cmd = new SQLiteCommand("Delete From urunler where id='"+idgetir+"'",baglan);
                cmd.ExecuteNonQuery();
                baglan.Close();
                GetList();

            }
            catch (Exception sa)
            {
                MessageBox.Show("Lütfen Program Sağlayıcınızla Görüşün \n" + sa.ToString());
            }
        }

        private void Uarartb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                da = new SQLiteDataAdapter("Select *From Urunler where kod like '"+uarartb.Text+"%'", baglan);
                ds = new DataSet();
                if (baglan.State != ConnectionState.Open) baglan.Open();
                da.Fill(ds, "urunler");
                musterilerdtgw.DataSource = ds.Tables["urunler"];
                baglan.Close();
            }
            catch (Exception sa)
            {
                MessageBox.Show("Program Sağlayıcınızla Görüşün" + sa.ToString());
            }


        }
        aktar akt = new aktar();
       
       
        private void Musterilerdtgw_DoubleClick(object sender, EventArgs e)
        {

        }

     
    }
}
