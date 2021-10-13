using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto_benzina
{
    public class Gasolio : ICarburante
    {
        public string Nome;
        public double Prezzo;
        public string Produttore;

        public Gasolio(string nome, double prezzo, string produttore)
        {
            Nome = nome;
            Prezzo = prezzo;
            Produttore = produttore;

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
