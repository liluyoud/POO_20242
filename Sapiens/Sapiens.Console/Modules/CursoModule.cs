using Sapiens.Console.Helpers;
using Sapiens.Core.Contexts;
using static System.Console;

namespace Sapiens.Console.Modules;

public class CursoModule : BaseModule
{
    public CursoModule(SapiensContext context) : base(context) { }

    public override void MenuConsulta()
    {
        MenuHelper.ShowTitulo("Consultar Curso");
        Write(" Pesquisar por: ");
        ReadLine();
        WriteLine("-----------------------------------");
    }

    public override void MenuCadastro()
    {
        MenuHelper.ShowTitulo("Cadastrar Curso");
        WriteLine(" Nome:          ");
        WriteLine(" Período:       ");
        WriteLine(" Carga Horária: ");
        WriteLine("-----------------------------------");
        ReadLine();
    }

    public override void MenuEditar()
    {
        MenuHelper.ShowTitulo("Editar Curso");
        WriteLine(" Código: ");
        WriteLine("-----------------------------------");
        ReadLine();
    }

    public override void MenuExcluir()
    {
        MenuHelper.ShowTitulo("Excluir Curso");
        WriteLine(" Código: ");
        WriteLine("-----------------------------------");
        ReadLine();
    }

}
