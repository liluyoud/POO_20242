using static System.Console;

namespace Sapiens.Console.Helpers;

public static class MenuHelper
{
    public static void SairSistema()
    {
        Clear();
        WriteLine("-----------------------------------");
        WriteLine(" Sapiens - Sistema Acadêmico");
        WriteLine("-----------------------------------");
        WriteLine("\n Obrigado por usar nosso sistema.");
        WriteLine(" Pressione qualquer tecla para sair.");
        ReadKey();
        Environment.Exit(0);
    }

    public static void ShowTitulo(string titulo)
    {
        Clear();
        WriteLine("-----------------------------------");
        WriteLine($" Sapiens - {titulo}");
        WriteLine("-----------------------------------");
    }

    public static string? GetOpcao()
    {
        WriteLine(" [1] Consultar");
        WriteLine(" [2] Adicionar");
        WriteLine(" [3] Editar");
        WriteLine(" [4] Excluir");
        WriteLine("\n [Enter] Menu Principal");
        WriteLine("-----------------------------------");
        Write(" Opção: ");
        return ReadLine();
    }
}
