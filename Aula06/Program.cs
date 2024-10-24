using Aula06;

Aluno aluno1 = new Aluno();
var aluno2 = new Aluno();
Aluno aluno3 = new();
List<Aluno> alunos = new();









var professor = new Professor();
professor.Nome = "Lilo";
professor.Cpf = "111.111.111-11";
professor.Telefone = "69 98111-1111";
professor.Titulacao = "Mestre";

var disciplina = new Disciplina();
disciplina.Nome = "POO";
disciplina.Professor = professor;

Console.WriteLine("Disciplina:  " + disciplina.Nome);
Console.WriteLine("Professor:   " + disciplina.Professor.Nome);
Console.WriteLine("Cpf do prof: " + disciplina.Professor.Cpf);
