using Sapiens.Core.Models;
using System.Text.Json;

namespace Sapiens.Core.Contexts;

public class SapiensContext
{
    public List<Curso> Cursos { get; set; }
    public List<Disciplina> Disciplinas { get; set; }
    public List<Professor> Professores { get; set; }
    public List<Aluno> Alunos { get; set; }

    public SapiensContext()
    {
        Cursos = new List<Curso>();
        Disciplinas = new List<Disciplina>();
        Professores = new List<Professor>();
        Alunos = new List<Aluno>();
    }

    public void SalvarToJson()
    {
        // transforma o objeto em json
        var json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        // salva no pasta meus documentos
        var diretorio = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        var arquivo = Path.Combine(diretorio, "sapiens.json");
        File.WriteAllText("sapiens.json", json);
    }

    public void RecuperaFromJson()
    {
        // recupera o json do arquivo
        var diretorio = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        var arquivo = Path.Combine(diretorio, "sapiens.json");
        var json = File.ReadAllText(arquivo);
        // transforma o json em objeto
        var sapiens = JsonSerializer.Deserialize<SapiensContext>(json);
        // copia os valores para o objeto atual
        if (sapiens != null)
        {
            Cursos = sapiens.Cursos;
            Disciplinas = sapiens.Disciplinas;
            Professores = sapiens.Professores;
            Alunos = sapiens.Alunos;
        }
    }
}
