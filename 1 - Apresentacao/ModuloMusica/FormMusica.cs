public class FormMusica
{
    public Musica musica;
    public Musica Musica
    {
        get => musica; set;
    }

    public static void SubMenuMusica()
    {
        Console.Clear();

        Menu.ApresentarTitulo("- Musica");

        Menu.Notificacao("[1]", ConsoleColor.DarkGreen); Console.WriteLine(" - Musicas"); // 
        Menu.Notificacao("[2]", ConsoleColor.DarkGreen); Console.WriteLine(" - Postar Musica");// Se o Usuario for Artista as opções do 2 até o 4 
        Menu.Notificacao("[3]", ConsoleColor.DarkGreen); Console.WriteLine(" - Editar Musica");//vao aparecer, se não só as recomendações.
        Menu.Notificacao("[4]", ConsoleColor.DarkGreen); Console.WriteLine(" - Excluir Musica");
    }
    public static Musica FormularioMusica()
    {
        Musica musica = new();

        musica.Titulo = Console.ReadLine();

        musica.Album = Console.ReadLine();

        return musica;
    }
}