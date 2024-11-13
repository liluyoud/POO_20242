using Sapiens.Console.Helpers;
using Sapiens.Console.Modules;
using Sapiens.Core.Contexts;
using static System.Console;

public class SapiensApp
{
    private SapiensContext context = new SapiensContext();

    private CursoModule cursoModule;
    private DisciplinaModule disciplinaModule;
    private ProfessorModule professorModule;
    private AlunoModule alunoModule;

    public SapiensApp()
    {
        context.RecuperaFromJson();
        cursoModule = new CursoModule(context);
        disciplinaModule = new DisciplinaModule(context);
        professorModule = new ProfessorModule(context);
        alunoModule = new AlunoModule(context);
    }

    public void ShowMenu()
    {
        MenuHelper.ShowTitulo("Sistema Acadêmico");
        var opcao = "";
        WriteLine(" [1] Cursos");
        WriteLine(" [2] Disciplinas");
        WriteLine(" [3] Professores");
        WriteLine(" [4] Alunos");
        WriteLine("\n [9] Sair do Sistema");
        MenuHelper.ShowBarra();
        Write(" Opção: ");
        opcao = ReadLine();
        switch (opcao)
        {
            case "1": cursoModule.ShowMenu("Cursos"); break;
            case "2": disciplinaModule.ShowMenu("Disciplinas"); break;
            case "3": professorModule.ShowMenu("Professores"); break;
            case "4": alunoModule.ShowMenu("Alunos"); break;
            case "9":
                {
                    context.SalvarToJson();
                    MenuHelper.SairSistema();
                    break;
                }
        }
        if (opcao != "9")
            ShowMenu();
    }


}
