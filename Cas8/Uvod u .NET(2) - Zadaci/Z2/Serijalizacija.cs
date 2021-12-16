using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    public static class Serijalizacija
    {
        public static void Serijalizuj(string imeFajla, Ucenik ucenik)
        {
            try
            {
                using (FileStream izlazniStream = File.Create(imeFajla))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(izlazniStream, ucenik);

                    Console.WriteLine("Uspešno serijalizovan ucenik {0}", ucenik.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Problem pri serijalizaciji objekta. Poruka : " + e.Message);
            }
        }

        public static Ucenik Deserijalizuj(string imeFajla)
        {

            try
            {
                using (FileStream ulazniStream = File.OpenRead(imeFajla))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    Ucenik ucenik = (Ucenik)formatter.Deserialize(ulazniStream);
                    return ucenik;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Problem pri deserijalizaciji objekta. Poruka : " + e.Message);
                return null;
            }
        }
    }
}
