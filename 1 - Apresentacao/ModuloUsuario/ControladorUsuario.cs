public class ControladorUsuario : ControladorLogin
{

    public readonly ServicoUsuario servicoUsuario;


    public override void Inserir()
    {
        FormUsuario formulario = new FormUsuario();

        formulario.Usuario = FormUsuario.FormularioUsuario();

        Menu.Notificacao(servicoUsuario.Inserir(formulario.Usuario), ConsoleColor.DarkYellow);
    }
    public override void Login()
    {
        FormUsuario formulario = new FormUsuario();

        formulario.Usuario = FormUsuario.FormularioUsuario();

        Menu.Notificacao(servicoUsuario.Login(formulario.Usuario), ConsoleColor.DarkYellow);
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