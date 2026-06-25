public class ServicoMusica
{
    private IRepositorioMusica repositorioMusica;
    public string Inserir(Musica musica)
    {
        try
        {
            repositorioMusica.Inserir(musica);
            return "Musica Cadastrada com Sucesso!";
        }
        catch(Exception e)
        {
            string mensagem = e.Message;
            return mensagem;
        }
    }
}