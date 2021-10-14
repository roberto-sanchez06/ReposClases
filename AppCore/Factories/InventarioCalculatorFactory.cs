using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Processses.Inventories;
using Domain.Enums;

namespace AppCore.Factories
{
    public class InventarioCalculatorFactory
    {
        ICalculadorInventario CreateInstance(ValoracionInventario vi)
        {
            switch (vi)
            {
                case ValoracionInventario.UEPS:
                    return new MetodoUEPS();
                case ValoracionInventario.PEPS:
                    return new MetodoPEPS();
                case ValoracionInventario.PromedioPonderado:
                    return new MetodoPromPonderado();
                case ValoracionInventario.PromedioSimple:
                    return new MetodoPromSimple();
                default:
                    throw new ArgumentException();
            }
        }
    }
}
