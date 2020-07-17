using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void BtnHastaGirisi_Click(object sender, EventArgs e)
        {
            FrmHastaGiriş fr = new FrmHastaGiriş();//hasta giriş formundan fr isminde nesne ürettim
            fr.Show();//bana fr nesnesinden ürettiğim formu getir
            this.Hide();//üstünde çalıştığım formu gizle
        }

        private void BtnDoktorGirisi_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris fr = new FrmDoktorGiris();
            fr.Show();
            this.Hide();
        }

        private void BtnSekreterGirisi_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris fr = new FrmSekreterGiris();
            fr.Show();
            this.Hide();
        }
    }
}
