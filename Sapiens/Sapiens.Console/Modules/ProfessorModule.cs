using Sapiens.Console.Helpers;
using Sapiens.Core.Contexts;
using static System.Console;

namespace Sapiens.Console.Modules;

public class ProfessorModule : BaseModule
{
    public ProfessorModule(SapiensContext context) : base(context) { }

    public override void MenuLista()
    {
        MenuHelper.ShowTitulo("Lista de Professores");
        foreach (var item in Context.Professores)
        {
            WriteLine(item.ToString());
        }
    }
    public override void MenuConsulta()
    {
        MenuHelper.ShowTitulo("Consultar Curso");
        WriteLine(" Pesquisar por: ");
        MenuHelper.ShowBarra();
        ReadLine();
    }

    public override void MenuCadastro()
    {
        MenuHelper.ShowTitulo("Cadastrar Curso");
        WriteLine(" Nome:          ");
        WriteLine(" Período:       ");
        WriteLine(" Carga Horária: ");
        MenuHelper.ShowBarra();
        ReadLine();
    }

    public override void MenuEditar()
    {
        MenuHelper.ShowTitulo("Editar Curso");
        WriteLine(" Código: ");
        MenuHelper.ShowBarra();
        ReadLine();
    }

    public override void MenuExcluir()
    {
        MenuHelper.ShowTitulo("Excluir Curso");
        WriteLine(" Código: ");
        MenuHelper.ShowBarra();
        ReadLine();
    }

}
