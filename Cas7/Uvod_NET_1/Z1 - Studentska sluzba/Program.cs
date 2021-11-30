using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1___Studentska_sluzba
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("1", "Ivan", "Ivic", new DateTime(2000, 10, 7), Smer.Programiranje, new ArrayList { "matematika", "programiranje", "engleski" });
            Student s2 = new Student("2", "Jovana", "Jovic", new DateTime(2000, 8, 7), Smer.Fizika);
            Student s3 = new Student("3", "Petar", "Peric", new DateTime(2001, 12, 15), Smer.Filozofija);
            Student s4 = new Student("4", "Milica", "Milovanovic", new DateTime(2000, 1, 17), Smer.Masinstvo, new ArrayList { "matematika", "programiranje" });
            Student s5 = new Student("5", "Teodora", "Drakulic", new DateTime(2000, 2, 27), Smer.Filozofija);
            Student s6 = new Student("6", "Milan", "Milicic", new DateTime(2001, 8, 27), Smer.Menadzment);
            Student s7 = new Student("7", "Branislav", "Bratic", new DateTime(1999, 1, 1), Smer.Programiranje, new ArrayList { "matematika", "programiranje", "engleski" });
            Student s8 = new Student("8", "Branka", "Jovic", new DateTime(2001, 8, 27), Smer.Pravo);
            Student s9 = new Student("9", "Mile", "Miric", new DateTime(2000, 8, 20), Smer.Programiranje);
            Student s10 = new Student("10", "Ognjen", "Jelic", new DateTime(1999, 10, 31), Smer.Poljoprivreda);
            Student s11 = new Student("11", "Jelena", "Jelenic", new DateTime(2000, 9, 21), Smer.Masinstvo, new ArrayList { "matematika", "programiranje", "engleski", "masinski materijali" });
            Student s12 = new Student("12", "Snezana", "Snezic", new DateTime(1999, 11, 11), Smer.Pravo);
            Student s13 = new Student("13", "Vukasin", "Vukic", new DateTime(2001, 4, 27), Smer.Poljoprivreda);
            Student s14 = new Student("14", "Ljubica", "Ljubic", new DateTime(2001, 5, 18), Smer.Menadzment);

            StudentskaSluzba.DodajStudenta(s1);
            StudentskaSluzba.DodajStudenta(s2);
            StudentskaSluzba.DodajStudenta(s3);
            StudentskaSluzba.DodajStudenta(s4);
            StudentskaSluzba.DodajStudenta(s5);
            StudentskaSluzba.DodajStudenta(s6);
            StudentskaSluzba.DodajStudenta(s7);
            StudentskaSluzba.DodajStudenta(s8);
            StudentskaSluzba.DodajStudenta(s9);
            StudentskaSluzba.DodajStudenta(s10);
            StudentskaSluzba.DodajStudenta(s11);
            StudentskaSluzba.DodajStudenta(s12);
            StudentskaSluzba.DodajStudenta(s13);
            StudentskaSluzba.DodajStudenta(s14);

            IspisListe(StudentskaSluzba.SviStudenti());

            StudentskaSluzba.ObrisiStudenta(s2.BrIndeksa);
            StudentskaSluzba.ObrisiStudenta(s14.BrIndeksa);

            IspisListe(StudentskaSluzba.SviStudenti());

            s3.DodajPredmet("matematika");
            s3.DodajPredmet("engleski");
            StudentskaSluzba.IzmeniStudneta(s3);

            IspisListe(StudentskaSluzba.SviStudenti());

            StudentskaSluzba.DodajPredmetStudentu(s4.BrIndeksa, "matematika 2", "analiza", "algebra");
            StudentskaSluzba.DodajPredmetStudentu(s13.BrIndeksa, "matematika 2", "analiza", "algebra");

            IspisListe(StudentskaSluzba.SviStudenti());

            Console.WriteLine("Studenti koji slusaju Matematiku");
            Console.WriteLine("----------------------------------------");
            IspisListe(StudentskaSluzba.StudentiPoPredmetu("matematika"));

            Console.WriteLine("Studenti koji su na smeru Programiranje");
            Console.WriteLine("----------------------------------------");
            IspisListe(StudentskaSluzba.StudentiPoSmeru(Smer.Programiranje));

            Console.WriteLine("Studenti koji slusaju Matematiku i pohadjaju smer Programiranje");
            Console.WriteLine("----------------------------------------");
            IspisListe(StudentskaSluzba.StudentiPoSmeruIPredmetu(Smer.Programiranje, "matematika"));

        }

        static void IspisListe(List<Student> lista)
        {
            foreach (Student s in lista)
            {
                Console.WriteLine(s);
                Console.WriteLine("----------------------------------------");
            }
            Console.ReadKey();
        }
    }
}
