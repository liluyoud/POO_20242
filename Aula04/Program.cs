var conta = new Conta("Lilo");
conta.Depositar(100);
conta.Sacar(50);
conta.AlterarLimite(500);
Console.WriteLine(conta.Extrato());
conta.FecharConta();
conta.Sacar(100);

// conta bancária
class Conta
{
    // atributos privados
    private string titular;
    private double saldo;
    private double limite;
    private bool ativo;

    // métodos públicos
    // construtor:
    // define o estado inicial do objeto
    public Conta(string titular)
    {
        this.titular = titular;
        this.ativo = true;
        // números são inicializados com 0 automaticamente
        // this.limite = 0;
        // this.saldo = 0;
    }

    public Conta(string titular, double limite)
    {
        this.titular = titular;
        this.limite = limite;
        this.ativo = true;
    }

    public string Extrato()
    {
        var extrato = $"Conta {this.titular}";
        extrato += "\n-----------------------------------";
        extrato += $"\nSituação em {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}";
        extrato += $"\n . Saldo              R$ {this.saldo:F2}";
        extrato += $"\n . Limite             R$ {this.limite:F2}";
        extrato += $"\n . Saldo disponível:  R$ {(this.saldo + this.limite):F2}";
        extrato += "\n-----------------------------------";
        return extrato;
    }

    // método
    public void Sacar(double valor)
    {
        // saldo: 100 limite: 1000
        // disponivel para saque: 1100
        // posso sacar 2000?
        if (ativo)
        {
            if (this.saldo + this.limite >= valor)
                this.saldo -= valor;
        }
    }

    public void Depositar(double valor)
    {
        if (ativo)
        {
            this.saldo += valor;
        }
    }

    public void AlterarLimite(double novoLimite)
    {
        this.limite = novoLimite;
    }

    public void FecharConta()
    {
        this.ativo = false;
    }
}