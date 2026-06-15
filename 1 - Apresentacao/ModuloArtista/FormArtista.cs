using Dominio.Artista;
public class FormArtista
{
    private Artista artista;
    public Artista Artista
    {
        get => artista; set;
    }
    
    public static Artista FormularioArtista()
    {
        var artista = new Artista();
        artista.Nome = Console.ReadLine();


        artista.Bio = Console.ReadLine();

        return artista;
    }

}