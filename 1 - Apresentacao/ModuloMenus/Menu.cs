class Menu
{
    public static void Notificacao(string text, ConsoleColor cor)
    {
        Console.ForegroundColor = cor;
        Console.Write(text);
        Console.ResetColor(); 
    }
    public static void ApresentarTitulo(string subtitulo)
    {
        Console.WriteLine("=====================================");
        Notificacao("              Spotfey         ", ConsoleColor.DarkGreen); Notificacao(subtitulo, ConsoleColor.DarkGray);
        Console.WriteLine("\n=====================================");
    }
}