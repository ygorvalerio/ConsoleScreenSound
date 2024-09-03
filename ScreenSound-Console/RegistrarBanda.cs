class RegistrarBanda

{

    Menu menu = new Menu();
    public void RegistrarBandas()
    {
        Console.Clear();
        Console.WriteLine("Registro de Banda");
        Console.Write("Digite o nome da banda: ");
        string NomeDaBanda = Console.ReadLine()!;
        Console.WriteLine($"A Banda {NomeDaBanda} foi registrado com sucesso");
        Thread.Sleep( 2000 );
        Console.Clear() ;
        menu.LogoInicial();
        menu.MenuOpcoes();
        

    }
}