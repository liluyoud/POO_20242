using Sapiens.Core.Enums;

namespace Sapiens.Core.Models;

public class Curso
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public Periodo? Periodo { get; set; } 
    public int CargaHoraria { get; set; }
}
