using Infra;
using MySql.Data.MySqlClient;

class RepositorioUsuario
{
    MySqlConnection conexao = new Conexao().ObterConexao();

    // Cadastro de Usuário. Falta integrar no Menu.
    public void CadastrarUsuario(Usuario usuario)
    {
        try
        {
            conexao.Open();
            string sql = "INSERT INTO USUARIO(NOME_USUARIO, BIO) VALUES(@nome_usuario, @bio);";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@nome_usuario", usuario.Username);
            comando.Parameters.AddWithValue("@bio", usuario.Bio);
            comando.ExecuteNonQuery();
            Console.WriteLine("Usuário criado com sucesso!");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);   
        }
        finally
        {
            conexao.Close();
        }
    }
    // Listar Músicas. O usuário poderá listar todas as músicas. Falta integrar com o menu.
    public void ListarMusicas()
    {
        try
        {
            conexao.Open();
            string sql = "SELECT * FROM MUSICA;";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            MySqlDataReader leitor = comando.ExecuteReader();

            if (leitor.HasRows)
            {
                while (leitor.Read())
                {
                    List<Musica> musicas = new List<Musica>();
                    Musica musica = new Musica()
                    {
                        Id_musica = Convert.ToInt32(leitor["id_musica"]),
                        Titulo = Convert.ToString(leitor["titulo"])!,
                        Album = Convert.ToString(leitor["album"])!,
                        Duracao = Convert.ToDecimal(leitor["duracao"])!,
                        TotalOuvintes = Convert.ToInt32(leitor["total_ouvintes"]),
                    };
                    Console.WriteLine($"ID: {musica.Id_musica} | Título: {musica.Titulo} | Album: {musica.Album} | Duração: {musica.Duracao} | Total de Ouvintes: {musica.TotalOuvintes}");
                }
            }
            else
            {
                Console.WriteLine("Nenhuma música está cadastrada.");
            }
            leitor.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            conexao.Close();
        }
    }
    // O usuário poderá alterar seu id e bio. Posso ver depois sobre a senha também.
    public void AlterarUsuario(Usuario usuario)
    {
        try
        {
            conexao.Open();
            string sql = "UPDATE USUARIO SET NOME_USUARIO = @nome_usuario, BIO = @bio WHERE ID = @id_usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@nome_usuario", usuario.Username);
            comando.Parameters.AddWithValue("@bio", usuario.Bio);
            comando.Parameters.AddWithValue("@id_usuario", usuario.Id);

            comando.ExecuteNonQuery();
            Console.WriteLine($"{usuario.Username} atualizado(a) com sucesso!");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);   
        }
        finally
        {
            conexao.Close();
        }
    }
    // O usuário pode ser removido.
    public void RemoverUsuario(Usuario usuario)
    {
        try
        {
            conexao.Open();
            string sqlNomeUsuario = "SELECT NOME_USUARIO FROM USUARIO WHERE ID_USUARIO = @id_usuario;";
            MySqlCommand comandoNome = new MySqlCommand(sqlNomeUsuario, conexao);
            comandoNome.Parameters.AddWithValue("@id_usuario", usuario.Id);
            MySqlDataReader leitorNome = comandoNome.ExecuteReader();
            leitorNome.Read();
            string nomeUsuario = leitorNome["nome_usuario"].ToString()!;
            leitorNome.Close();

            string sql = "DELETE FROM USUARIO WHERE ID_USUARIO = @id_usuario;";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@id_usuario", usuario.Id);

            comando.ExecuteNonQuery();
            Console.WriteLine($"{nomeUsuario} excluído(a) com sucesso!");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);   
        }
        finally
        {
            conexao.Close();
        }
    }

}