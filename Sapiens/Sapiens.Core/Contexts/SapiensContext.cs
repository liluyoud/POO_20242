using Sapiens.Core.Models;

namespace Sapiens.Core.Contexts;

public class SapiensContext
{
    public List<Curso>? Cursos { get; set; }
    public List<Disciplina>? Disciplinas { get; set; }
    public List<Professor>? Professores { get; set; }
    public List<Aluno>? Alunos { get; set; }
}
