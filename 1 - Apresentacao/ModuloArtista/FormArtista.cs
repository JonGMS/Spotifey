using Dominio.Artista;
public class FormArtista
{
    private Artista artista;
    public Artista Artista
    {
        get => artista; set;
    }

    public static void SubMenuArtista()
    {
        Console.Clear();

        Menu.ApresentarTitulo("- Musica");

        Menu.Notificacao("[1]", ConsoleColor.DarkGreen); Console.WriteLine(" - Artistas"); 
        Menu.Notificacao("[2]", ConsoleColor.DarkGreen); Console.WriteLine(" - Configurar Perfil Artista");
    }
    public static Artista FormularioArtista()
    {
        var artista = new Artista();
        artista.Nome = Console.ReadLine();


        artista.Bio = Console.ReadLine();

        return artista;
    }

}