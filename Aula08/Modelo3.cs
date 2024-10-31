// você tem uma loja de eletrodométicos/produto
// a loja tem varios vendedores
// quando um cliente entra na loja, um vendedor atende ele
// e anota os items que ele quer comprar
// ao final do atendimento, ele cadastra a venda com esses itens
// informando o vendedor que atendeu e a data da venda
// para pagamento a vista, a loja sempre dá 5% de desconto
// para clientes premium, a loja sempre dá mais 10% de desconto

namespace modelo3;

public class Loja {
    public List<Cliente>? Clientes {  get; set; }
    public List<Vendedor>? Vendedores { get; set; }
    public List<Produto>? Produtos { get; set; }
    public List<Venda>? Vendas { get; set; }
}

public class Cliente {
    // a vontade
    public TipoCliente TipoCliente { get; set; }
}

public class Vendedor {
    // a vontade
}

public class Produto {
    public required string Codigo { get; set; }
    public required string Nome { get; set; }
    public int Quantidade { get; set; }
    public decimal Valor { get; set; }
    public string? Categoria { get; set; }
    public string? Descricao { get; set; }
}

public class Venda {
    public Vendedor? Vendedor { get; set; }
    public Cliente? Cliente { get; set; }
    public DateTime? Date { get; set; }
    public TipoPagamento TipoPagamento { get; set; }
    public List<ItemVenda> Items { get; set; } = new();
    public decimal Desconto { get; set; }
    public decimal ValorTotal => Items.Sum(i => i.ValorTotal);
    public decimal ValorVenda => ValorTotal - Desconto;
}

public class ItemVenda
{
    public Produto? Produto { get; set; }
    public int Quantidade { get; set; }
    public decimal ValorUnitario { get; set; }
    public decimal ValorTotal => ValorUnitario * Quantidade; // campo calculado
}

public enum TipoCliente
{
    Normal,
    VIP
}

public enum TipoPagamento
{
    PIX, // 5% de desconto
    Dinheiro, // 5% de desconto
    Debito,
    Boleto,
    CartaoVista,
    CartaoParcelado
}