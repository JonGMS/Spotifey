using Dominio.RepositorioBase;

public interface IRepositorioUsuario : IRepositorioBase<Usuario>
{
    void Login(Usuario entidade){}
}