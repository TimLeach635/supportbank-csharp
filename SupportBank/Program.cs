namespace SupportBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CsvLoader loader = new CsvLoader();
            Bank bank = loader.LoadFromCsv(@"C:\Training\TechSwitch\13-support-bank\SupportBank\Transactions2014.csv");
            bank.PrintAllTransactions();
            decimal timLAccountBalance = bank.GetAccountBalance("Tim L");
            Console.WriteLine($"Balance of Tim L: £{timLAccountBalance}");
        }
    }
}
