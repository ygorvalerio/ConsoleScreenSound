class OpcaoEscolhida
{
    RegistrarBanda banda = new RegistrarBanda();
    public int Opcao { get; }

    public void OpcaoEscolhidaNumerica(int opcao)

    {

        switch (opcao)
        {
            case 1: banda.RegistrarBandas();
                
                break;
            case 2:
                Console.WriteLine("\nVocê escolheu a opção 2");
                break;
            case 3:
                Console.WriteLine("\nVocê escolheu a opção 3");
                break;
            case 4:
                Console.WriteLine("\nVocê escolheu a opção 4");
                break;
            case 5:
                Console.WriteLine("\nVocê escolheu a opção 5");
                break;


            default:
                Console.WriteLine("\nOpção invalida!");
                break;
        }

    }
}
