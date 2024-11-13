using static System.Console;

namespace Sapiens.Console.Helpers;

public static class MenuHelper
{
    public static void ShowMenu()
    {
        ShowTitulo("Sistema Acadêmico");
        var opcao = "";
        WriteLine(" [1] Cursos");
        WriteLine(" [2] Disciplinas");
        WriteLine(" [3] Professores");
        WriteLine(" [4] Alunos");
        WriteLine("\n [9] Sair do Sistema");
        WriteLine("-----------------------------------");
        Write(" Opção: ");
        opcao = ReadLine();
        switch (opcao)
        {
            case "1": MenuCurso.ShowMenu(); break;
            case "2": MenuDisciplina.ShowMenu(); break;
            case "3": MenuProfessor.ShowMenu(); break;
            case "4": MenuAluno.ShowMenu(); break;
            case "9": SairSistema(); break;
        }
        ShowMenu();
    }

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
        WriteLine("-----------------------------------");
        Write(" Opção: ");
        return ReadLine();
    }
}
