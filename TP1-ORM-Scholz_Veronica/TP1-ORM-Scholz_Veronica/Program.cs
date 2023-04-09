using TP1_ORM_Scholz_Veronica.Create; 
using TP1_ORM_Scholz_Veronica.Menu;

Console.ForegroundColor = ConsoleColor.DarkYellow;

AllServices services = new (); //crea servicios en la capa superior
MainMenu mainMenu = new (services); 
bool view = true;

do
{
    mainMenu.ShowMenu();
    view = mainMenu.ChooseOpt(mainMenu.InsertOption(-1));
}
while (view);