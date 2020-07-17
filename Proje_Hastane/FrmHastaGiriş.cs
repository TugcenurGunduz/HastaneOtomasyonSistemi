using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;//kütüphanemizi ekledik

namespace Proje_Hastane
{
    public partial class FrmHastaGiriş : Form
    {
        public FrmHastaGiriş()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();// sql bağlantımızı çağırdık

        private void lnkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit fr = new FrmHastaKayit();
            fr.Show();

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar Where HastaTC=@p1 and HastaSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                FrmDetay fr = new FrmDetay();
                fr.tc = MskTC.Text;//tc değerini detay sayfasına taşıyabilmek için. tc değişkeni normalde hasta detay formunda ama fr nesnesi aracılığıyla public olduğu için erişebiliyorum.
                //yani bu formdaki tc kimlik numarasını hasta detay formundaki tc kimlik numarasına atadık ve hasta detay formunda da form yüklendiği zaman lbltc bunu yazdırsın dedik.
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC & Şifre");
            }
            bgl.baglanti().Close();
        }
    }
}
