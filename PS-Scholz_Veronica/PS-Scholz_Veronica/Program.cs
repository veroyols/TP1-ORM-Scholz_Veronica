using PS_Scholz_Veronica.Menu;
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

//Console.WriteLine("Hola, mi nombre es juana");
//Console.ReadKey(true);
//Console.WriteLine("Vos como te llamas?");
//string unNombre = Console.ReadLine();
//Console.WriteLine("Hola " + unNombre + ". Que lindo leerte.");