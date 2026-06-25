using System;
using Dominio.Artista;

public class Musica : EntidadeBase<Musica>
{
    public string Titulo { get; set; }
    public string Album { get; set; }
    public decimal Duracao { get; set; }
    public int TotalOuvintes { get; set; }
    public Artista Artista { get; set; }
    public Musica()
    {

    }
    private static readonly Random random = new Random();

 

    public Musica(string titulo, string album, decimal totalOuvintes, Artista artista)
    {
        Titulo = titulo;
        Album = album;
        TotalOuvintes = 0;
        Artista = artista; 

        
        Duracao = Math.Round((decimal)(random.NextDouble() * 3 + 1), 2);
    }
}
/*	ID_MUSICA INT PRIMARY KEY AUTO_INCREMENT,
    TITULO VARCHAR(45),
    ALBUM VARCHAR(45),
    DURACAO DECIMAL(5,2),
    TOTAL_OUVINTES DECIMAL(10,2),
    ARTISTA_ID INT,
    FOREIGN KEY (ARTISTA_ID) REFERENCES ARTISTA(ID_ARTISTA)*/