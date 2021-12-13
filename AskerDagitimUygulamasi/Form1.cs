using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AskerDagitimUygulamasi
{
    public partial class frm_anaSayfa : Form
    {
        public frm_anaSayfa()
        {
            InitializeComponent();
        }

        ArrayList askerler = new ArrayList();
        ArrayList sehirler = new ArrayList();

        private void frm_anaSayfa_Load(object sender, EventArgs e)
        {
            //Temel Şehir ve Asker Eşleştirmeleri
            sehirler.Add("İstanbul");
            sehirler.Add("Ankara");
            sehirler.Add("Bursa");
            sehirler.Add("Erzincan");
            sehirler.Add("Kocaeli");
            sehirler.Add("Konya");

            askerler.Add("Ahmet");
            askerler.Add("Mehmet");
            askerler.Add("Osman");
            askerler.Add("Mustafa");
            askerler.Add("Kerem");
            askerler.Add("Ekrem");
            askerler.Add("Rıdvan");
            askerler.Add("Ali");
            askerler.Add("Kemal");
            askerler.Add("Osman");

            ListeleriGuncelle();
        }

        private void ListeleriGuncelle()
        {
            SehirlerGuncelle();
            AskerlerGuncelle();

            tbx_askerEkle.Text = "";
            tbx_sehirEkle.Text = "";
        }

        private void SehirlerGuncelle()
        {
            lbx_sehirler.Items.Clear();
            lbx_sehirler.Items.AddRange(sehirler.ToArray());
        }
        private void AskerlerGuncelle()
        {
            lbx_askerler.Items.Clear();
            lbx_askerler.Items.AddRange(askerler.ToArray());
        }

        private void btn_askerEkle_Click(object sender, EventArgs e)
        {
            if (tbx_askerEkle.Text != "")
            {
                string askerAdi = tbx_askerEkle.Text.ToString();
                tbx_askerEkle.Text = "";

                AskerEkle(askerAdi);
            }
        }

        private void AskerEkle(string asker)
        {
            askerler.Add(asker);
            AskerlerGuncelle();
        }

        private void btn_sehirEkle_Click(object sender, EventArgs e)
        {
            if (tbx_sehirEkle.Text != "")
            {
                string sehirAdi = tbx_sehirEkle.Text.ToString();
                tbx_sehirEkle.Text = "";

                SehirEkle(sehirAdi);
            }
        }

        private void SehirEkle(string sehir)
        {
            sehirler.Add(sehir);
            SehirlerGuncelle();
        }

        Random random = new Random();
        private void btn_dagitimYap_Click(object sender, EventArgs e)
        {
            int askerAdet = askerler.Count;
            int sehirAdet = sehirler.Count;

            if (sehirler.Count == 0 || askerler.Count == 0)
            {
                MessageBox.Show("Lütfen Tüm Verileri Tamamlayınız!");
                return;
            }

            if (askerAdet < sehirAdet)
            {
                foreach (var asker in askerler.ToArray())
                {
                    int askerRandomIndex = random.Next(0, askerler.Count);
                    int sehirRandomIndex = random.Next(0, sehirler.Count);

                    lbx_eslestirmeler.Items.Add(askerler[askerRandomIndex] + " --> " + sehirler[sehirRandomIndex]);
                    askerler.RemoveAt(askerRandomIndex);
                }
            }
            else
            {
                ArrayList sehirlerYedek = (ArrayList)sehirler.Clone();

                while (sehirlerYedek.Count < askerler.Count)
                {
                    sehirlerYedek.Add(sehirler[random.Next(0, sehirler.Count)]);
                }

                foreach (var asker in askerler.ToArray())
                {
                    int askerRandomIndex = random.Next(0, askerler.Count);
                    int sehirRandomIndex = random.Next(0, sehirlerYedek.Count);

                    lbx_eslestirmeler.Items.Add(askerler[askerRandomIndex] + " --> " + sehirlerYedek
                    [sehirRandomIndex]);
                    sehirlerYedek.RemoveAt(sehirRandomIndex);
                    askerler.RemoveAt(askerRandomIndex);
                }
            }

            ListeleriGuncelle();
        }
    }
}
