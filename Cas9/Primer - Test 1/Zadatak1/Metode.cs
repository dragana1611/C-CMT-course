using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    static class Metode
    {
        public static void UpisUFajl(string putanja, string sadrzaj)
        {
            byte[] bafer = Encoding.UTF8.GetBytes(sadrzaj);

            // Otvaranje binarnog file stream objekta za upis u fajl (obezbeđeno implicitno oslobađanje resursa)
            using (FileStream fajlStream = new FileStream(putanja, FileMode.OpenOrCreate, FileAccess.Write))
            {
                fajlStream.Write(bafer, 0, bafer.Length);
            } // Implicitno se poziva fajlStream.Dispose() za oslobađanje resursa
        }

        public static string CitanjeIzFajla(string putanja)
        {
            byte[] bafer;

            // Otvaranje binarnog file stream objekta za čitanje iz fajla (obezbeđeno implicitno oslobađanje resursa)
            using (FileStream fajlStream = new FileStream(putanja, FileMode.Open, FileAccess.Read))
            {
                int length = (int)fajlStream.Length;   
                bafer = new byte[length];              
               
                fajlStream.Read(bafer, 0, length);
            } // Implicitno se poziva fajlStream.Dipose() za oslobađanje resursa

            string sadrzaj = Encoding.UTF8.GetString(bafer);
            return sadrzaj;
        }
    }
}
