using progetto_benzina;
using System;

namespace Automotori
{
    public interface IVeicolo<T> where T: ICarburante
    {
        string getNomeAuto();

        ICarburante getMotore();

        void faiPieno(T prodotto);

        

    }
}
