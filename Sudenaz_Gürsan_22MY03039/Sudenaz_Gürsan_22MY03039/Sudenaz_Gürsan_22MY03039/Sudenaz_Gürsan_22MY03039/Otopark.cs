using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudenaz_Gürsan_22MY03039
{
    internal class Otopark
    {
        private List<arac> otopark = new List<arac>();
        private int kapasite;
        private string plaka;

        public Otopark(int kapasite)
        {
            this.kapasite = kapasite;
        }
        public void aracEkle(string plaka, string marka, string model, string renk)
        {
            bool plakaKontrol = false;
            foreach (var arac in otopark)
            {
                if (arac.Plaka== plaka)
                {
                    plakaKontrol = true;
                    break;
                }
            }

            if (!plakaKontrol && otopark.Count() < kapasite) // Otoparktaki araç sayısını kontrol eder.
            {
                arac yeniArac = new arac() // Yeni araç nesnesi oluşturulur.
                {
                    Plaka = plaka,
                    Marka = marka,
                    Model = model,
                    Renk = renk,
                    GirisZamani = DateTime.Now
                };

                otopark.Add(yeniArac); //Yeni oluşturulan araç, otopark listesinin içine eklenir.

                Console.WriteLine("Araç Başarıyla Eklendi. Giriş Saati: " + yeniArac.GirisZamani); // Kullanıcıya başarıyla eklendiğini ve giriş zamanını belirtir.
            }

            else if (plakaKontrol)
            {
                Console.WriteLine("Bu plakaya ait araç zaten otoparkta bulunuyor.");
            }

            else
            {
                Console.WriteLine("Otopark Dolu, Yeni Araç Eklenemiyor."); //Otoparkta yer yoksa kullanıcıya vereceği hata.
            }
        }

        public void aracCikar(string plaka)
        {

            arac bulunanArac = null;

            foreach (var arac in otopark) //Otopark içerisindeki araçları gezer.
            {
                if (arac.Plaka == plaka) //Girilen plaka gezilen araçla eşleştiğinde.
                {
                    bulunanArac = arac; // Eşleşen aracı boş olan bulunanArac değişkenine atar.
                    break;              // Break ile döngüyü sonlandırır.
                }

            }
            if (bulunanArac != null)   // bulunanArac null olmadığında araç başarıyla çıkartılır.
            {
                otopark.Remove(bulunanArac);
                Console.WriteLine("Aracınız Başarıyla Çıkartılmıştır.");
            }
            else
            {
                Console.WriteLine("Bu Plakaya Ait Bir Araç Bulunamadı."); // null olduğunda vereceği hata.
            }
        }
        public void araclariListele()
        {
            foreach (var arac in otopark) //Otopark içerisindeki araçları gezer.
            {
                Console.WriteLine($"Plaka: {arac.Plaka}, Marka: {arac.Marka}, Model:{arac.Model},Renk:{arac.Renk},Giriş Zamanı: {arac.GirisZamani}"); // Her aracın bilgilerini ekrana yazdırır.
            }
        }

        public void BosYerKontrolu()
        {
            if (otopark.Count < kapasite) // Otoparktaki boş yer sayısını kontrol eder.
            {
                Console.WriteLine("Otoparktaki Boş Yer Sayısı = " + (kapasite - otopark.Count));  // Otoparkta boş yer varsa, boş yer sayısını ekrana yazdırır.
            }
            else if (otopark.Count >= kapasite)
            {
                Console.WriteLine("Otoparkta Boş Yer Yok!");// Otopark doluysa kullanıcıya vereceği hata.
            }

        }

        public void aracAra(string Plaka)
        {
            arac arananArac = null;
            foreach (var arac in otopark) //Otopark içerisindeki araçları gezer.
            {
                if (arac.Plaka == Plaka)// Eğer aranan plaka bulunursa, arananArac değişkenine atar  ve döngüden çıkartır.
                {
                    arananArac = arac;
                    break;
                }
            }
            if (arananArac != null)  // arananArac değişkeni null değilse, yani aranan plaka bulunmuşsa.
            {
                Console.WriteLine($"Araç bilgileri:Plaka: {arananArac.Plaka}, Marka: {arananArac.Marka},Model: {arananArac.Model},Renk: {arananArac.Renk},Giriş Zamanı: {arananArac.GirisZamani}"); //Araç bilgilerini ekrana yazdırır.
            }
            else
            {
                Console.WriteLine("Bu Plakaya Ait Araç Bulunamadı.");//null olduğunda vereceği hata
            }
        }

        public void toplamAracSayisi()
        {

            Console.WriteLine("Otoparktaki Toplam Araç Sayısı: " + otopark.Count);
        }

        public void belirliRenktekiAraclariListele(string Renk)
        {
            int sayac = 0;
            bool renkListe = false;
            foreach (var arac in otopark)//Otopark içerisindeki araçları gezer.
            {
                if (arac.Renk == Renk)// Eğer aracın rengi belirtilen renge eşitse.
                {
                    renkListe = true;//'renkListe' true olarak değişir, çünkü belirli bir renkte araç bulunmuştur.
                    sayac++; // Araç sayısını arttırır.
                    Console.WriteLine($"Araç Bilgileri: Plaka: {arac.Plaka}, Marka: {arac.Marka},Model: {arac.Model},Renk: {arac.Renk}"); // Araç bilgilerini ekrana yazdırır.
                }

            }
            if (!renkListe)//Belirli renkte araç bulunmamışsa
            {
                Console.WriteLine("Bu Renge Ait Bir Araç Bulunamadı."); // Belirtilen renkte araç bulunamazsa kullanıcıya vereceği hata.
            }
            Console.WriteLine($"Toplam {sayac} Adet Araç Bulundu.");
        }

        public void belirliModeldekiAraclariListele(string Model)
        {
            int sayac = 0;
            bool modelListe = false;
            foreach (var arac in otopark) //Otopark içerisindeki araçları gezer.
            {
                if (arac.Model == Model) // Eğer aracın modeli belirtilen modele eşitse.
                {
                    modelListe = true;//'modelListe' true olarak değişir, çünkü belirli bir renkte araç bulunmuştur.
                    sayac++;
                    Console.WriteLine($"Araç Bilgileri: Plaka: {arac.Plaka}, Marka: {arac.Marka},Model: {arac.Model},Renk: {arac.Renk}");// Araç bilgilerini ekrana yazdırır.
                }

            }
            if (!modelListe)//Belirli modelde araç bulunmamışsa
            {
                Console.WriteLine("Bu Modele Ait Bir Araç Bulunamadı."); // Belirli modelde araç bulunamazsa kullanıcıya vereceği hata.
            }
            Console.WriteLine($"Toplam {sayac} Adet Araç Bulundu.");
        }

        public void aracGüncelleme(string plaka, string yenimarka, string yenimodel, string yenirenk)
        {

            arac güncellenecekArac = null;
            foreach (var arac in otopark) //Otopark içerisindeki araçları gezer.
            {
                if (arac.Plaka == plaka)// Eğer aracın plakası belirtilen plakaya eşitse.
                {
                    güncellenecekArac = arac;// Güncellenecek aracı belirle ve break ile döngüyü sonlandırır.
                    break;

                }

            }
            if (güncellenecekArac != null)// Eğer güncellenecek arac bulunmuşsa.
            {
                // Aracın marka, model ve renk bilgilerini güncellenir.
                güncellenecekArac.Marka = yenimarka;
                güncellenecekArac.Model = yenimodel;
                güncellenecekArac.Renk = yenirenk;
                Console.WriteLine($"Araç Bilgileri Güncellendi: Marka: {güncellenecekArac.Marka},Model: {güncellenecekArac.Model},Renk: {güncellenecekArac.Renk}"); // Güncellenen aracın bilgilerini ekrana yazdırır.

            }
            else
            {
                Console.WriteLine("Bu Plakaya Ait Bir Araç Bulunamadı.");// Güncellenecek arac bulunamazsa kullanıcıya vereceği hata.
            }
        }

        public void aracDetaylarıiGörüntüleme(string görüntülenenPLaka)
        {
            arac görüntülenenArac = null;
            foreach (var arac in otopark) //Otopark içerisindeki araçları gezer.
            {
                if (arac.Plaka == görüntülenenPLaka)// Eğer aracın plakası belirtilen plakaya eşitse.
                {
                    görüntülenenArac = arac;// Görüntülenecek aracı belirler.                   
                    break;
                }

            }
            if (görüntülenenArac != null)
            {
                Console.WriteLine($"Araç Bilgileri: Plaka: {görüntülenenArac.Plaka}, Marka: {görüntülenenArac.Marka},Model: {görüntülenenArac.Model},Renk: {görüntülenenArac.Renk},Giriş Saati: {görüntülenenArac.GirisZamani}");// Görüntülenecek aracın detaylarını ekrana yazdırır.
            }
            else
            {
                Console.WriteLine("Bu Plakaya Ait Araç Bulunamadı.");// Eğer görüntülenen arac bulunamazsa vereceği hata.
            }
        }

        public double Hsaatlik; // Saatlik ücreti tutan değişken
        public double Hgünlük;  // Günlük ücreti tutan değişken
        public double Hhaftalık;// Haftalık ücreti tutan değişken
        public double Haylık;   // Aylık ücreti tutan değişken


        public void GirisEkranıVeTarifeHesaplama()// Ücret hesaplama ekranı ve tarife bilgilerini kullanıcıdan almak için kullanılan metod
        {
            Console.WriteLine("ÜCRET HESAPLAMA EKRANI ");
            Console.Write("Lütfen saatlik ücreti giriniz: "); // Saatlik ücreti alır.
            Hsaatlik = double.Parse(Console.ReadLine());

            Console.Write("Lütfen günlük ücreti giriniz: "); // Günlük ücreti alır.
            Hgünlük = double.Parse(Console.ReadLine());

            Console.Write("Lütfen haftalık ücreti giriniz: "); // Haftalık ücreti alır.
            Hhaftalık = double.Parse(Console.ReadLine());

            Console.Write("Lütfen aylık ücreti giriniz: "); // Aylık ücreti alır.
            Haylık = double.Parse(Console.ReadLine());
        }

        public void CikisTarihiVeUcretHesaplama(string plaka, DateTime cikisTarihi)
        {
            var cikacakArac = otopark.FirstOrDefault(a => a.Plaka == plaka);// Otoparktaki aracı plakaya göre bulur.
            DateTime CikisTarihi = cikisTarihi;

            if (Hsaatlik != 0 || Hgünlük != 0 || Hhaftalık != 0 || Haylık != 0)  // Saatlik, günlük, haftalık ve aylık ücretlerin herhangi biri sıfırdan farklıysa devam etmesine izin verir.
            {
                if (cikacakArac != null)// Belirtilen plakaya sahip aracın otoparkta olup olmadığını kontrol eder.
                {
                    TimeSpan kalinanZaman = (cikisTarihi - cikacakArac.GirisZamani);// Otoparkta kalınan süreyi hesaplar.
                    double ucret = 0;

                    Console.WriteLine($"OTOPARKTA KALINAN ZAMAN = {kalinanZaman.Days} gün {kalinanZaman.Hours} saat.");// Kalınan süreyi ekrana yazdırır.

                    if (kalinanZaman.TotalHours <= 23)// Kalınan süreye göre ücreti hesaplar.
                    {
                        ucret = kalinanZaman.Hours * Hsaatlik;// Eğer otoparkta kalınan süre 23 saatten azsa, saatlik ücret üzerinden hesaplar.
                    }
                    else if (kalinanZaman.TotalHours >= 24 && kalinanZaman.TotalHours <= 167)
                    {
                        ucret = (kalinanZaman.Days * Hgünlük) + (kalinanZaman.Hours * Hsaatlik);// Eğer otoparkta kalınan süre 24 saatten fazla ve 7 günden azsa, günlük ve saatlik ücretleri kullanarak hesaplar.
                    }
                    else if (kalinanZaman.TotalHours >= 168 && kalinanZaman.TotalHours <= 719)
                    {
                        ucret = ((kalinanZaman.Days / 7) * Hhaftalık) + ((kalinanZaman.Days % 7) * Hgünlük) + (kalinanZaman.Hours * Hsaatlik);// Eğer otoparkta kalınan süre 7 günden fazla ve 30 günden azsa, haftalık, günlük ve saatlik ücretleri kullanarak hesaplar.
                    }
                    else if (kalinanZaman.TotalHours >= 720)
                    {
                        ucret = ((kalinanZaman.Days / 30) * Haylık) + (((kalinanZaman.Days % 30) / 7) * Hhaftalık) + ((kalinanZaman.Days % 30) % 7) * Hgünlük + (kalinanZaman.Hours * Hsaatlik);// Eğer otoparkta kalınan süre 30 günden fazlaysa, aylık, haftalık, günlük ve saatlik ücretleri kullanarak hesaplar.
                    }

                    Console.WriteLine("Ödemeniz Gereken Ücret = " + ucret + "TL");// Ödemenilmesi gereken ücreti ekrana yazdırır.
                }
                else
                {
                    Console.WriteLine("Belirtilen Plakaya Sahip Araç Bulunamadı.");// Belirtilen plakaya sahip araç otoparkta bulunamazsa vereceği hata.
                }


            }

            else
            {
                Console.WriteLine("İlk Önce Ücret Belirlemeniz Gerekiyor.");// Ücret belirlenmemişse vereceği hata.
            }

        }


        public void OtoparkiSifirla()
        {
            otopark.Clear();// Otoparktaki araçları temizler.
            Console.WriteLine("Otoparkı Silmek İstediğinize Emin Misiniz? (E/H):");// Kullanıcıdan onay ister.
            string onay = Console.ReadLine();
            if (onay.ToUpper() == "E")// Kullanıcının verdiği onayı büyük harfe çevirerek kontrol eder.
            {
                Console.WriteLine("Otopark Başarıyla Sıfırlandı.");// Eğer kullanıcı "E" (Evet) derse, otoparkı sıfırlar.
            }
            else
            {
                Console.WriteLine("Otopark Sıfırlama Başarısız.");//Kulanıcının "H"(Hayır) dediğinde vereceği hata.
            }
        }
    }
}
