using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1___Studentska_sluzba
{
    static class StudentskaSluzba
    {
        static private Dictionary<string, Student> listaStudenata = new Dictionary<string, Student>();

        static public bool DodajStudenta(Student student)
        {
            if (!listaStudenata.ContainsKey(student.BrIndeksa))
            {
                listaStudenata.Add(student.BrIndeksa, student);
                return true;
            }
            return false;
        }

        static public bool ObrisiStudenta(string brIndeksa)
        {
            return listaStudenata.Remove(brIndeksa);
        }

        static public bool IzmeniStudneta(Student student)
        {
            if (listaStudenata.ContainsKey(student.BrIndeksa))
            {
                listaStudenata[student.BrIndeksa] = student;
                return true;
            }
            else
                return false;
        }

        static public bool DodajPredmetStudentu(string brojIndeksa, params string[] predmeti)
        {
            Student student;
            if (listaStudenata.TryGetValue(brojIndeksa, out student))
            {
                foreach (string s in predmeti)
                {
                    student.DodajPredmet(s);
                }
                return true;
            }
            return false;
        }

        static public bool ObrisiPredmetStudentu(string brojIndeksa, params string[] predmeti)
        {
            Student student;
            if (listaStudenata.TryGetValue(brojIndeksa, out student))
            {
                foreach (string s in predmeti)
                {
                    student.ObrisiPredmet(s);
                }
                return true;
            }
            return false;
        }

        static public Student PronadjiStudenta(string brIndeksa)
        {
            if (listaStudenata.ContainsKey(brIndeksa))
                return listaStudenata[brIndeksa];
            return null;
        }

        static public List<Student> StudentiPoPredmetu(string predmet)
        {
            List<Student> retList = new List<Student>();
            foreach (Student student in listaStudenata.Values)
            {
                if (student.ListaPredmeta.Contains(predmet))
                    retList.Add(student);
            }
            return retList;
        }

        static public List<Student> StudentiPoSmeru(Smer smer)
        {
            List<Student> retList = new List<Student>();
            foreach (KeyValuePair<string,Student> keyValuePair in listaStudenata)
            {
                if (keyValuePair.Value.Smer.Equals(smer))
                    retList.Add(keyValuePair.Value);
            }
            return retList;
        }

        static public List<Student> StudentiPoSmeruIPredmetu(Smer smer, string predmet)
        {
            List<Student> retList = new List<Student>();
            foreach (Student student in listaStudenata.Values)
            {
                if (student.ListaPredmeta.Contains(predmet) && student.Smer.Equals(smer))
                    retList.Add(student);
            }
            return retList;
        }

        static public List<Student> SviStudenti()
        {
            return listaStudenata.Values.ToList();
        }

    }
}
