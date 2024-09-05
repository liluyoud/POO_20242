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
    void Sacar()
    {
    }

    void Depositar()
    {
    }
}