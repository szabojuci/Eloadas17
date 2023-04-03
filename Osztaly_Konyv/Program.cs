using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Osztaly_Konyv.Exceptions;

namespace Osztaly_Konyv
{
    class Program
    {
        static Random rnd = new Random();
        static List<Konyv> konyvek = new List<Konyv>();
        static void Main(string[] args)
        {
            for(int i = 0; i < 10000; i++)
            {
                Konyv konyv = new Konyv("1212", "121212", "valami", 2020, "magyar", true, 'i');
            }
            // Konyv osztaly
            //isbnSzam 13 szamjegy
            //szerzok
            //muCime
            //kiadasiEv
            //nyelv
            //enciklopedia - bool
            //eBook - char i/n
            long [] szamok = new long[12];
            for(int i =0; i<szamok.Length; i++)
            {
                szamok[i] = rnd.Next(0,10);
            }
            
            int osszeg = 0;
           
            szamok[0] = rnd.Next(0, 10);
            szamok[1] = rnd.Next(0, 10);
            szamok[2] = rnd.Next(0, 10);
            szamok[3] = rnd.Next(0, 10);
            for (int i = 0; i < szamok.Length; i++)
            { 
                osszeg+= szamok[0]*10;
            }
            int osszegzes = osszeg % 11;

            
            Console.WriteLine( $"Isbn: {string.Join("-", szamok)}");
            Console.WriteLine($"Ellenőrző szám: {osszegzes}");
            Konyv k = new Konyv();
            bool helyes = false;
            do
            {
                Console.WriteLine("ISBN szám: ");
                try
                {
                    string bekert = Console.ReadLine();
                    string numbers = "";
                    foreach (var item in bekert.Split('-'))
                    {
                        numbers += item;
                    }
                    k.IsbnSzam = numbers;
                    Console.WriteLine("A megadott ISBN szám helyes");
                }
                catch (HibasIsbnSzamException e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            } while (helyes = true);

            Console.ReadKey();
        }
    }
}
