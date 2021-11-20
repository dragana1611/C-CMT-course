using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z3___Kriptografija
{
    class Program
    {
        static void Main(string[] args)
        {
            KriptoPoruka kp = new KriptoPoruka("Moja 1. poruka se NALAZI bas ovde!!!");
            kp.IspisiPorukuITip();
            kp.KriptoDekripto();
            kp.IspisiPorukuITip();
            kp.KriptoDekripto();
            kp.IspisiPorukuITip();
            Console.ReadKey();

        }
    }
}
