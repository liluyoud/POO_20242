using static System.Console;

namespace Sapiens.Console.Helpers;

public static class MenuHelper
{
    public static void ShowBarra()
    {
        WriteLine("---------------------------------------------------------------");
    }

    public static void SairSistema()
    {
        Clear();
        ShowBarra();
        WriteLine(" Sapiens - Sistema Acadêmico");
        ShowBarra();
        WriteLine("\n Obrigado por usar nosso sistema.");
        WriteLine(" Pressione qualquer tecla para sair.");
        ReadKey();
    }

    public static void ShowTitulo(string titulo)
    {
        Clear();
        ShowBarra();
        WriteLine($" Sapiens - {titulo}");
        ShowBarra();
    }

    public static string? GetOpcao()
    {
        WriteLine(" [1] Listar");
        WriteLine(" [2] Consultar");
        WriteLine(" [3] Adicionar");
        WriteLine(" [4] Editar");
        WriteLine(" [5] Excluir");
        WriteLine("\n [Enter] Menu Principal");
        ShowBarra();
        Write(" Opção: ");
        return ReadLine();
    }
}
