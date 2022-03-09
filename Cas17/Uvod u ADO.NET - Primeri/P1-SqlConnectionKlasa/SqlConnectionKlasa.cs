using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ADO.NET_Primeri
{
    class SqlConnectionKlasa
    {
        static void Main()
        {
            using (SqlConnection konekcija = new SqlConnection())
            {
                // ukoliko ne zeli da se poveze, umesto localhost se stavi naziv lokacije baze podataka 
                konekcija.ConnectionString =
                    "Data Source=DESKTOP-401MRJI\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=CMT";
                konekcija.Open();

                Console.WriteLine("Veza sa bazom je uspostavljena");
            }
        }
    }    
}
