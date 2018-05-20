namespace _04.DefinePersonClass
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var accounts = new Dictionary<int, BankAccount>();

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "End")
                {
                    break;
                }

                var tokens = inputLine.Split();
                var command = tokens[0];

                switch (command)
                {
                    case "Create":
                        Create(tokens, accounts);
                        break;
                    case "Deposit":
                        Deposit(tokens, accounts);
                        break;
                    case "Withdraw":
                        Withdraw(tokens, accounts);
                        break;
                    case "Print":
                        Print(tokens, accounts);
                        break;
                }
            }
        }

        private static void Create(string[] tokens, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(tokens[1]);

            if (!accounts.ContainsKey(id))
            {
                accounts[id] = new BankAccount(id);
            }
            else
            {
                Console.WriteLine("Account already exists");
            }
        }

        private static void Deposit(string[] tokens, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(tokens[1]);
            var amount = double.Parse(tokens[2]);

            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                accounts[id].Deposit(amount);
            }
        }

        private static void Withdraw(string[] tokens, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(tokens[1]);
            var amount = double.Parse(tokens[2]);

            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                accounts[id].Withdraw(amount);
            }
        }

        private static void Print(string[] tokens, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(tokens[1]);

            Console.WriteLine(accounts[id].ToString());
        }
    }
}