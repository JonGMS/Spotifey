
namespace Apresentacao.ControladorArtista;

using System.Runtime.InteropServices;
using Aplicacao.Artista;
using Dominio.ModuloArtista;


public class ControladorArtista : ControladorBase
{
    private readonly ServicoArtista servicoArtista;
    private IRepositorioArtista repositorioArtista;
    public ControladorArtista(IRepositorioArtista repositorioArtista, ServicoArtista servicoArtista)
    {
        this.repositorioArtista = repositorioArtista;
        this.servicoArtista = servicoArtista;
    }
    public override void Inserir()
    {
        Console.Clear();
        Menu.ApresentarTitulo("Cadastrar-se como Artista");

        FormArtista formulario = new FormArtista();

        formulario.Artista = FormArtista.FormularioArtista();
        Menu.Notificacao(servicoArtista.Inserir(formulario.Artista), ConsoleColor.DarkYellow);

    }
    public override void Editar()
    {
        
    }
    public override void Excluir()
    {
        
    }

    
}