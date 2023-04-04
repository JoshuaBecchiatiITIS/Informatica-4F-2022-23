using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flotta_Navale_JB
{
    enum StatoNave
    {
        Cantiere,
        Varata,
        Demolita
    }
    class Nave
    {
        string _nome;
        string _stazza;
        string _velocita;
        StatoNave _stato;
        public Nave()
        {

        }
        public Nave(string nome, string stazza, string velocita, StatoNave stato)
        {
            if (nome.Length <= 20 && stazza.Length <= 4 && velocita.Length <= 3)
            {
                Nome = nome;
                Stazza = stazza;
                Velocita = velocita;
                Stato = stato;
            }
            else
            {
                throw new Exception();
            }
        }

        public string Nome { get => _nome; set => _nome = value; }
        public string Stazza { get => _stazza; set => _stazza = value; }
        public string Velocita { get => _velocita; set => _velocita = value; }
        internal StatoNave Stato { get => _stato; set => _stato = value; }
    }
}
