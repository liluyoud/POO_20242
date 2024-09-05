using System;

var conta = new Conta("Lilo");
Console.WriteLine($"Titular: {conta.titular}");
Console.WriteLine($"Saldo:   R$ {conta.saldo}");
Console.WriteLine($"Limite:  R$ {conta.limite}");
Console.WriteLine($"Ativo:   {conta.ativo}");

var contaEspecial = new Conta("Sara", 1000);
Console.WriteLine($"\n\nTitular: {contaEspecial.titular}");
Console.WriteLine($"Saldo:   R$ {contaEspecial.saldo}");
Console.WriteLine($"Limite:  R$ {contaEspecial.limite}");
Console.WriteLine($"Ativo:   {contaEspecial.ativo}");

Console.WriteLine("\n\nDepositar R$ 300");
contaEspecial.Depositar(300);
Console.WriteLine($"Saldo:   R$ {contaEspecial.saldo}");
Console.WriteLine($"Limite:  R$ {contaEspecial.limite}");

Console.WriteLine("\n\nDepositar R$ 100");
contaEspecial.Depositar(100);
Console.WriteLine($"Saldo:   R$ {contaEspecial.saldo}");
Console.WriteLine($"Limite:  R$ {contaEspecial.limite}");

Console.WriteLine("\n\nSacar R$ 800");
contaEspecial.Sacar(800);
Console.WriteLine($"Saldo:   R$ {contaEspecial.saldo}");
Console.WriteLine($"Limite:  R$ {contaEspecial.limite}");

Console.WriteLine("\n\nSacar R$ 700");
contaEspecial.Sacar(700);
Console.WriteLine($"Saldo:   R$ {contaEspecial.saldo}");
Console.WriteLine($"Limite:  R$ {contaEspecial.limite}");

Console.WriteLine("\n\nMudar o saldo manualmente para -5000");
contaEspecial.saldo = -5000;
Console.WriteLine($"Saldo:   R$ {contaEspecial.saldo}");
Console.WriteLine($"Limite:  R$ {contaEspecial.limite}");

// conta bancária
class Conta
{
    public string titular;
    public double saldo;
    public double limite;
    public bool ativo;

    // construtor:
    // define o estado inicial do objeto
    public Conta(string titular)
    {
        this.titular = titular;
        this.ativo = true;
    }

    public Conta(string titular, double limite)
    {
        this.titular = titular;
        this.limite = limite;
        this.ativo = true;
    }

    // método
    public void Sacar(double valor)
    {
        // saldo: 100 limite: 1000
        // disponivel para saque: 1100
        // posso sacar 2000?
        if (saldo + limite >= valor)
            saldo -= valor;
    }

    public void Depositar(double valor)
    {
        saldo += valor;
    }
}