var produto = new Produto();
produto.SetNome("TV LCD");
Console.WriteLine(produto.GetNome());
//p.SetQuantidade(10); // campo somente leitura
Console.WriteLine(produto.GetQuantidade());
produto.SetPreco(1999.99);
Console.WriteLine(produto.GetPreco());

var pessoa = new Pessoa();
pessoa.Nome = "Lilo";
pessoa.DataNascimento = DateTime.Parse("07/25/1973"); //new DateTime(1973, 7, 25);
Console.WriteLine(pessoa.Idade);


var aluno = new Aluno();
aluno.Nome = "Zahara";
aluno.Cpf = "111.111.111-11";
Console.WriteLine($"{aluno.Nome} : {aluno.Matriculado}");