using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Her_Asal_Icin_Pisagor_Uclusu
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*Her asal icin pisagor uclusu vardır (2 hariç)
            x^2 = (y) + (y+1) burada y+1 hipotenus olsun
            x asali icin x^2 = (y) + (y+1) olur veya 
            kisacasi x asalinin karesi, ardisik 2 sayinin toplamidir
            */

            /* algoritmasi;
               1 - 100e kadar olan sayilari döngüyle kontrol et
               2 - asal olanları tut ve yazdır
            */
            bool asalmi = false;
            List<int> asalKisaKenarlar = new List<int>();
            List<int> ikinciKenarlar = new List<int>();
            List<int> HipotenusKenarlar = new List<int>();


            //burada 100'e kadar olan asal kisakenarlari bulduk ve listeye atadik.
            for (int kisaKenar = 3; kisaKenar < 100; kisaKenar += 2)
            {
                for (int kareKok = (int)Math.Sqrt(kisaKenar) + 1; kareKok >= 2; kareKok--)
                {
                    if (kisaKenar % kareKok == 0)
                    {
                        asalmi = false;
                        break;
                    }
                    else
                    {
                        asalmi = true;
                    }
                }
                if (asalmi)
                {
                    asalKisaKenarlar.Add(kisaKenar);
                }
            }
            //asalKisaKenarlar.ForEach(k => { Console.WriteLine(k); });

            //ikinci ve hipotenüs kenarlarını listeye atayalım
            for (int i = 0; i < asalKisaKenarlar.Count; i++)
            {
                ikinciKenarlar.Add((int)(Math.Pow(asalKisaKenarlar[i], 2)) / 2);
                HipotenusKenarlar.Add(ikinciKenarlar[i]);
                Console.WriteLine($"{asalKisaKenarlar[i]} - {ikinciKenarlar[i]} - {++HipotenusKenarlar[i]}");
            }

            Console.ReadLine();

        }
    }
}
