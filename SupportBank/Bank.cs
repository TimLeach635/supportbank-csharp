namespace SupportBank
{
    public class Bank
    {
        public List<Transaction> Transactions { get; set; }

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
            decimal result = 0;

            foreach(var transaction in Transactions)
            {
                if (transaction.From == name)
                {
                    result -= transaction.Amount;
                }
                if (transaction.To == name)
                {
                    result += transaction.Amount;
                }
            }

            return result;
        }
    }
}
