using System;

Console.WriteLine("3ª programa - Métodos");
Console.WriteLine("-------------------------------");

// criar/manipular objetos a partir de uma classe
// instaciar uma classe == criar um objeto
// objeto == instância de uma classe
var produto = new Produto();
produto.nome = "TV LG4K";
produto.quantidade = 8;
produto.valor = 1999.99;

Console.WriteLine($"{produto.nome}: {produto.quantidade} unidades");
produto.comprar(); // compra apenas 1 unidade
produto.comprar(10); // compra 10 unidades
produto.comprar("10");
produto.comprar();
produto.vender();
Console.WriteLine($"{produto.nome}: {produto.quantidade} unidades");


// características de uma classe
// atributos ou variáveis membro de uma classe
class Produto
{
    // atributos da classe Produto
    public string nome;
    public int quantidade;
    public double valor;

    // comportamento, o que o produto faz ou sofre
    public void comprar()
    {
        // instruções necessárias para comprar um produto
        // quantidade++;
        quantidade = quantidade + 1;
    }

    // parêntesis são usados pelos argumentos/parâmetros do método
    public void comprar(int quantidade)
    {
        this.quantidade += quantidade;
    }

    public void comprar(string quantidade)
    {
        var qtd = int.Parse(quantidade);
        this.quantidade -= qtd;
    }

    public void vender()
    {
        quantidade--;
    }

    public void vender(int quantidade)
    {
        this.quantidade -= quantidade;
    }
}