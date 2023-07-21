namespace DevCoaching.Denesting.After;

public class Denesting_After
{
    public void ProcessCustomerBatch(InputRecord[] inputRecords, DateTime lastAllowedTimeUtc)
    {
        if (inputRecords == null) return;

        if(inputRecords.Any(x => x.IsAdmin)) 
            throw new Exception("Can't process customer transactions for admins");

        if(inputRecords.SelectMany(x => x.Transactions).Any(t => t.TransactionUtc > lastAllowedTimeUtc))
            throw new Exception("Time exceeded, aborting batch");

        foreach (var t in inputRecords.SelectMany(x => x.Transactions))
        {
            Process(t);
        }
    }

    public void Process(Transaction t)
    {

    }

    public class InputRecord
    {
        public bool IsAdmin { get; set; }
        public string Name { get; set; }

        public Transaction[] Transactions { get; set; }

    }

    public class Transaction
    {
        public DateTime TransactionUtc { get; set; }
        public string Reference { get; set; }
    }
}
