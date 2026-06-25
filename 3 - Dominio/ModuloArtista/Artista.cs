using System.Numerics;
using Dominio.ModuloArtista;
namespace Dominio.Artista;

public class Artista : EntidadeBase<Artista>
{
    public int UsuarioId { get; private set; }
    public Usuario Usuario { get; private set; }
    public string Nome { get; set; } = string.Empty;
    public string Bio { get; set; } = string.Empty;

    public Artista()
    {

    }
    public Artista(string nome, string bio)
    {
        Nome = nome;
        Bio = bio;

    }
}
