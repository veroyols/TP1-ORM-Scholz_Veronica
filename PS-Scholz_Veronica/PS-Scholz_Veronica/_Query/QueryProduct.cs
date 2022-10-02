using Microsoft.EntityFrameworkCore;
using PS_Scholz_Veronica.Entities;
using PS_Scholz_Veronica.Interfaces;
using PS_Scholz_Veronica.Persistence;
using PS_Scholz_Veronica.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_Scholz_Veronica._Query
{
    public class QueryProduct : IQueryProduct
    {
        private readonly AppDbContext _context;

        public QueryProduct(AppDbContext context)
        {
            _context = context;
        }

        public Producto GetProductbyId(int id)
        {
            var p = _context.ProductoDb.FirstOrDefault<Producto>(p => p.ProductoId == id);
            return p;
        }
        public decimal GetPreciobyId(int id)
        {
            var p = _context.ProductoDb.FirstOrDefault<Producto>(p => p.ProductoId == id);
            return p.Precio;
        }
        public int CountAll()
        {
            return _context.ProductoDb.Count();
        }
        public List<Producto> GetAll()
        {
            var p = _context.ProductoDb.ToList<Producto>();
            return p;
        }
        public void Print(int id)
        {
            var p = GetProductbyId(id);
            Print(p);
            return;
        }
        public void Print(Producto p)
        {
            Console.WriteLine("     Id: {0} -> *{1} ({2}): ${3}", p.ProductoId, p.Nombre, p.Marca, p.Precio);
            return;
        }
        public void PrintAll()
        {
            Console.WriteLine("Disponibles: {0} productos. \nDetalle:", CountAll());
            List<Producto> lp = GetAll();
            foreach (Producto p in lp)
                Console.WriteLine("     Id: {0} -> *{1} ({2}): ${3}", p.ProductoId, p.Nombre, p.Marca, p.Precio);
            return;
        }

        public int EnterId()
        {
            bool m = true;
            int productId = new int();
            while (m)
            {
                try
                {
                    productId = int.Parse(Console.ReadLine());
                    GetProductbyId(productId);
                    m = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("No se ha encontrado producto con ese ID, intente con otro.");
                }
            }
            return productId;
        }
    }
}
