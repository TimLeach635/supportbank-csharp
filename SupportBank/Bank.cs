namespace SupportBank
{
    public class Bank
    {
        public List<Transaction> Transactions { get; set; }

        public List<Account> Accounts {
            get
            {
                List<Account> accounts = new List<Account>();

                foreach(var transaction in Transactions)
                {
                    if (!accounts.Any(account => account.Name == transaction.From.Name))
                    {
                        accounts.Add(transaction.From);
                    }

                    if (!accounts.Any(account => account.Name == transaction.To.Name))
                    {
                        accounts.Add(transaction.To);
                    }
                }

                return accounts;
            }
        }

        public Bank()
        {
            Transactions = new List<Transaction>();
        }

        public void PrintAllTransactions()
        {
            foreach(var transaction in Transactions)
            {
                Console.WriteLine(transaction);
            }
        }

        public decimal GetAccountBalance(string name)
        {
            if (!Accounts.Any(account => account.Name == name))
            {
                throw new ArgumentOutOfRangeException("The given name does not match to any account");
            }

            Account account = Accounts.Find(a => a.Name == name);
            decimal result = 0;

            foreach(var transaction in Transactions)
            {
                if (transaction.From.Name == account.Name)
                {
                    result -= transaction.Amount;
                }
                if (transaction.To.Name == account.Name)
                {
                    result += transaction.Amount;
                }
            }

            return result;
        }
    }
}
