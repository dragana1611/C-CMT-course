using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace SqlCommandKlasa
{
    class SqlCommandKlasa
    {
        static void Main()
        {
            // ukoliko ne zeli da se poveze, umesto localhost se stavi naziv lokacije baze podataka 
            using (SqlConnection konekcija =          
                new SqlConnection("Data Source=localhost;Integrated Security=true;Initial Catalog=CMT"))
            {
                konekcija.Open();

                string tekstNaredbe =
                    "DELETE FROM polaznik WHERE ime = 'Dragan' AND prezime = 'Draganić'";

                using (SqlCommand naredba = new SqlCommand(tekstNaredbe, konekcija))
                {
                    int brojPogodjenihRedova = naredba.ExecuteNonQuery();

                    Console.WriteLine("Uspešno je izvršena naredba '{0}'.", brojPogodjenihRedova);
                }
            }
        }
    }
}
