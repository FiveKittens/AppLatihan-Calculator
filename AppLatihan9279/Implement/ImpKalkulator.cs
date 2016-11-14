using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihan9279.Implement
{
    class ImpKalkulator : Interface.IntKalkulator
    {
        public double Penjumlahan(Entity.EntKalkulator e)
        {
            return (e.getNilai1() + e.getNilai2());
        }

        public double Pengurangan(Entity.EntKalkulator e)
        {
            return (e.getNilai1() - e.getNilai2());
        }

        public double Perkalian(Entity.EntKalkulator e)
        {
            return (e.getNilai1() * e.getNilai2());
        }

        public double Pembagian(Entity.EntKalkulator e)
        {
            return (e.getNilai1() / e.getNilai2());
        }


    }
}
