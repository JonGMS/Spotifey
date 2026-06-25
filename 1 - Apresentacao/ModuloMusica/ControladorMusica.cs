public class ControladorMusica : ControladorBase
{
    private readonly ServicoMusica servicoMusica;
    public override void Inserir()
    {
        Console.Clear();
        
        Menu.ApresentarTitulo("Cadastro de Musica");

        FormMusica formulario = new FormMusica();

        Menu.Notificacao(servicoMusica.Inserir(formulario.Musica = FormMusica.FormularioMusica()), ConsoleColor.DarkYellow);;
    }
    public override void Editar()
    {
        throw new NotImplementedException();
    }
    public override void Excluir()
    {
        throw new NotImplementedException();
    }
}