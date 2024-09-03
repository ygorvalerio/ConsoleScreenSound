Menu menu = new Menu();
OpcaoEscolhida opcao = new OpcaoEscolhida();


menu.LogoInicial();
menu.MenuOpcoes();


opcao.OpcaoEscolhidaNumerica(int.Parse(Console.ReadLine()!));


