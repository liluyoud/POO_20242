using Sapiens.Console.Helpers;
using Sapiens.Core.Contexts;

namespace Sapiens.Console.Modules;

public abstract class BaseModule
{
    public SapiensContext Context { get; set; }

    public BaseModule(SapiensContext context)
    {
        Context = context;
    }

    public void ShowMenu(string titulo)
    {
        MenuHelper.ShowTitulo(titulo);
        var opcao = MenuHelper.GetOpcao();
        switch (opcao)
        {
            case "1": MenuLista(); break;
            case "2": MenuConsulta(); break;
            case "3": MenuCadastro(); break;
            case "4": MenuEditar(); break;
            case "5": MenuExcluir(); break;
        }
    }

    public abstract void MenuLista();
    public abstract void MenuConsulta();
    public abstract void MenuCadastro();
    public abstract void MenuEditar();
    public abstract void MenuExcluir();

}