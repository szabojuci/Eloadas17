using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv
{
    class Konyv
    {
        string isbnSzam;
        string szerzok;
        string muCime;
        int kiadasiEv;
        string nyelv;
        bool enciklopedia;
        char eBook;

        public string IsbnSzam
        {
            get { return isbnSzam; }
            set { isbnSzam = value; }
        }
        public string Szerzok
        {
            get { return szerzok; }
            set { szerzok = value; }
        }
        public string MuCime
        {
            get { return muCime; }
            set { muCime = value; }
        }
        public int KiadasiEv
        {
            get { return kiadasiEv; }
            set { kiadasiEv = value; }
        }
        public string Nyelv
        {
            get { return nyelv; }
            set { nyelv = value; }
        }
        public bool Enciklopedia
        {
            get { return enciklopedia; }
            set { enciklopedia = value; }
        }
        public char EBook
        {
            get { return eBook; }
            set { eBook = value; }
        }
        public override string ToString()
        {
            return $"Isbn szám: {isbnSzam}\nSzerző: {szerzok}\nMű címe: {muCime}\nKiadási év: {kiadasiEv}\nNyelv: {nyelv}\nEnciklopédia: {enciklopedia}\nEbook: {eBook}";
        }
        public Konyv(string isbnSzam, string szerzok, string muCime, int kiadasiEv, string nyelv, bool enciklopedia, char eBook)
        {
            IsbnSzam = isbnSzam;
            Szerzok = szerzok;
            MuCime = muCime;
            KiadasiEv = kiadasiEv;
            Nyelv = nyelv;
            Enciklopedia = enciklopedia;
            EBook = eBook;
        }

        public Konyv()
        {
        }
        ~Konyv() //destruktor <--> konstruktor
        {
            Console.WriteLine("A destruktor tette a dolgát...");
        }
    }
}
