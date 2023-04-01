using Application;
using Application.Interfaces;
using Infrastructure.cqrs_Query;
using Microsoft.EntityFrameworkCore;
using TP1_ORM_Scholz_Veronica.Menu;

Console.WriteLine("Hello, World!");

IQueryMercaderia queryMercaderia = new QueryMercaderia();
IQueryTipoMercaderia queryTipoMercaderia = new QueryTipoMercaderia();
var services = new Services(queryMercaderia, queryTipoMercaderia);
var mainMenu = new MainMenu(services); 
bool view = true;

do
{
    mainMenu.ShowMenu();
    view = mainMenu.ChooseOpt(mainMenu.InsertOption(-1));
}
while (view);