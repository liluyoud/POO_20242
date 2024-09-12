using System.ComponentModel.DataAnnotations;

public class Aluno
{
    // propriedades
    public string? Nome { get; set; }

    [StringLength(14)] // annotation
    public string? Cpf { get; set; }

    public bool Matriculado { get; } // somente leitura
}
