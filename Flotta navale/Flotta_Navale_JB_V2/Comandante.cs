using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flotta_Navale_JB
{
    enum StatoComandante
    {
        Servizio,
        Pensione,
        Licenziato
    }
    class Comandante
    {
        string _nome;
        DateTime _dataNascita;
        string _telefono;
        StatoComandante _stato;

        public Comandante()
        {

        }
        public Comandante(string nome, string telefono, DateTime dataNascita, StatoComandante stato)
        {
            if (nome.Length <= 20 && telefono.Length == 10)
            {
                Nome = nome;
                DataNascita = dataNascita;
                Telefono = telefono;
                Stato = stato;
            }
            else
            {
                throw new Exception();
            }
        }

        public string Nome { get => _nome; set => _nome = value; }
        public DateTime DataNascita { get => _dataNascita; set => _dataNascita = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        internal StatoComandante Stato { get => _stato; set => _stato = value; }
    }
}
