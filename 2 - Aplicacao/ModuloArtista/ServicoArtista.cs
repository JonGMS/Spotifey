namespace Aplicacao.Artista;

using Dominio.ModuloArtista;
using Dominio.Artista;
using Dominio.RepositorioBase;

public class ServicoArtista
{
    private readonly IRepositorioArtista repositorioArtista;

    public ServicoArtista(IRepositorioArtista repositorioArtista)
    {
        this.repositorioArtista = repositorioArtista;
    }

    public string Inserir(Artista artista)
    {
        try
        {
            repositorioArtista.Inserir(artista);
            return "Artista cadastrado com sucesso!";
        }
        catch(Exception e)
        {
            string mensagem = e.Message;
            return mensagem;
        }


    }
}
