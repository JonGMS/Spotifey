public class Usuario : EntidadeBase<Usuario>
{
    public string Username {get; init;}
    public string Bio {get; set;}
    public string Password {get; set;}
    public Usuario()
    {
        
    }
    public Usuario(string bio)
    {
        Bio = bio;
    }
    public Usuario(string username, string password)
    {
        Username = username;
        Password = password;
    }
    
}