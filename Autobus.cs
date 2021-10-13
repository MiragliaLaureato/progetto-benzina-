using progetto_benzina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotori
{
    public class Autobus : IVeicolo<ICarburante>
    {
        public string Nome;
        public List<ICarburante> tipo;

        public Autobus(string nome, ICarburante motore)
        {
            Nome = nome;
            tipo = new List<ICarburante>();
            tipo.Add(motore); 
        }

        public Autobus(string nome, ICarburante motore1, ICarburante motore2)
        {
            Nome = nome;
            tipo = new List<ICarburante>();
            tipo.Add(motore1);
            tipo.Add(motore2);

        }




        public void faiPieno(ICarburante c)
        {
            int tmp = 0;

            Type tipoInput = c.GetType();

            for (int i=0; i< tipo.Count; i++)
            {
                Type tipoBus = tipo[i].GetType();

                if ((tipoInput == tipoBus) && tmp == 0)
                {
                    tmp = 1; 
                }
            }
            if (tmp == 0)
            {
                Console.WriteLine($" è possibile fare il pieno");
            }
            else
            {
                Console.WriteLine($" non è possibile far il pieno ");
            }
        }


        public ICarburante getMotore()
        {
            return tipo[0];
        }

        public string getNomeAuto()
        {
            return Nome;
        }
    }
}

}
