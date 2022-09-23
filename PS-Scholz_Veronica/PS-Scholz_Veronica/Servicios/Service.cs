using PS_Scholz_Veronica._Command;
using PS_Scholz_Veronica._Query;
using PS_Scholz_Veronica.EnterData;
using PS_Scholz_Veronica.Entities;
using PS_Scholz_Veronica.Interfaces;
using PS_Scholz_Veronica.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_Scholz_Veronica.Servicios
{
    public class Service
    {
        private static readonly AppDbContext _context = new AppDbContext();
        public ICommandClient commandClient = new CommandClient(_context);
        public IQueryClient queryClient = new QueryClient(_context);
        public IQueryProduct queryProduct = new QueryProduct(_context);
        public IQueryCart queryCart = new QueryCart(_context);
        public ICommandCart commandCart = new CommandCart(_context);
        public ICommandCP commandCP = new CommandCP(_context);
        public IQueryCP queryCP = new QueryCP(_context);
        public ICommandOrder commandOrder = new CommandOrder(_context);
        public IQueryOrder queryOrder = new QueryOrder(_context);

        public void RegisterCliente()
        {
            var cli = ClientData.EnterClientData();
            commandClient.InsertClient(cli);
            int id = queryClient.GetIdbyClient(cli);
            //Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("Se ha registrado en el sistema con el ID: {0}", id);
        }
        
        public Carrito OpenCart (int clientId)
        {
            Carrito carro = new Carrito(clientId);
            Guid carritoId = queryCart.GetGuidbyCart(carro);
            commandCart.InsertCart(carro);
            return carro;
        }
        public decimal AddProductosToCart(Carrito carro)
        {
            string op = "1";
            decimal precio = 0;
            while (op == "1")
            {
                queryProduct.PrintAll();
                Console.WriteLine("\n       *Ingrese el ID del producto que desea comprar: ");
                int productId = queryProduct.EnterId(); //pide y busca

                var cp = new CarritoProducto(carro.CarritoId, productId, 1);
                
                //validar clave compuesta
                if (queryCP.Exists(cp))
                {
                    commandCP.UpdateCP(cp); //cdad ++
                }
                else
                {
                    commandCP.InsertCP(cp);
                }
                precio += queryProduct.GetPreciobyId(productId);

                Console.WriteLine(" ------------------------------------------------- ");
                Console.WriteLine("| Ingrese 1 para agregar mas productos al carrito:|");
                Console.WriteLine("|   (cualquier tecla para Finalizar la compra)    |");
                Console.WriteLine(" ------------------------------------------------- ");
                op = Console.ReadLine();
                Console.Clear();                
            }
            commandCart.StatusFalse(carro);

            Console.WriteLine("      -------------------------------------------");
            Console.WriteLine("     | Finalizo la carga de productos al carrito |");
            Console.WriteLine("      -------------------------------------------");
            return precio;
        }
       

        public Orden RegisterOrder(Carrito carro, int clientId, decimal monto)
        {
            //Guid carritoId = queryCart.GetGuidbyCart(carro);
            //commandCart.InsertCart(carro);

            Orden o = new Orden(carro.CarritoId, monto);
            commandOrder.InsertOrder(o);//bd
            return o;
        }
        public void UpdateOrder(Guid orderId, decimal monto)
        {
            var o = queryOrder.GetOrderbyId(orderId); 
            o.Total += monto;
            return;
        }
    }
}
