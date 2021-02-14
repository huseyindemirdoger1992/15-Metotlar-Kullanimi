using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_Metotlar_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //1. Yapı
        public void SadeceYap() // Metot oluşturulur
        {
            //public kısmı erişilebilirlik belirleme alanıdır
            //void alanı geriye değer döndürmeyen alandır
            //SadeceYap metotun adı benlirlenmiş olur.

            // Metot çağırıldıpında yapılacak işlemler bu alana yazılır

            //NOT: return kullanılabilir ama boş değer döndürmek şartı ile.
            return;
        }


        //2. Yapı
        public void KadeceKaydet(string Ad, string Soyad)// Metot oluşturulur
        {
            //public kısmı erişilebilirlik belirleme alanıdır
            //void alanı geriye değer döndürmeyen alandır
            //KadeceKaydet metotun adı benlirlenmiş olur.
            //string Ad Parametre alan metod yapısıdır
            //string Soyad Parametre alan metod yapısıdır
            string AdSoyad = Ad + " " + Soyad;

            // Metot çağırıldıpında yapılacak işlemler bu alana yazılır
        }

        //3. Yapı
        public string KaydetVeDegerVer(string Ad, string Soyad)// Metot oluşturulur
        {
            //public kısmı erişilebilirlik belirleme alanıdır
            //string alanı geriye değer string değer döndüren alandır
            //KadeceKaydet metotun adı benlirlenmiş olur.
            //string Ad Parametre alan metod yapısıdır
            //string Soyad Parametre alan metod yapısıdır

            //return işlemlerin sonucunda metod türünde değer döndürür
            return Ad + " " + Soyad;

            // Metot çağırıldıpında yapılacak işlemler bu alana yazılır
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //Parametre alan almayan değer döndüren döndürmeyen metot kullanımı
            SadeceYap();
            KadeceKaydet("Hüseyin","DEMİRDÖĞER");
            KaydetVeDegerVer("Hüseyin", "DEMİRDÖĞER");
        }
    }
}
