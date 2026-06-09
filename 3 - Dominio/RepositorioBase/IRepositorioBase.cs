namespace Dominio.RepositorioBase;
public interface IRepositorioBase<T>
{
    void Inserir(){}
    void Editar(int id){}
    void Listar(){}
    void Excluir(int id){}
}