public class FormUsuario
{
    public Usuario usuario;
    public Usuario Usuario
    {
        get => usuario; set;
    }
    public static Usuario FormularioUsuario()
    {
        string username = Console.ReadLine();

        Usuario usuario = new Usuario { Username = username};

        usuario.Password = Console.ReadLine();

        return usuario;
    }
}