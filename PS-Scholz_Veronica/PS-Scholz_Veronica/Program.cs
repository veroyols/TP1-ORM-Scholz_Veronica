// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using PS_Scholz_Veronica._Command;
using PS_Scholz_Veronica._Query;
using PS_Scholz_Veronica.Entities;
using PS_Scholz_Veronica.Interfaces;
using PS_Scholz_Veronica.Menu;
using PS_Scholz_Veronica.Persistence;
using PS_Scholz_Veronica.Servicios;
using System.Security.Cryptography;

var service = new Service();
var mainMenu = new MainMenu(service);
bool view = true;

do
{
    mainMenu.ShowMenu();
    view = mainMenu.ChooseOpt(mainMenu.InsertOption(-1));
}
while (view);

//Guid g = Guid.NewGuid();
//Carrito c = new Carrito(g, 1, true);
//Console.WriteLine(c.Estado);
//service.commandCart.InsertCart(c);
//service.commandCart.StatusFalse(g);
//Console.WriteLine(c.Estado);



//AppDbContext _context = new AppDbContext();
//var m = _context.OrdenDb.Include(x => x.Carrito).ThenInclude(x => x.CarritoProducto).ToList();
//var li = _context.CarritoProductoDb.Include(x => x.Carrito);

//Console.WriteLine("Lista de clientes en tabla");
//var lista = _context.CarritoDb.Include(x => x.Cliente).ToList();
//Console.WriteLine(lista);

//Console.WriteLine("lista de productos en tabla carritoproducto");
//var list = _context.CarritoProductoDb.Include(x => x.Producto).ToList();
//foreach (var item in list)
//    Console.WriteLine(item.ProductoId + ", " + item.Cantidad + ", " + item.CarritoId);


//falta validar el state
//if (service.queryCart.State(carro))
//{
//Console.WriteLine("Recupera el carrito de state True");
//var ca = service.queryCart.GetCartbyClientId(clientId);
//}
//else
//{
//    Console.WriteLine("insertar nuevo carrito");
//    service.commandCarrito.InsertCarrito(clienteId);
//}


