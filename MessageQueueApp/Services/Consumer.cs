using MessageQueueApp.Logging;
using MessageQueueApp.Stats;

namespace MessageQueueApp.Services
{
    public class Consumer
    {
        private readonly MessageQueue _queue;
        private readonly MessageStats _stats;
        private readonly LoggingService _logger;
        public Consumer(MessageQueue queue, MessageStats stats, LoggingService logger)
        {
            _queue = queue;
            _stats = stats;
            _logger = logger;

        }
        public void Consume()
        {
            while (_queue.TryDequeue(out var message))
            {
                try
                {
                    // Simulate random failure
                    if (message.Content.Contains("fail"))
                        throw new Exception("Simulated error");

                    _logger.LogInfo($"Id: {message.Id}, Processed: {message.Content}");
                    _stats.IncrementSuccess();
                }
                catch (Exception ex)
                {
                    _logger.LogError($"Failed to process message: {message.Content}\n[DETAIL] {ex.Message}");


                    _stats.IncrementFailure();
                }
            }
        }
    }
}
