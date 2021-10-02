using System;

namespace codeofflow
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  
            ////1. Verilmis n ededinin 3-e ve 7-ye bolunub bolunmemesini tapin.
            //int n = 45;
            //if (n == 0)
            //{
            //    Console.WriteLine("Dont enter 0");
            //}

            //if (n % 21 == 0)
            //{
            //    Console.WriteLine("Eded 3-e ve 7-ye bolunur.");
            //}
            //else
            //{
            //    Console.WriteLine("Eded 3-e ve 7-ye bolunmur");
            // }
            #endregion


            #region

            ////2.Verilmis duzbucaqli skafin her hansi bir qapidan kecib-kecmiyeceyni tapan algoritm yazin.

            //int skafEn =1, skafUzunluq=2, skafQalinliq=3;
            //  int qapiEn=4, qapiUzunluq=5;

            //if (skafEn<=qapiEn && skafUzunluq<=qapiUzunluq)
            //{
            //    Console.WriteLine("skaf qapidan kececek");
            //}
            

            //else if(skafQalinliq<=qapiEn && skafUzunluq <= qapiUzunluq)
            //{
            //    Console.WriteLine("skaf qapidan kececek");
            //}

            //else if(skafEn<=qapiEn && skafQalinliq <= qapiUzunluq)
            //{
            //    Console.WriteLine("skaf qapidan kececek");
            //}

            //else if(skafUzunluq<=qapiUzunluq && skafQalinliq <= qapiEn)
            //{
            //    Console.WriteLine("skaf qapidan kececek");
            //}

            //else
            //{
            //    Console.WriteLine("skaf qapidan kecmeyecek");
            //}

            #endregion

            #region 
            ////3.Verilmis n ve m (n<m) ededleri arasinda nece tek eded oldugunu tapin.

            //int n =5, m=10;
            //int counter = 0;

            //for (int i = n; i < m; i++)
            //{

            //    if (i % 2 != 0)
            //    {
            //        counter++;
            //    }

            //}
            //Console.WriteLine(counter);
            #endregion

            #region
            ////4.Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.
            //int n = 0;
            //int counter = 0;

            //if (n <= 0 || n == 1)
            //{
            //    Console.WriteLine("ne sadedir, ne de murekkeb");
            //}

            //else if (n % 2 == 0 && n != 2)
            //{
            //    Console.WriteLine("murekkeb ededdir");
            //}

            //for (int i = 2; i < n; i++)
            //{
            //    if (n%i==0)
            //    {
            //        counter++;
            //    }
            //}

            //if (counter != 0)
            //{
            //    Console.WriteLine("murekkeb ededdir");
            //}
            //else
            //{
            //    Console.WriteLine("sade ededdir");
            //}

            #endregion


            #region
            ////5.Verilmis musbet tam n ededinin 2-nin quvveti olub-olmamasini tapin.

            // int n=1024;
            // while (n%2==0)
            // {
            //     n /= 2;
            // }

            // if(n%2 == 1 && n!=1)
            // {
            //     Console.WriteLine("quvveti deyil");
            // }
            // else
            // {
            //     Console.WriteLine("quvvetidir");
            // }
            #endregion

            #region         
            ////6.Verilmis n tam ededinin nece mertebeli oldugunu tapin.
            //  int n = 125683;
            //  int count = 0;
            //  while (n / 10 != 0)
            //  {
            //      n /= 10;
            //      count++;
            //  }
            //  Console.WriteLine(count + 1);
            #endregion

        }
    }
}
