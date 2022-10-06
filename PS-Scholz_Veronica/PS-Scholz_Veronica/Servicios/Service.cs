using PS_Scholz_Veronica._Command;
using PS_Scholz_Veronica._Query;
using PS_Scholz_Veronica.EnterData;
using PS_Scholz_Veronica.Entities;
using PS_Scholz_Veronica.Interfaces;
using PS_Scholz_Veronica.Model;
using PS_Scholz_Veronica.Persistence;

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

        public int RegisterCliente()
        {
            var cli = ClientData.EnterClientData();
            commandClient.InsertClient(cli);
            return queryClient.GetIdbyClient(cli);
        }

        public Carrito OpenCart(int clientId)
        {
            Carrito carro = new Carrito(clientId);
            Guid carritoId = queryCart.GetGuidbyCart(carro);
            commandCart.InsertCart(carro);
            return carro;
        }

        public List<Producto> GetProducts()
        {
            return queryProduct.GetAll();
        }

        public decimal GetPreciobyProductId(int productId)
        {
            return queryProduct.GetPreciobyId(productId);
        }

        public void EndSale(Carrito carrito)
        {
            commandCart.StatusFalse(carrito);
        }

        public void ValidarCarritoProducto(CarritoProducto cp, int cdad)
        {
            if (queryCP.Exists(cp))
            {
                commandCP.UpdateCP(cp, cdad);
            }
            else
            {
                commandCP.InsertCP(cp);
            }
        }

        public Orden RegisterOrder(Carrito carro, int clientId, decimal monto)
        {
            Orden o = new Orden(carro.CarritoId, monto);
            commandOrder.InsertOrder(o);
            return o;
        }

        public void UpdateOrder(Guid orderId, decimal monto)
        {
            var o = queryOrder.GetOrderbyId(orderId);
            o.Total += monto;
        }

        public List<Orden> GetOrderToday()
        {
            return queryOrder.GetToday();
        }

        public Cliente GetClientByOrder(Guid carritoId)
        {
            int clientId = queryCart.GetClientIdbyCarritoId(carritoId);
            return queryClient.GetClientbyId(clientId);
        }

        public List<ProductoCantidad> GetProductoCantidad(Guid carritoId)
        {
            List<ProductoCantidad> lista = new List<ProductoCantidad>();
            List<Producto> products = queryCP.GetProductoByCarrito(carritoId);
            int[] cdad = queryCP.GetCdadProductoByCarrito(carritoId);
            int i = 0;
            foreach (var item in products)
            {
                lista.Add(new ProductoCantidad(item, cdad[i]));
                i++;
            }
            return lista;
        }

        public List<ProductSold> GetProductSold(int productId)
        {
            List<ProductSold> listProductSold = new List<ProductSold>();
            List<CarritoProducto> carritosConProd = queryCP.GetCPByProductId(productId);
            foreach (var item in carritosConProd)
            {
                int clientId = queryCart.GetClientIdbyCarritoId(item.CarritoId);
                Cliente cli = queryClient.GetClientbyId(clientId);
                listProductSold.Add(new ProductSold
                {
                    clientName = cli.Nombre,
                    clientLastName = cli.Apellido,
                    amount = item.Cantidad,
                    date = queryOrder.GetDateByCartId(item.CarritoId)
                });
            }
            return listProductSold;
        }

        public Producto GetProductById(int id)
        {
            return queryProduct.GetProductbyId(id);
        }
    }
}
