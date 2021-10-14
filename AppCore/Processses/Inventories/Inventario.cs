using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;
using Domain.Entities;

namespace AppCore.Processses.Inventories
{
    public class Inventario
    {
        //private static decimal saldo;
        public int CalcularExist(IProductoService inv)
        {
            if (inv is null)
            {
                throw new ArgumentNullException(nameof(inv));
            }
            int exist=0;
            foreach (Producto p in inv.FindAll())
            {
                exist += p.Existencia;
            }
            return exist;
        }
    }
}
