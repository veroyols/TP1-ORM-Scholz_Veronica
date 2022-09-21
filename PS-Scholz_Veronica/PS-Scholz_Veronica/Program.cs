// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using PS_Scholz_Veronica._Command;
using PS_Scholz_Veronica.Entities;
using PS_Scholz_Veronica.Menu;
using PS_Scholz_Veronica.Persistence;
using PS_Scholz_Veronica.Servicios;

var service = new Service();
var mainMenu = new MainMenu(service);
bool view = true;

do
{
    mainMenu.ShowMenu();
    view = mainMenu.ChooseOpt(mainMenu.InsertOption(-1));
}
while (view);

Carrito carro = new Carrito(2);
AppDbContext context = new AppDbContext();
context.CarritoDb.Add(carro);
context.SaveChanges();
var a = context.CarritoDb.Include(x => x.Cliente).ToList();
Console.WriteLine(a);
foreach (var item in a)
    Console.WriteLine(item);
