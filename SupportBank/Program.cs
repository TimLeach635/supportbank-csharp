namespace SupportBank
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args[0].ToLower() != "list")
            {
                return;
            }

            CsvLoader loader = new CsvLoader();
            Bank bank = loader.LoadFromCsv(@"C:\Training\TechSwitch\13-support-bank\SupportBank\Transactions2014.csv");

            if (args[1].ToLower() == "all")
            {
                bank.PrintAllTransactions();
                return;
            }

            decimal balance = bank.GetAccountBalance(args[1]);
            Console.WriteLine($"Balance for {args[1]}: £{balance}");
        }
    }
}
