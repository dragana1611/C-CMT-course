using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            KljucnaRec kljucnaRec = new KljucnaRec("Tekst.txt", 2);
           // Console.WriteLine("Najduza kljucna rec je {0} ima {1} slova", kljucnaRec.NajduzaRecRec(), kljucnaRec.NajduzaRec());
            Console.WriteLine($"Najduza kljucna rec je {kljucnaRec.NajduzaRecRec()} i ima {kljucnaRec.NajduzaRec()} slova");
            Console.WriteLine("Najcesca kljucna rec je {0}", kljucnaRec.NajcescaRec());
            kljucnaRec.EksportKljucneReci("KljucneReci.txt");
            Console.WriteLine("Sve kljucne reci :\n{0}", kljucnaRec);

            PonavljanjeKljucnihReci ponavljanjeKljucnihReci = new PonavljanjeKljucnihReci("Tekst.txt", 2);
            ponavljanjeKljucnihReci.EksportPonavljanja("PonavljanjeOpadajuce.txt", NacinSortiranja.Opadajuce);
            Console.WriteLine($"Ponavljanje kljucnih reci opadajuce :\n {ponavljanjeKljucnihReci}" );
            ponavljanjeKljucnihReci.EksportPonavljanja("PonavljanjeRastuce.txt", NacinSortiranja.Rastuce);
            Console.WriteLine("Ponavljanje kljucnih reci rastuce :\n {0}", ponavljanjeKljucnihReci);
            
            Console.ReadKey();
        }
    }
}
