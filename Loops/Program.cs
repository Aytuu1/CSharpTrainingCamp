using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Loops
{
  internal class Program
  {
    static void Main(string[] args)
    {
      #region For loop

      // for (x;y;z;)
      // x: başlangıç değeri
      // y: bitiş değeri
      // z: artış veya azalış değeri

      //int i;
      //for (i = 0; i < 5; i++)
      //{
      //  Console.WriteLine("C# Eğitim Kampı");
      //}

      //for (int i = 1; i <= 20; i++) 
      //{
      //          Console.WriteLine(i);
      //}

      //for (int i = 3; i < 50; i+=3)
      //{
      //          Console.WriteLine(i);
      //}

      //Console.Write("Lütfen Ekrana Yazılmak istediğiniz adedi giriniz:");
      //int finishValue = int.Parse(Console.ReadLine());
      //for (int i = 0; i <= finishValue; i++)
      //{
      //  Console.WriteLine(i);

      //}

      //Console.Write("Başlangıç değerini giriniz:");
      //int startValue = int.Parse(Console.ReadLine());

      //Console.Write("Bitiş Değerini Giriniz:");
      //int finishValue = int.Parse(Console.ReadLine());

      //for (int i = startValue; i <= finishValue; i++)
      //{
      //  Console.WriteLine(i);
      //}



      #endregion

      #region For döngüsü ile karar yapıları

      //for (int i = 1; i <= 100; i++)
      //{
      //  if (i % 5 == 0)
      //  {
      //    Console.WriteLine(i);
      //  }
      //}

      //int totalValue = 0;
      //for (int i = 0; i <= 10; i++) {

      //  totalValue += i;
      //}
      //Console.WriteLine(totalValue);


      //int totalValue = 0;
      //for (int i = 0; i < 20; i++)
      //{
      //  if (i % 2 == 0)
      //  {
      //    totalValue += i;
      //  }

      //}
      //Console.WriteLine(totalValue);


      //int count = 0;
      //for (int i = 1; i < 50; i++)
      //{
      //  if (i % 7 == 0)
      //  {
      //    count++;
      //    Console.WriteLine(i);
      //  }
      //}
      //Console.WriteLine("--------------------");
      //Console.WriteLine(count);



      //int bacterium = 1;
      //for (int i = 1; i <= 24; i++)
      //{
      //  bacterium *= 2;
      //  Console.WriteLine($"{i}.saat sonunda: {bacterium}");
      //}




      #endregion


      #region While Döngüsü

      //int i = 1;
      //while (i < 10)
      //{
      //  Console.WriteLine("Merhaba Döngüler");
      //  i++;
      //}


      //int i = 1;
      //while (i <= 10)
      //{
      //  if (i % 3 == 0)
      //  {
      //    Console.WriteLine(i);
      //  }

      //  i++;
      //}


      //int i = 1;
      //int sum = 0;
      //while (i <= 10)
      //{
      //  sum += i;
      //  i++;
      //}
      //Console.WriteLine(sum);

      #region Örnek Sınav Sorusu
      // Klavyeden girilen 3 basamaklı sayının rakamları toplamını hesaplayan program
      //Console.Write("3 basamaklı bir sayı giriniz:");
      //int userNumber = int.Parse(Console.ReadLine());
      //int ones, tens, hundreds;
      //int sum = 0;

      //ones = userNumber % 10;
      //tens = (userNumber % 100) / 10;
      //hundreds = userNumber / 100;

      //sum = ones + tens + hundreds;
      //Console.WriteLine($"Girilen sayının basamakları toplamı:{sum}");
      #endregion



      #endregion




      Console.Read();
    }










  }
}
