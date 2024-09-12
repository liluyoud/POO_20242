public class Produto
{
    // atributos ou variáveis membro
    private string? nome; // get set
    private int quantidade; // get
    private double preco; // get set

    // métodos para acessar os atributos
    // métodos getters
    public string? GetNome()
    {
        return nome;
    }

    public int GetQuantidade()
    {
        return quantidade;
    }

    public double GetPreco()
    {
        return preco;
    }

    // métodos setters
    public void SetNome(string valor)
    {
        // atribuir um valor no atributo nome
        nome = valor;
    }

    //public void SetQuantidade(int valor) {
    // if (valor >= 0)
    // quantidade = valor;
    //}

    public void SetPreco(double valor)
    {
        if (valor >= 0)
            preco = valor;
    }

    // campo calculado: uma característica que é
    // obtida através de outras informações da classe
    public double ValorEstoque => quantidade * preco;
}
