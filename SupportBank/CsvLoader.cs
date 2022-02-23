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

                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] splitLine = line.Split(",");

                    bank.Transactions.Add(new Transaction(
                        DateTime.Parse(splitLine[0]),
                        splitLine[1],
                        splitLine[2],
                        splitLine[3],
                        decimal.Parse(splitLine[4])
                    ));
                }

                return bank;
            }
        }
    }
}
