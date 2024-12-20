using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingDecision
{
  internal class Program
  {
    static void Main(string[] args)
    {

      #region If - Else

      //Console.Write("Lütfen şifreyi giriniz:");
      //string password = Console.ReadLine();
      //if (password == "abcd")
      //{
      //  Console.WriteLine("Şifre doğru");
      //}
      //else
      //{
      //  Console.WriteLine("Şifre Yanlış");
      //}


      //string capital, country;
      //Console.Write("Başkenti giriniz:");
      //capital = Console.ReadLine().ToLower();
      //Console.WriteLine();

      //Console.Write("Ülkeyi giriniz:");
      //country = Console.ReadLine().ToLower();

      //if (capital == "ankara" & country == "türkiye")
      //{
      //  Console.WriteLine("Veriler doğrulandı");
      //}
      //else
      //{
      //  Console.WriteLine("Hatalı bilgi");
      //}



      //Console.Write("Bir sayı giriniz:");
      //int number = int.Parse(Console.ReadLine());

      //if (number == 5)
      //{
      //  Console.WriteLine("Girilen sayı doğru");
      //}
      //else
      //{
      //  Console.WriteLine("Girilen sayı yanlış");
      //}


      //int exam1, exam2, exam3, avg;
      //string result;

      //Console.Write("1.Sınavınızı giriniz:");
      //exam1 = int.Parse(Console.ReadLine());
      //Console.WriteLine();

      //Console.Write("2.Sınavınızı giriniz:");
      //exam2 = int.Parse(Console.ReadLine());
      //Console.WriteLine();

      //Console.Write("3.Sınavınızı giriniz:");
      //exam3 = int.Parse(Console.ReadLine());
      //Console.WriteLine();

      //avg = (exam1 + exam2 + exam3) / 3;

      //Console.Write($"Sınavların ortalaması :{avg}");

      //if (avg > 0 & avg <= 50)
      //{
      //  result = "Sonuç vasat";
      //}
      //if (avg > 50 & avg <= 70)
      //{
      //  result = "Sonuç orta";
      //}
      //if (avg > 70 & avg <= 84)
      //{
      //  result = "Sonuç iyi";
      //}
      //if (avg > 84 & avg <= 100)
      //{
      //  result = "Sonuç çok iyi";
      //}
      //else
      //{
      //  result = "Yanlış bir değer girdiniz";
      //}

      //Console.WriteLine(result);


      //string city;
      //Console.Write("Lütfen bir şehir giriniz:");
      //city = Console.ReadLine();

      //if (city == "adana" | city == "bursa" | city == "istanbul")
      //{
      //  Console.WriteLine("Doğru Şehir seçimi yaptınız");
      //}
      //else
      //{
      //  Console.WriteLine("Şehir seçiminiz hatalı tekrar deneyiniz.");
      //}


      //Console.Write("Lütfen kullanıcı adını giriniz:");
      //string userName = Console.ReadLine();

      //if (userName != "admin")
      //{
      //  Console.WriteLine("Kullanıcı adınız hatalı");
      //}
      //else
      //{
      //  Console.WriteLine("Kullanıcı adınız doğru. başarıyla giriş yapıldı");
      //}



      #endregion

      #region Mod İşlemleri

      //int number = 26;
      //int result = number % 3;
      //Console.WriteLine(result);

      //Console.Write("1.Sayıyı giriniz:");
      //int number1 = int.Parse(Console.ReadLine());

      //Console.Write("2.Sayıyı giriniz:");
      //int number2 = int.Parse(Console.ReadLine());

      //int result = number1 % number2;
      //Console.WriteLine();
      //Console.Write($"1.Sayının 2.sayıya bölümünden kalan:{result}");


      //Console.Write("Lütfen sayıyı giriniz:");
      //int number = int.Parse(Console.ReadLine());
      //if (number % 2 == 0)
      //{
      //  Console.Write("Sayı çifttir");
      //}
      //else
      //{
      //  Console.WriteLine("Sayı tektir");
      //}



      #endregion

      #region Char Değişkenler ile Karar Yapıları
      //Console.Write("Takımınızın baş harfini giriniz:");
      //char team = char.Parse(Console.ReadLine());

      //if (team == 'f' | team == 'F')
      //{
      //  Console.WriteLine("Fenerbahçe");
      //}
      //if (team == 'g' | team == 'G')
      //{
      //  Console.WriteLine("Galatasaray");
      //}
      //if (team == 'b' | team == 'B')
      //{
      //  Console.WriteLine("Beşiktaş");
      //}

      //if (team == 't' | team == 'T')
      //{
      //  Console.WriteLine("Trabzon");
      //}



      #endregion

      #region Örnek Proje Uygulaması

      //Console.Write("****** C# Eğitim Kampı Restoran ******");
      //Console.WriteLine();
      //Console.WriteLine("-----------------------------------------");
      //Console.WriteLine("1-Ana Yemekler");
      //Console.WriteLine("2-Çorbalar");
      //Console.WriteLine("3-Pizzalar");
      //Console.WriteLine("4-İçecekler");
      //Console.WriteLine("5-Tatlılar");
      //Console.WriteLine("-----------------------------------------");
      //Console.WriteLine();


      //Console.Write("Detayını görmek istediğiniz menü seçimi:");
      //string menuChoose = Console.ReadLine();
      //if (menuChoose =="1")
      //{
      //  Console.WriteLine();
      //  Console.WriteLine("----------------- Ana Yemekler -----------------");
      //  Console.WriteLine();
      //  Console.WriteLine("1-Köri Soslu Tavuk");
      //  Console.WriteLine("2-Kızartma Tabağı");
      //  Console.WriteLine("3-Fasulye Pilav");
      //  Console.WriteLine("4-Fırında Somon");
      //  Console.WriteLine("5-Patlıcan Musakka");
      //  Console.WriteLine("----------------- Ana Yemekler -----------------");
      //}
      //if (menuChoose == "2")
      //{
      //  Console.WriteLine();
      //  Console.WriteLine("----------------- Çorbalar -----------------");
      //  Console.WriteLine();
      //  Console.WriteLine("1-Yayla Çorbası");
      //  Console.WriteLine("2-Tarhana Çorbası");
      //  Console.WriteLine("3-Tavuk Suyu Çorbası");
      //  Console.WriteLine("4-İşkembe Çorbası");
      //  Console.WriteLine("5-Ezogelin Çorbası");
      //  Console.WriteLine("----------------- Çorbalar -----------------");
      //}
      //if (menuChoose == "3")
      //{
      //  Console.WriteLine();
      //  Console.WriteLine("----------------- Pizzalar -----------------");
      //  Console.WriteLine();
      //  Console.WriteLine("1- 4 Peynirli Pizza");
      //  Console.WriteLine("2-Tavuklu Pizza");
      //  Console.WriteLine("3-Sucuklu Pizza");
      //  Console.WriteLine("4-Karışık Pizza");
      //  Console.WriteLine("5-Akdeniz Pizza");
      //  Console.WriteLine("----------------- Pizzalar -----------------");
      //}

      //if (menuChoose == "4")
      //{
      //  Console.WriteLine();
      //  Console.WriteLine("----------------- İçecekler -----------------");
      //  Console.WriteLine();
      //  Console.WriteLine("1-Kola");
      //  Console.WriteLine("2-Ayran");
      //  Console.WriteLine("3-Su");
      //  Console.WriteLine("4-Fuse Tea");
      //  Console.WriteLine("5-Gazoz");
      //  Console.WriteLine("----------------- İçecekler -----------------");
      //}

      //if (menuChoose == "5")
      //{
      //  Console.WriteLine();
      //  Console.WriteLine("----------------- Tatlılar -----------------");
      //  Console.WriteLine();
      //  Console.WriteLine("1-Sütlaç");
      //  Console.WriteLine("2-Magnolya");
      //  Console.WriteLine("3-Tavuk Göğsü");
      //  Console.WriteLine("4-Baklava");
      //  Console.WriteLine("5-Profiterol");
      //  Console.WriteLine("----------------- Tatlılar -----------------");
      //}



      #endregion


      #region Switch - Case

      //Console.Write("Lütfen ay girişi yapınız:");
      //int monthNumber = int.Parse(Console.ReadLine());


      //switch (monthNumber)
      //{
      //  case 1:
      //    Console.Write("Ocak");
      //    break;
      //  case 2:
      //    Console.Write("Şubat");
      //    break;
      //  case 3:
      //    Console.Write("Mart");
      //    break;
      //  case 4:
      //    Console.Write("Nisan");
      //    break;
      //  case 5:
      //    Console.Write("Mayıs");
      //    break;
      //  case 6:
      //    Console.Write("Haziran");
      //    break;
      //  case 7:
      //    Console.Write("Temmuz");
      //    break;
      //  case 8:
      //    Console.Write("Ağustos");
      //    break;
      //  case 9:
      //    Console.Write("Eylül");
      //    break;
      //  case 10:
      //    Console.Write("Ekim");
      //    break;
      //  case 11:
      //    Console.Write("Kasım");
      //    break;
      //  case 12:
      //    Console.Write("Aralık");
      //    break;
      //  default:
      //    Console.WriteLine("Hatalı veri girişi");
      //    break;
      //}








      #endregion

      #region Switch - Case Hesap Makinası

      //int number1, number2,result;
      //char symbol;

      //Console.Write("1.Sayıyı Giriniz:");
      //number1 = int.Parse(Console.ReadLine());
      //Console.WriteLine();

      //Console.Write("2.Sayıyı Giriniz:");
      //number2 = int.Parse(Console.ReadLine());
      //Console.WriteLine();

      //Console.WriteLine("Yapmak İstediğiniz işlemi seçiniz: (x) - (/) - (-) - (+)");
      //symbol = char.Parse(Console.ReadLine());
      //switch (symbol)
      //{
      //  case 'x':result = number1 * number2;
      //    Console.Write($"Çarpma işlemi sonucu:{number1} x {number2} = {result}");
      //    break;

      //  case '/':
      //    result = number1 / number2;
      //    Console.Write($"Bölme işlemi sonucu:{number1} / {number2} = {result}");
      //    break;

      //  case '-':
      //    result = number1 - number2;
      //    Console.Write($"Çıkarma işlemi sonucu:{number1} - {number2} = {result}");
      //    break;

      //  case '+':
      //    result = number1 + number2;
      //    Console.Write($"Toplama işlemi sonucu:{number1} + {number2} = {result}");
      //    break;


      //  default:
      //    Console.WriteLine("Yanlış karakter girişi, tekrar deneyiniz.");
      //    break;
      //}

      #endregion


      Console.Read();
    }










  }
}
