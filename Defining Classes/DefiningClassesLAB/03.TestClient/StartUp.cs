using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TestClient
{
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
                var acc = new BankAccount();
                acc.ID = id;

                accounts.Add(id, acc);
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Deposit(string[] tokens, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(tokens[1]);
            var ammount = double.Parse(tokens[2]);

            if (accounts.ContainsKey(id))
            {
                accounts[id].Deposit(ammount);
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Withdraw(string[] tokens, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(tokens[1]);
            var ammount = double.Parse(tokens[2]);

            if (accounts.ContainsKey(id))
            {
                accounts[id].Withdraw(ammount);
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Print(string[] tokens, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(tokens[1]);

            if (accounts.ContainsKey(id))
            {
                Console.WriteLine(accounts[id].ToString());
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }
    }
}
