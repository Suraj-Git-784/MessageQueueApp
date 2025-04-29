namespace MessageQueueApp.Stats
{
    public class MessageStats
    {
        public int SuccessCount { get; private set; }
        public int FailureCount { get; private set; }

        public void IncrementSuccess() => SuccessCount++;
        public void IncrementFailure() => FailureCount++;

        public void PrintStats()
        {
            Console.WriteLine($"Success: {SuccessCount}, Failure: {FailureCount}");
        }
    }
}
