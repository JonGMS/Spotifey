namespace Dominio.Usuario;
public class Usuario : IRepositorioUsuario
{
    private int Id_usuario {get; set;}
    private string Nome_usuario {get; set;}
    private string Bio {get; set;}
    public Usuario(int id_usuario, string nome_usuario, string bio)
    {
        List<Usuario> usuarios = new List<Usuario>();
        Id_usuario = id_usuario++;
        Nome_usuario = nome_usuario;
        Bio = bio;
        usuarios.Add(new Usuario(id_usuario, nome_usuario, bio));
    }
}