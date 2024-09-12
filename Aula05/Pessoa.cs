public class Pessoa
{
    // atributos privados
    private string? nome;
    private DateTime dataNascimento;

    // propriedades públicas
    public string? Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public DateTime DataNascimento
    {
        get { return dataNascimento; }
        set { dataNascimento = value; }
    }

    public int Idade => (int)(DateTime.Now - DataNascimento).TotalDays / 365;
}
