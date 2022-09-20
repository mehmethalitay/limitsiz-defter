using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Limitsiz_Defter
{
    public partial class msgbx : Form
    {
        public msgbx()
        {
            InitializeComponent();
        }

        private void msgbx_Load(object sender, EventArgs e)
        {
            
        }
        public enum Durum
        {
            hata, basari, soru
        }
        public enum Butonlar
        {
            evethayir, tamam
        }
        public msgbx(Durum tip, string mesaj)
        {
            InitializeComponent();
            if (tip == Durum.hata)
            {
                timer1.Start();
                this.BackColor = Color.Red;
                label1.Text = mesaj;
                
            }
            else
            {
                label1.Text = mesaj;
            }
        }
        public msgbx(Durum tip, int sure, string mesaj)
        {
            InitializeComponent();
            if (tip == Durum.basari)
            {
                timer1.Start();
                this.BackColor = Color.ForestGreen;
                label1.Text = mesaj;

            }
            else
            {
                label1.Text = mesaj;
            }
        }

        public msgbx(Durum tip, string mesaj, Butonlar butonlar)
        {
            InitializeComponent();
            label1.Left = 5;
            label1.Top = 5;
            if (tip == Durum.hata) {
                this.BackColor = Color.Aqua;
            }
                
            

            else if (tip == Durum.soru) this.BackColor = Color.Gray;
            else { label1.Text = mesaj; }


            if (butonlar == Butonlar.tamam)
            {
                Button btn = new Button()
                {
                    Height = 50,
                    Width = 100,
                    Text = "Tamam",
                    Name = "Tamam",
                    Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold),
                    BackColor = Color.Aqua,
                    Location = new Point((this.Width / 2) - 50, 50)
                };
                this.Controls.Add(btn);
                btn.Click += Btn_Click;
            }
            else if (butonlar == Butonlar.evethayir)
            {
                Button btn2 = new Button()
                {
                    Height = 50,
                    Width = 100,
                    Text = "Evet",
                    Name = "evet",
                    Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold),
                    BackColor = Color.LightPink,
                    Location = new Point((this.Width / 3) - 50, 50)
                };
                this.Controls.Add(btn2);
                btn2.Click += Btn2_Click;

                Button btn3 = new Button()
                {
                    Height = 50,
                    Width = 100,
                    Text = "Hayır",
                    Name = "hayir",
                    Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold),
                    BackColor = Color.LightGreen,
                    Location = new Point((this.Width / 3) + 50, 50)
                };
                this.Controls.Add(btn3);
                btn3.Click += Btn3_Click;

            }

            label1.Text = mesaj;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Mesajkutusu_Load(object sender, EventArgs e)
        {
            this.Top = Screen.PrimaryScreen.Bounds.Height - this.Height - 80;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 30;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (this.Opacity > 0) this.Opacity -= 0.03;
            else this.Close();
        }
    }
}

