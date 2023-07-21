namespace DevCoaching.Denesting.Before
{
    public class Denesting_Before
    {
        public async Task ProcessCustomerBatch(InputRecord[] inputRecords, DateTime lastAllowedTimeUtc)
        {
            if (inputRecords != null)
            {
                foreach (var r in inputRecords)
                {
                    if (r.IsAdmin)
                    {
                        throw new Exception("Can't process customer transactions for admins");
                    }

                    foreach (var t in r.Transactions)
                    {
                        if (t.TransactionUtc > lastAllowedTimeUtc)
                            throw new Exception("Time exceeded, aborting batch");

                        Process(t);
                    }
                }
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
}
