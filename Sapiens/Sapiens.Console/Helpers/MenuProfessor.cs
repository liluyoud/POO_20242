using static System.Console;

namespace Sapiens.Console.Helpers;

public static class MenuProfessor
{
    public static void ShowMenu()
    {
        MenuHelper.ShowTitulo("Professores");
        var opcao = MenuHelper.GetOpcao();
        switch (opcao)
        {
            case "1": MenuConsulta(); break;
            case "2": MenuCadastro(); break;
            case "3": MenuEditar(); break;
            case "4": MenuExcluir(); break;
        }
    }

    public static void MenuConsulta()
    {
        MenuHelper.ShowTitulo("Consultar Curso");
        WriteLine(" Pesquisar por: ");
        WriteLine("-----------------------------------");
        ReadLine();
        ShowMenu();
    }

    public static void MenuCadastro()
    {
        MenuHelper.ShowTitulo("Cadastrar Curso");
        WriteLine(" Nome:          ");
        WriteLine(" Período:       ");
        WriteLine(" Carga Horária: ");
        WriteLine("-----------------------------------");
        ReadLine();
        ShowMenu();
    }

    public static void MenuEditar()
    {
        MenuHelper.ShowTitulo("Editar Curso");
        WriteLine(" Código: ");
        WriteLine("-----------------------------------");
        ReadLine();
        ShowMenu();
    }

    public static void MenuExcluir()
    {
        MenuHelper.ShowTitulo("Excluir Curso");
        WriteLine(" Código: ");
        WriteLine("-----------------------------------");
        ReadLine();
        ShowMenu();
    }

}
