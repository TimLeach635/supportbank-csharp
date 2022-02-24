namespace SupportBank
{
    public class Transaction
    {
        public DateTime Date { get; set; }
        public Account From { get; set; }
        public Account To { get; set; }
        public string Narrative { get; set; }
        public decimal Amount { get; set; }

        public Transaction(DateTime date, Account from, Account to, string narrative, decimal amount)
        {
            Date = date;
            From = from;
            To = to;
            Narrative = narrative;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"{Date}: £{Amount} from {From.Name} to {To.Name} for {Narrative}";
        }
    }
}
