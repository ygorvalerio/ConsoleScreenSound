Menu menu = new Menu();
OpcaoEscolhida opcao = new OpcaoEscolhida();

menu.LogoInicial();
menu.MenuOpções();

opcao.OpcaoEscolhidaNumerica(int.Parse(Console.ReadLine()!));


