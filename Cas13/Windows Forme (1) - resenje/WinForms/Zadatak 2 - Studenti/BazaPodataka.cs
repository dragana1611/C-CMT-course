using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_2___Studenti
{
    
    class BazaPodataka
    {
        public static Dictionary<int, Predmet> listaPredmeta = new Dictionary<int, Predmet>();
        public static List<Student> studenti = new List<Student>();
        static BazaPodataka()
        {
            // dodavanje predmeta
            Predmet p1 = new Predmet("Matematika 2", "Ivan Ivic", 2);
            Predmet p2 = new Predmet("Matematika 1", "Ivan Ivic", 1);
            Predmet p3 = new Predmet("Programiranje 1", "Milan Milic", 1);
            Predmet p4 = new Predmet("Programiranje 2", "Milan Milic", 2);
            Predmet p5 = new Predmet("Programiranje 3", "Milan Milic", 3);
            Predmet p6 = new Predmet("Programiranje 4", "Milan Milic", 4);
            Predmet p7 = new Predmet("Matematika 3", "Ivan Ivic", 3);
            Predmet p8 = new Predmet("Matematika 4", "Ivan Ivic", 4);
            Predmet p9 = new Predmet("Merenja", "Jovan Jovic", 2);
            Predmet p10 = new Predmet("Tehnicko crtanje", "Milica Ivic", 4);
            Predmet p11 = new Predmet("Verovatnoca i slucajni procesi", "Mila Stojakovic", 2);
            Predmet p12 = new Predmet("Algebra 1", "Mihailo Mihajlovic", 3);
            Predmet p13 = new Predmet("Algebra 2", "Mihailo Mihajlovic", 4);
            Predmet p14 = new Predmet("Masinsko merenje 3", "Jovana Jovic", 3);
            Predmet p15 = new Predmet("Masinsko merenje 1", "Jovana Jovic", 1);
            Predmet p16 = new Predmet("Masinsko merenje 2", "Jovana Jovic", 2);
            Predmet p17 = new Predmet("Beton 1", "Petar Petrovic", 3);
            Predmet p18 = new Predmet("Beton 2", "Petar Petrovic", 4);
            Predmet p19 = new Predmet("Arhitektura distribuiranih sistema 2", "Novak Novakovic", 4);
            Predmet p20 = new Predmet("Arhitektura distribuiranih sistema 1", "Novak Novakovic", 3);


            listaPredmeta.Add(p1.IdPredmeta, p1);
            listaPredmeta.Add(p2.IdPredmeta, p2);
            listaPredmeta.Add(p3.IdPredmeta, p3);
            listaPredmeta.Add(p4.IdPredmeta, p4);
            listaPredmeta.Add(p5.IdPredmeta, p5);
            listaPredmeta.Add(p6.IdPredmeta, p6);
            listaPredmeta.Add(p7.IdPredmeta, p7);
            listaPredmeta.Add(p8.IdPredmeta, p8);
            listaPredmeta.Add(p9.IdPredmeta, p9);
            listaPredmeta.Add(p10.IdPredmeta, p10);
            listaPredmeta.Add(p11.IdPredmeta, p11);
            listaPredmeta.Add(p12.IdPredmeta, p12);
            listaPredmeta.Add(p13.IdPredmeta, p13);
            listaPredmeta.Add(p14.IdPredmeta, p14);
            listaPredmeta.Add(p15.IdPredmeta, p15);
            listaPredmeta.Add(p16.IdPredmeta, p16);
            listaPredmeta.Add(p17.IdPredmeta, p17);
            listaPredmeta.Add(p18.IdPredmeta, p18);
            listaPredmeta.Add(p19.IdPredmeta, p19);
            listaPredmeta.Add(p20.IdPredmeta, p20);
        }
    }
}
