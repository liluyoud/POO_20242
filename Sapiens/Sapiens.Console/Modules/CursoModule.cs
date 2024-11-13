using Sapiens.Console.Helpers;
using Sapiens.Core.Contexts;
using Sapiens.Core.Enums;
using Sapiens.Core.Models;
using static System.Console;

namespace Sapiens.Console.Modules;

public class CursoModule : BaseModule
{
    public CursoModule(SapiensContext context) : base(context) { }

    public override void MenuLista()
    {
        MenuHelper.ShowTitulo("Lista de Cursos");
        foreach (var item in Context.Cursos)
        {
            WriteLine(item.ToString());
        }
        MenuHelper.ShowBarra();
        ReadLine();
        
    }

    public override void MenuConsulta()
    {
        MenuHelper.ShowTitulo("Consultar Curso");
        Write(" Informe o código: ");
        var id = Convert.ToInt32(ReadLine());

        var curso = Context.Cursos.Find(c => c.Id == id);
        ShowDados(curso);
        ReadLine();
        MenuHelper.ShowBarra();
    }

    public override void MenuCadastro()
    {
        MenuHelper.ShowTitulo("Cadastrar Curso");
        Write(" Codigo:        ");
        var id = Convert.ToInt32(ReadLine());
        Write(" Nome:          ");
        var nome = ReadLine();
        Write(" Carga Horária: ");
        var cargaHoraria = Convert.ToInt32(ReadLine());

        WriteLine(" Período do Curso");
        WriteLine(" [0] Matutino");
        WriteLine(" [1] Vespertino");
        WriteLine(" [2] Noturno");
        WriteLine(" [3] Integral");
        Write("\n Informe o período: ");
        var periodo = Convert.ToInt32(ReadLine());

        var curso = new Curso
        {
            Id = id,
            Nome = nome,
            Periodo = (Periodo)periodo,
            CargaHoraria = cargaHoraria
        };
        
        Context.Cursos.Add(curso);

        MenuHelper.ShowBarra();
        WriteLine(" Curso adicionado com sucesso!");
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

    private void ShowDados(Curso? curso)
    {
        if (curso == null) {
            WriteLine(" Curso não encontrado!");
            return;
        }
        WriteLine($"\n Nome:          {curso.Nome}");
        WriteLine($" Período:       {curso.Periodo.ToString()}");
        WriteLine($" Carga Horária: {curso.CargaHoraria}");
    }

}
