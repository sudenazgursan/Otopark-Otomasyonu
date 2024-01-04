using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudenaz_Gürsan_22MY03039
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Otopark otopark = new Otopark(10);
            do
            {
                Console.WriteLine("1. Araç Ekle");
                Console.WriteLine("2. Araç Çıkar");
                Console.WriteLine("3. Araçları Listele");
                Console.WriteLine("4. Boş Park Yeri Kontrolü");
                Console.WriteLine("5. Araç Arama");
                Console.WriteLine("6. Toplam Araç Sayısı");
                Console.WriteLine("7. Belirli Renkteki Araçları Listele");
                Console.WriteLine("8. Belirli Bir Modeldeki Araçları Listele");
                Console.WriteLine("9. Araç Bilgilerini Güncelle");
                Console.WriteLine("10. Araç Detaylarını Görüntüle");
                Console.WriteLine("11. Ücret Bilgileri");
                Console.WriteLine("12. Araç Çıkış Tarihi ve Ücret Hesaplama");
                Console.WriteLine("13. Otoparkı Sıfırla");
                string secim = Console.ReadLine();


                switch (secim)
                {
                    case "1":

                        Console.Clear();// Kullanıcıya temiz bir konsol ekranı gösterir.
                                        // Kullanıcıdan araç bilgilerini girmesini istenir.
                        Console.WriteLine("Araç Plakasını Giriniz: ");
                        string plaka = Console.ReadLine();
                        Console.WriteLine("Araç Markasını Giriniz: ");
                        string marka = Console.ReadLine();
                        Console.WriteLine("Araç Modelini Giriniz: ");
                        string model = Console.ReadLine();
                        Console.WriteLine("Araç Rengini Giriniz: ");
                        string renk = Console.ReadLine();
                        // Otopark sınıfındaki "aracEkle" metodunu çağırarak yeni araç eklenir.
                        otopark.aracEkle(plaka, marka, model, renk);
                        break;

                    case "2":

                        Console.Clear();// Kullanıcıya temiz bir konsol ekranı gösterir.
                                        //Kullanıcıdan otoparktan çıkarılması istenen aracın plaka bilgisinin girilmesini ister
                        Console.WriteLine("Çıkarmak istediğiniz aracın plakasını giriniz: ");
                        string arac = Console.ReadLine();
                        //Otopark sınıfındaki "aracCikar" metodunu çağırarak aracı otoparktan çıkartır.
                        otopark.aracCikar(arac);
                        break;

                    case "3":
                        Console.Clear();// Kullanıcıya temiz bir konsol ekranı gösterir.
                        Console.WriteLine("Araçların Listesi: ");
                        //Otopark sınıfındaki "araclariListele" metodunu çağırarak otoparktaki araçları listeler.
                        otopark.araclariListele();
                        break;

                    case "4":
                        Console.Clear();// Kullanıcıya temiz bir konsol ekranı gösterir.
                                        //Otopark sınıfındaki "BosYerKontrolu" metodunu çağırarak otoparktaki boş yer sayısını verir.
                        otopark.BosYerKontrolu();
                        break;

                    case "5":
                        Console.Clear();// Kullanıcıya temiz bir konsol ekranı gösterir.
                                        //Kullanıcıdan aramak istediği aracın plaka bilgisini ister.
                        Console.WriteLine("Aramak istediğiniz aracın plakasını giriniz: ");
                        string aramaPlaka = Console.ReadLine();
                        //Otopark sınıfındaki "aracAra" metodunu çağırarak aranan plakaya ait aracı verir.
                        otopark.aracAra(aramaPlaka);
                        break;

                    case "6":
                        Console.Clear();// Kullanıcıya temiz bir konsol ekranı gösterir.
                        Console.WriteLine("Toplam Araç Sayısı: ");
                        //Otopark sınıfındaki "toplamAracSayisi" metodunu çağırarak otoparktaki toplam araç sayısını verir.
                        otopark.toplamAracSayisi();
                        break;

                    case "7":
                        Console.Clear();// Kullanıcıya temiz bir konsol ekranı gösterir.
                                        //Kullanıcıdan listelemek istediği araç renginin bilgisini ister.
                        Console.WriteLine("Listelemek istediğiniz araç rengini giriniz: ");
                        string listelenenRenk = Console.ReadLine();
                        //Otopark sınıfındaki "belirliRenktekiAraclariListele" metodunu çağırarak istenen renkteki araçları listeler.
                        otopark.belirliRenktekiAraclariListele(listelenenRenk);
                        break;

                    case "8":
                        Console.Clear();// Kullanıcıya temiz bir konsol ekranı gösterir.
                                        //Kullanıcıdan listelemek istediği araç modelinin bilgisini ister.
                        Console.WriteLine("Listelemek istediğiniz aracın modelini giriniz: ");
                        string listelenenModel = Console.ReadLine();
                        //Otopark sınıfındaki "belirliModeldekiAraclariListele" metodunu çağırarak istenen modeldeki araçları listeler.
                        otopark.belirliModeldekiAraclariListele(listelenenModel);
                        break;

                    case "9":
                        Console.Clear();// Kullanıcıya temiz bir konsol ekranı gösterir.
                                        //Kullanıcıdan güncellemek istediği aracın plaka bilgisini ister.
                        Console.WriteLine("Güncellemek istediğiniz aracın plakasını giriniz: ");
                        string plakaNumarası = Console.ReadLine();
                        Console.WriteLine("Yeni markayı giriniz: ");//Güncellemek istediği yeni marka bilgisini girmesini ister.
                        string yenimarka = Console.ReadLine();
                        Console.WriteLine("Yeni modeli giriniz: ");//Güncellemek istediği yeni model bilgisini girmesini ister.
                        string yenimodel = Console.ReadLine();
                        Console.WriteLine("Yeni rengi giriniz: ");//Güncellemek istediği yeni renk bilgisini girmesini ister.
                        string yenirenk = Console.ReadLine();
                        //Otopark sınıfındaki "aracGüncelleme" metodunu çağırarak güncellenen yeni aracın bilgilerini verir.
                        otopark.aracGüncelleme(plakaNumarası, yenimarka, yenimodel, yenirenk);
                        break;

                    case "10":
                        Console.Clear();// Kullanıcıya temiz bir konsol ekranı gösterir.
                                        //Güncellemek istediği yeni marka bilgisini girmesini ister.
                        Console.WriteLine("Görüntülemek istediğiniz aracın plakasını giriniz: ");
                        string görüntülenenPLaka = Console.ReadLine();
                        //Otopark sınıfındaki "aracDetaylarıiGörüntüleme" metodunu çağırarak görüntülemek istenen aracın bilgilerini verir.
                        otopark.aracDetaylarıiGörüntüleme(görüntülenenPLaka);
                        break;


                    case "11":
                        Console.Clear();// Kullanıcıya temiz bir konsol ekranı gösterir.
                                        //Otopark sınıfındaki "GirisEkranıVeTarifeHesaplama" metodunu çağırarak tarife ekranını verir.
                        otopark.GirisEkranıVeTarifeHesaplama();
                        break;

                    case "12":
                        Console.Clear();// Kullanıcıya temiz bir konsol ekranı gösterir.
                                        //Kullanıcıdan ücreti hesaplanacak aracın plaka bilgisini ister
                        Console.WriteLine("Araç plakası giriniz: ");
                        string plakaNo = Console.ReadLine();
                        //Kullanıcıdan girdiği aracın çıkış saatini ve tarihini girmesini ister. 
                        Console.WriteLine("Çıkış Saati Giriniz: (YYYY-AA-gg SA:dk)");
                        string cikisSaatiStr = Console.ReadLine();// Console.ReadLine(); ile alır ve cikisSaatiStr adlı bir string değişkenine atar.

                        if (DateTime.TryParseExact(cikisSaatiStr, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime cikisSaati))// Kullanıcının girdiği çıkış saati stringini belirli bir formata çevirmeye çalışır, DateTime.TryParseExact metodu, belirtilen formata uygun bir çıkış alınırsa true değeri döndürür ve çıkış saati, cikisSaati adlı bir DateTime değişkenine atanır.
                        {
                            otopark.CikisTarihiVeUcretHesaplama(plakaNo, cikisSaati);// Eğer çıkış saati geçerli bir formata uygunsa, Otopark sınıfındaki "CikisTarihiVeUcretHesaplama" metodunu çağırır. 'plakaNo' aracın plaka numarasını, 'cikisSaati' ise çıkış zamanını temsil eder.
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz çıkış zamanı. Lütfen geçerli bir zaman giriniz.");//Eğer çıkış saati geçerli bir formata uygun değilse vereceği hata.
                        }
                        break;

                    case "13":
                        Console.Clear();// Kullanıcıya temiz bir konsol ekranı gösterir.
                                        //Otopark sınıfındaki "OtoparkiSifirla" metodunu çağırarak otoparkı sıfırlar.
                        otopark.OtoparkiSifirla();
                        break;

                }
            } while (true);

            Console.ReadLine();
        }
    }
}
