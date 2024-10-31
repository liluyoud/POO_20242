// um banco tem 3 tipos de contas bancárias: 
//  . corrente, poupança e investimentos
// tb ele trabalha com dois tipos de clientes: 
//  . pessoa física e pessoa jurídica
// elabore um modelo que controle as transações bancárias 
// de cada cliente

namespace modelo1;

public class Banco {
    public List<ContaBancaria>? Contas { get; set; }
    public List<Cliente>? Clientes { get; set; }
}

public class Cliente {
    public List<ContaBancaria>? Contas { get; set; }
}

public class ContaBancaria {
    public Cliente? Cliente { get; set; }
    public List<Transacao>? Transacoes { get; set; }
}

public class Transacao {
    public ContaBancaria? Conta { get; set; }
}

public class ContaCorrente : ContaBancaria { }

public class ContaPoupanca : ContaBancaria { }

public class ContaInvestimento : ContaBancaria { }

public class PessoaFisica : Cliente { }

public class PessoaJuridica : Cliente { }
