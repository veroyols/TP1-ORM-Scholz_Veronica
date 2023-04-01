using TP1_ORM_Scholz_Veronica.Create; //crea servicios en la capa superior
using TP1_ORM_Scholz_Veronica.Menu;

Console.WriteLine("Hello, World!");

var services = new AllServices();
var mainMenu = new MainMenu(services); 
bool view = true;

do
{
    mainMenu.ShowMenu();
    view = mainMenu.ChooseOpt(mainMenu.InsertOption(-1));
}
while (view);