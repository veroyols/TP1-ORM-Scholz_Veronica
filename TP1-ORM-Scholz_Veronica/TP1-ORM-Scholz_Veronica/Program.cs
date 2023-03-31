using TP1_ORM_Scholz_Veronica.Menu;

Console.WriteLine("Hello, World!");

var mainMenu = new MainMenu();
bool view = true;

do
{
    mainMenu.ShowMenu();
    view = mainMenu.ChooseOpt(mainMenu.InsertOption(-1));
}
while (view);