// See https://aka.ms/new-console-template for more information
using PS_Scholz_Veronica.Menu;

Console.WriteLine("Hello, World!");

var mainMenu = new MainMenu();
bool view = true;

do
{
    mainMenu.ShowMenu();
    int opt = mainMenu.InsertOption(0);
    view = mainMenu.ChooseOpt(opt);
}
while (view);