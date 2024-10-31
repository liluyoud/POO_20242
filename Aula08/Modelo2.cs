// um banco tem 3 tipos de contas bancárias: 
//  . corrente, poupança e investimentos
// tb ele trabalha com dois tipos de clientes: 
//  . pessoa física e pessoa jurídica
// elabore um modelo que controle as transações bancárias 
// de cada cliente

namespace modelo2;

public class Banco {
    public List<ContaBancaria>? Contas { get; set; }
    public List<Cliente>? Clientes { get; set; }
}
public class Cliente {
    public TipoCliente? Tipo { get; set; }
    public List<ContaBancaria>? Contas { get; set; }
}

public class ContaBancaria {
    public Cliente? Cliente { get; set; }
    public List<Transacao>? Transacoes { get; set; }
    public TipoConta? Tipo {  get; set; }
}

public class Transacao {
    public ContaBancaria? Conta { get; set; }
}

public enum TipoConta
{
    Corrente,
    Poupanca,
    Investimento
}

public enum TipoCliente
{
    Pessoa,
    Empresa
}