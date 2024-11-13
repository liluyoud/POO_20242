using Sapiens.Console.Helpers;
using Sapiens.Core.Contexts;

namespace Sapiens.Console.Modules;

public abstract class BaseModule
{
    private readonly SapiensContext _context;

    public BaseModule(SapiensContext context)
    {
        _context = context;
    }

    public void ShowMenu(string titulo)
    {
        MenuHelper.ShowTitulo(titulo);
        var opcao = MenuHelper.GetOpcao();
        switch (opcao)
        {
            case "1": MenuConsulta(); break;
            case "2": MenuCadastro(); break;
            case "3": MenuEditar(); break;
            case "4": MenuExcluir(); break;
        }
    }

    public abstract void MenuConsulta();
    public abstract void MenuCadastro();
    public abstract void MenuEditar();
    public abstract void MenuExcluir();

}