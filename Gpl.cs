using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto_benzina
{
    public class Gpl : ICarburante
    {
        public string Nome;
        public double Prezzo;

        public Gpl(string nome, double prezzo)
        {
            Nome = nome;
            Prezzo = prezzo;
        }

        public string getNome()
        {
            return Nome;
        }

        public double getPrezzo()
        {
            return Prezzo;
        }
    }
}
