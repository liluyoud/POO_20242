Console.Clear();
Console.WriteLine("Nosso 1ª programa OO");
Console.WriteLine("-------------------------------");

// com a ideia, podemos criar o real
// var objeto = new Classe();
var aluno = new Aluno();
aluno.nome = "Lilo";
aluno.idade = 51;
aluno.salario = 1412.30;
aluno.matriculado = true;

// O aluno Lilo de 51 anos está matriculado
var matriculado = "não está";
if (aluno.matriculado)
{
    matriculado = "está";
}

Console.WriteLine($"O aluno {aluno.nome} de {aluno.idade} anos {matriculado} matriculado");
Console.ReadLine();

// idéia do que é o aluno
public class Aluno
{
    public string nome; // texto
    public int idade; // número inteiro
    public double salario; // número real
    public bool matriculado; // V ou F
}