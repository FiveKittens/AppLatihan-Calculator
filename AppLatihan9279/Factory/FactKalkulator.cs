using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihan9279.Factory
{
    class FactKalkulator
    {
        private static Interface.IntKalkulator kalkulatorDao;

        public static Interface.IntKalkulator GetKalkulatorDao()
        {
            kalkulatorDao = new Implement.ImpKalkulator();
            return kalkulatorDao;
        }
    }
}
