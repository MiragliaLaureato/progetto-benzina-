using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto_benzina
{
    public class Benzina : ICarburante
    {
        public string Nome;
        public double Prezzo;

        public Benzina(string nome, double prezzo)
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
