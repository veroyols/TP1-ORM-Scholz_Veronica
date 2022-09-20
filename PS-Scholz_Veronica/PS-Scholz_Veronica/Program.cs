// See https://aka.ms/new-console-template for more information
using PS_Scholz_Veronica.Entities;
using PS_Scholz_Veronica.Menu;
using PS_Scholz_Veronica.Persistence;
using PS_Scholz_Veronica.Services;

Console.WriteLine("Hello, World!");

//using (var context = new AppDbContext())
//    {

//        var cli = new Cliente()
//        {
//            Nombre = "Bill"
//        };

//        context.ClienteDb.Add(cli);
//        context.SaveChanges();
//    }

    var mainMenu = new MainMenu();
    bool view = true;

    do
    {
        mainMenu.ShowMenu();
        int opt = mainMenu.InsertOption(0);
        view = mainMenu.ChooseOpt(opt);
    }
    while (view);
