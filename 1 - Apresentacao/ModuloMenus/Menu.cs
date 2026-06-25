class Menu
{
    public static void Notificacao(string text, ConsoleColor cor)
    {
        Console.ForegroundColor = cor;
        Console.Write(text);
        Console.ResetColor();
    }
    public static void ApresentarTitulo(string subtitulo)
    {
        Console.WriteLine("=====================================");
        Notificacao("              Spotfey         ", ConsoleColor.DarkGreen); Notificacao(subtitulo, ConsoleColor.DarkGray);
        Console.WriteLine("\n=====================================");
    }
    public static bool Login()
    {
        Notificacao("BEM VINDO", ConsoleColor.Green); Console.WriteLine("- Já possui uma conta?\n");

        Notificacao("[1]", ConsoleColor.DarkGreen); Console.WriteLine(" - Login");
        Notificacao("[2]", ConsoleColor.DarkGreen); Console.WriteLine(" - Cadastrar-se");

        try
        {

            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                ControladorUsuario controladorUsuario = new ControladorUsuario();

                controladorUsuario.Login();

                return true;
            }
            else if (opcao == "2")
            {

                ControladorUsuario controladorUsuario = new ControladorUsuario();

                controladorUsuario.Inserir();

                return true;

            }
            else
            {
                return false;
            }

        }
        catch
        {
            return false;
        }


    }

    public static void TelaInicial()
    {
        bool servico = true;
        while (servico)
        {
            ApresentarTitulo(" - Menu Principal");

            Notificacao("[1]", ConsoleColor.DarkGreen); Console.WriteLine(" - Musicas");
            Notificacao("[2]", ConsoleColor.DarkGreen); Console.WriteLine(" - Artista");
            Notificacao("[3]", ConsoleColor.DarkGreen); Console.WriteLine(" - Planos");


            try
            {

                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    FormMusica formMusica = new FormMusica();

                    FormMusica.SubMenuMusica();

                }
                else if (opcao == "2")
                {

                    FormArtista formArtista = new FormArtista();

                    FormArtista.SubMenuArtista();

                }
                else if (opcao == "2")
                {

                    FormPlano FormPlano = new FormPlano();

                    FormPlano.SubMenuPlanos();//Adicionar planos enum no Usuario.

                }
                else if(opcao == "0")
                {
                    servico = false;

                    Notificacao("Até a próxima!", ConsoleColor.DarkGreen);

                    continue;
                }
                else
                {
                    Console.Clear();
                    Notificacao("Opção Inválida! Tente novamenete.", ConsoleColor.Red);
                }
            }
            catch
            {

            }

        }

    }
}