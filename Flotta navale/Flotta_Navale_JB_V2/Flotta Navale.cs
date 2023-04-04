using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flotta_Navale_JB
{
    class Flotta_Navale
    {
        string _flotta;
        string _armatore;
        string _sede;
        List<Nave> _navi;
        List<Comandante> _comandanti;

        public Flotta_Navale()
        {

        }

        public Flotta_Navale(string flotta, string armatore, string sede, List<Nave> navi, List<Comandante> comandanti)
        {
            Flotta = flotta;
            Armatore = armatore;
            Sede = sede;
            Navi = navi;
            Comandanti = comandanti;
        }

        public string Flotta { get => _flotta; set => _flotta = value; }
        public string Armatore { get => _armatore; set => _armatore = value; }
        public string Sede { get => _sede; set => _sede = value; }
        internal List<Nave> Navi { get => _navi; set => _navi = value; }
        internal List<Comandante> Comandanti { get => _comandanti; set => _comandanti = value; }
    }
}
