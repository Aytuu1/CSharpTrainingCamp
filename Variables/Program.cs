using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
  internal class Program
  {
    static void Main(string[] args)
    {
      #region doubleDeğişkenler
      //double number;
      //number = 4.85;
      //Console.WriteLine(number);

      //Console.WriteLine("***** Fiyat Listesi *****");
      //Console.WriteLine();
      //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
      //applePrice = 14.85;
      //orangePrice = 20.95;
      //strawberryPrice = 45;
      //potatoPrice = 9.75;
      //tomatoPrice = 6.88;

      //Console.WriteLine($"----Elma Birim Fiyatı: {applePrice} TL");
      //Console.WriteLine($"----Portakal Birim Fiyatı: {orangePrice} TL");
      //Console.WriteLine($"----Çilek Birim Fiyatı: {strawberryPrice} TL");
      //Console.WriteLine($"----Patates Birim Fiyatı: {potatoPrice} TL");
      //Console.WriteLine($"----Domates Birim Fiyatı: {tomatoPrice} TL");

      //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
      //appleGram = 1.245;
      //orangeGram = 2.650; 
      //strawberryGram = 0.750;
      //potatoGram = 4.859;
      //tomatoGram = 3.745;

      //double appleTotalPrice = appleGram * applePrice;
      //double orangeTotalPrice = orangeGram * orangePrice;
      //double strawberryTotalPrice = strawberryGram * strawberryPrice;
      //double potatoTotalPrice = potatoGram * potatoPrice;
      //double tomatoTotalPrice = tomatoGram * tomatoPrice;
      //Console.WriteLine();

      //Console.WriteLine($"Elmanın Toplam Fiyatı :{appleTotalPrice}");
      //Console.WriteLine($"Portakalın Toplam Fiyatı :{orangeTotalPrice}");
      //Console.WriteLine($"Çilek Toplam Fiyatı :{strawberryTotalPrice}");
      //Console.WriteLine($"Patates'in Toplam Fiyatı :{potatoTotalPrice}");
      //Console.WriteLine($"Domates'in Toplam Fiyatı :{tomatoTotalPrice}");

      //double totalAmount = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
      //Console.WriteLine();

      //Console.WriteLine($"Toplam Ödenecek Tutar :{totalAmount}");
      //#endregion

      #endregion

      #region charDeğişkenler

      //char symbol = 'a';
      //Console.WriteLine(symbol);

      #endregion

      #region klavyeden veri girişleri String Değişkenler
      //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
      //Console.WriteLine();

      //string pessengerName, pessengerSurname, pessengerDisrict, pessengerCity, pessengerAge, pessengerIdentityNumber;

      //Console.Write("Yolcu Adı:");
      //pessengerName = Console.ReadLine();

      //Console.Write("Yolcu Soyadı:");
      //pessengerSurname = Console.ReadLine();

      //Console.Write("Şehir Bilgisi:");
      //pessengerCity = Console.ReadLine();


      //Console.Write("İlçe Bilgisi:");
      //pessengerDisrict = Console.ReadLine();



      //Console.Write("Yaş Bilgisi:");
      //pessengerAge = Console.ReadLine();

      //Console.Write("Tc Kimlik Numaranız:");
      //pessengerIdentityNumber = Console.ReadLine();


      //Console.WriteLine();
      //Console.WriteLine("--------------------------");
      //Console.WriteLine($"Yolcu: {pessengerName} {pessengerSurname}");
      //Console.WriteLine($"Şehir ve İlçe:{pessengerCity}/{pessengerDisrict}");
      //Console.WriteLine($"Yaş bilgisi:{pessengerAge}");
      //Console.WriteLine($"TC Kimlik Numarası:{pessengerIdentityNumber}");


      #endregion

      #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

      //int shoesPrice, computerPrice, chairPrice, tvPrice;
      //shoesPrice = 1000;
      //computerPrice = 20000;
      //chairPrice = 5000;
      //tvPrice = 12000;

      //int shoesCount, computerCount, chairCount, tvCount;

      //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz:");
      //shoesCount = Convert.ToInt32(Console.ReadLine());
      //Console.WriteLine();

      //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz:");
      //computerCount = Convert.ToInt32(Console.ReadLine());
      //Console.WriteLine();

      //Console.Write("Lütfen aldığınız sandalye sayısını giriniz:");
      //chairCount = Convert.ToInt32(Console.ReadLine());
      //Console.WriteLine();

      //Console.Write("Lütfen aldığınız tv sayısını giriniz:");
      //tvCount = Convert.ToInt32(Console.ReadLine());
      //Console.WriteLine("-------------------------------");


      //int shoesTotalPrice = shoesCount * shoesPrice;
      //int computerTotalPrice = computerPrice * computerCount;
      //int chairTotalPrice = chairPrice * chairCount;
      //int tvTotalPrice = tvPrice * tvCount;

      //Console.WriteLine($"Toplam ayakkabı tutarı:{shoesTotalPrice}TL");
      //Console.WriteLine($"Toplam Bilgisayar tutarı:{computerTotalPrice}TL");
      //Console.WriteLine($"Toplam Sandalye tutarı:{chairTotalPrice}TL");
      //Console.WriteLine($"Toplam Tv tutarı:{tvTotalPrice}TL");

      //int totalAmount = shoesTotalPrice + computerTotalPrice + chairTotalPrice + tvTotalPrice;
      //Console.WriteLine();
      //Console.Write($"Toplam ödemeniz gereken tutar: {totalAmount}TL");

      #endregion

      #region Klavye'den ondalıklı Sayı İşlemleri

      //double exam1, exam2, exam3, result;

      //Console.Write("Lütfen 1.Sınav Notunu Giriniz:");
      //exam1 = double.Parse(Console.ReadLine());
      //Console.WriteLine();

      //Console.Write("Lütfen 2.Sınav Notunu Giriniz:");
      //exam2 = double.Parse(Console.ReadLine());
      //Console.WriteLine();

      //Console.Write("Lütfen 3.Sınav Notunu Giriniz:");
      //exam3 = double.Parse(Console.ReadLine());
      //Console.WriteLine();

      //result = (exam1 + exam2 + exam3) / 3;

      //Console.Write($"Sonucunuz: {result}");

      #endregion

      #region Klavye'den Karakter Girişleri
      // char gender;
      //Console.Write("Lütfen Cinsiyetinizi Seçiniz:");
      //gender = char.Parse(Console.ReadLine());
      //Console.WriteLine($"Seçtiğiniz Cinsiyet: {gender}");
      #endregion


      Console.Read();


    }











  }
}
