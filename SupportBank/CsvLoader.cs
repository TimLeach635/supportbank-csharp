namespace SupportBank
{
    public class CsvLoader
    {
        public Bank LoadFromCsv(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                // Discard header row
                sr.ReadLine();

                Bank bank = new Bank();
                List<Account> accounts = new List<Account>();

                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] splitLine = line.Split(",");

                    if (!accounts.Any(account => account.Name == splitLine[1]))
                    {
                        accounts.Add(new Account(splitLine[1]));
                    }

                    if (!accounts.Any(account => account.Name == splitLine[2]))
                    {
                        accounts.Add(new Account(splitLine[2]));
                    }

                    Account from = accounts.Find(account => account.Name == splitLine[1]);
                    Account to = accounts.Find(account => account.Name == splitLine[2]);

                    bank.Transactions.Add(new Transaction(
                        DateTime.Parse(splitLine[0]),
                        from,
                        to,
                        splitLine[3],
                        decimal.Parse(splitLine[4])
                    ));
                }

                return bank;
            }
        }
    }
}
