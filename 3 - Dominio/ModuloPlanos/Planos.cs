namespace Dominio.ModuloPlano;

public class Plano : EntidadeBase<Plano>
{
    public TipoAssinatura Tipo { get; set; }

    public decimal Valor { get; set; }

    public int TempoMeses { get; set; }

    public Plano(TipoAssinatura tipo, decimal valor, int tempo)
    {
        Tipo = tipo;
        Valor = valor;
        TempoMeses = tempo;
    }
    public static readonly Plano Indivivual = new(TipoAssinatura.Individual, 23.90m, 1);
    public static readonly Plano Duo = new(TipoAssinatura.Duo, 31.90m, 12);
    public static readonly Plano Familia = new(TipoAssinatura.Familia, 40.90m, 1);
    public static readonly Plano Universitario = new(TipoAssinatura.Universidade, 12.90m, 12);

}


public enum TipoAssinatura
{
    Free,
    Individual,
    Duo,
    Familia,
    Universidade
}

