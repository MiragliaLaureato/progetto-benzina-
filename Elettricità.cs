using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto_benzina
{
    public class Elettricità : ICarburante
    {
        public string Nome;
        public double Prezzo;
        public double Watt; 

        public Elettricità(string nome, double prezzo, double watt)
        {
            Nome = nome;
            Prezzo = prezzo;
            Watt = watt;
        }

        public string getNome()
        {
            return Nome;
        }
        public double getPrezzo()
        {
            return Prezzo; 
        }
        
        public double getWatt(){
            return watt; 
     }
}
