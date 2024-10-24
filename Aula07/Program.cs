var a1 = new Aluno();
var a2 = new Aluno();
var a3 = new Aluno();

var p1 = new Professor();
var p2 = new Professor();

a1.Professores.Add(p1);
a1.Professores.Add(p2);

p1.Alunos.Add(a1);
p2.Alunos.Add(a1);


// 1 x 1 --------------------------------------

class Marido
{
    // olhar para esposa (1)
    // ou opcional
    public Esposa? Esposa { get; set; }
}

class Esposa
{
    // olhar pro marido (1)
    // ou opcional
    public Marido? Marido { get; set; }
}

// 1 x n --------------------------------------

class Empresa
{
    // olhar para o funcionário (n)
    // opcional
    public List<Funcionario> Funcionarios { get; set; } = new();
}

class Funcionario
{
    // olhar para a empresa (1)
    // obrigado 
    public Empresa? Empresa { get; set; }
}

// n x n --------------------------------------

class Professor
{
    // olhar o aluno (n)
    // opcional
    public List<Aluno> Alunos { get; set; } = new();
}

// obrigatório
class Professor_Aluno
{
    public Professor? Professor { get; set; }
    public Aluno? Aluno { get; set; }
}

class Aluno
{
    // olhar o professor (n)
    // opcional
    public List<Professor> Professores { get; set; } = new();
}






