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
using System.Threading;

var service = new Service();
var mainMenu = new MainMenu(service);
bool view = true;

do
{
    mainMenu.ShowMenu();
    view = mainMenu.ChooseOpt(mainMenu.InsertOption(-1));
}
while (view);