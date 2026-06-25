public class ServicoUsuario
{
    private IRepositorioUsuario repositorioUsuario;
    public string Inserir(Usuario usuario)
    {
        try
        {
            repositorioUsuario.Inserir(usuario);
            return "Você foi Cadastrado com Sucesso!";
        }
        catch(Exception e)
        {
            string mensagem = e.Message;
            return mensagem;
        }
    }

        public string Login(Usuario usuario)
    {
        try
        {
            repositorioUsuario.Login(usuario);
            return "Você foi Cadastrado com Sucesso!";
        }
        catch(Exception e)
        {
            string mensagem = e.Message;
            return mensagem;
        }
    }
}