using progetto_benzina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotori
{
    public class Auto : IVeicolo<ICarburante>  
    {
        public string Nome;
        public ICarburante tipo;
       
        public Auto(string nome, ICarburante motore)
        {
            Nome = nome;
            tipo = motore;
            
        }



        public void faiPieno(ICarburante c)
        {
            if (c.GetType() == tipo.GetType())
            {
                Console.WriteLine($" prodotto CORRETTO ");
            }
            else 
            {
                Console.WriteLine($" prodotto NON CORRETTO --- errore ");
            }
        }

        
        public ICarburante getMotore()
        {
            return tipo;
        }

        public string getNomeAuto()
        {
            return Nome; 
        }
    }
}
