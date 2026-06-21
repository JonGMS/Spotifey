using MySql.Data.MySqlClient;
namespace Infra;
public class Conexao
{
    //instalacao Ado.Net: F1, Add NuGet Package, Selecionar Projeto(Infra), Pesquisar por MySql.Data, Instalar
    private string stringConexao = "server=localhost;port=3306;database=projetofinal;uid=root;pwd=toor;";
    public MySqlConnection ObterConexao()
    {
        MySqlConnection conexao = new MySqlConnection(stringConexao);
        try{
            conexao = new MySqlConnection(stringConexao);
            return new MySqlConnection(stringConexao);
        }
        catch(MySqlException e){
            Console.WriteLine("Erro ao conectar ao banco de dados: " + e.Message);
            return null!;
        }
    }
}