public class ContaCorrente
{
    public string Titular;
    public int Agencia;
    public int Numero;
    public double Saldo;

    public ContaCorrente(string Titular, int Agencia, int Numero, double Saldo)
    {
        this.Titular = Titular;
        this.Agencia = Agencia;
        this.Numero = Numero;
        this.Saldo = Saldo;
    }
    public bool Sacar(double ValorSaque)
    {
        if (this.Saldo >= ValorSaque)
        {
            this.Saldo = this.Saldo - ValorSaque;
            return true;
        }
        return false;
    }
    public bool Depositar(double ValorDeposito)
    {
        this.Saldo = this.Saldo + ValorDeposito;
        return true;
    }
}