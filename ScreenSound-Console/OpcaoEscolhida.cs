class OpcaoEscolhida
{
    public int Opcao { get; }

    public void OpcaoEscolhidaNumerica(int opcao)

    {
        
            if (opcao == 0)
            {
                Environment.Exit(0); // Fecha o console se a opção for 0
            }


        
        if (opcao == 1) 
            {
            Console.WriteLine("Opção 1 escolhida");
        }
    }

}
