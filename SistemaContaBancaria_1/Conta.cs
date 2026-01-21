namespace Banco;

public class Conta
{
    private double Saldo = 0;

    public bool Depositar(double valor)
    {
        if (valor >= 1)
        {
            Saldo += valor;
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool Sacar(double valor)
    {
        if(valor <= Saldo && valor != 0)
        {
            Saldo -= valor;
            return true;
        } else
        {
            return false;
        }
    }

    public double ExibirSaldo()
    {
        return Saldo;
    }
}