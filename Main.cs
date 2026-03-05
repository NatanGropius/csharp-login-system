using System;

class Program
{
    static void Main()
    {
        int cont = 0; // declara contador

        while (cont < 3)
        {
            Console.WriteLine("Digite seu usuário:");
            string username = Console.ReadLine();

            Console.WriteLine("Digite sua senha:");
            string password = Console.ReadLine();

            if (username == "admin" && password == "1234")
            {
                Console.WriteLine("Bem vindo, " + username);
                break;
            }
            else
            {
                Console.WriteLine("Senha e/ou Usuário incorretos.");
                cont++;
            }
        }

        if (cont >= 3)
        {
            Console.WriteLine("Conta bloqueada.");
        }
    }
}
