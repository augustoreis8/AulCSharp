using System;

namespace meuPrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta_do_Augusto = new ContaCorrente("Augusto", 2846, 2468, 2000);
            ContaCorrente conta_do_Crisóstomo = new ContaCorrente("Crisóstomp", 19375, 13579, 3000);
            ContaCorrente conta_do_Reis = new ContaCorrente("Reis", 12569, 010203, 1000);

            Console.WriteLine("A conta é do (a) " + conta_do_Augusto.Titular +
            ", a agência é " + conta_do_Augusto.Agencia + " e o número é "
            + conta_do_Augusto.Numero + "Saldo: " + conta_do_Augusto.Saldo);

            Console.WriteLine("A conta é do (a) " + conta_do_Crisóstomo.Titular +
            ", a agência é " + conta_do_Crisóstomo.Agencia + " e o número é "
            + conta_do_Crisóstomo.Numero + "Saldo: " + conta_do_Crisóstomo.Saldo);

            Console.WriteLine("A conta é do (a) " + conta_do_Reis.Titular +
            ", a agência é " + conta_do_Reis.Agencia + " e o número é "
            + conta_do_Reis.Numero + "Saldo: " + conta_do_Reis.Saldo);

            bool Sacar_conta = conta_do_Augusto.Sacar(500);
            bool Sacar_conta1 = conta_do_Crisóstomo.Sacar(500);
            bool Sacar_conta2 = conta_do_Reis.Sacar(500);

            Console.WriteLine("A conta é do (a) " + conta_do_Augusto.Titular +
            ", a agência é " + conta_do_Augusto.Agencia + " e o número é "
            + conta_do_Augusto.Numero + "Saldo: " + conta_do_Augusto.Saldo);

            Console.WriteLine("A conta é do (a) " + conta_do_Crisóstomo.Titular +
            ", a agência é " + conta_do_Crisóstomo.Agencia + " e o número é "
            + conta_do_Crisóstomo.Numero + "Saldo: " + conta_do_Crisóstomo.Saldo);

            Console.WriteLine("A conta é do (a) " + conta_do_Reis.Titular +
            ", a agência é " + conta_do_Reis.Agencia + " e o número é "
            + conta_do_Reis.Numero + "Saldo: " + conta_do_Reis.Saldo);

        }
    }
}



