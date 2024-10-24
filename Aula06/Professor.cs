namespace Aula06;

public class Professor : Funcionario
{
    public string? Titulacao { get; set; }
    public List<Disciplina> Disciplinas { get; set; } = new();

    public void FazerChamada()
    {

    }

    public void LancarNota()
    {

    }
}
