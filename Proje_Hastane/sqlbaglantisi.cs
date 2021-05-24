using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    class sqlbaglantisi// sql bağlantısı sınıfımızın adı
    {
        public SqlConnection baglanti()//baglanti metodumuzun adı
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-LQUHLSH\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
            //baglan sql connection sınıfımızdan türettiğimiz ve adresimizi tutan nesnemizin adı
            baglan.Open();//open bir metot
            return baglan;//return de geriye dönen değeri tutan kısmımız
        }
    }
}
