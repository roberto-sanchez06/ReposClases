using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;
using Domain.Interfaces;

namespace AppCore.Processses.Inventories
{
    public interface IValoradorInventario
    {
        decimal ValorarInventario(IProductoService inventario);
    }
}
