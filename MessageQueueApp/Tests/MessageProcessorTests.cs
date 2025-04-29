using MessageQueueApp.Logging;
using MessageQueueApp.Models;
using MessageQueueApp.Services;
using MessageQueueApp.Stats;
using Xunit;

namespace MessageQueueApp.Tests
{
    public class MessageProcessorTests
    {

        [Fact]
        public void Test_Successful_Message_Processing()
        {
            var logger = new LoggingService();
            var queue = new MessageQueue();
            var stats = new MessageStats();
            var consumer = new Consumer(queue, stats, logger);

            queue.Enqueue(new Message { Content = "Hello" });

            consumer.Consume();

            Assert.Equal(1, stats.SuccessCount);
            Assert.Equal(0, stats.FailureCount);
        }

        [Fact]
        public void Test_Failed_Message_Processing()
        {
            var logger = new LoggingService();
            var queue = new MessageQueue();
            var stats = new MessageStats();
            var consumer = new Consumer(queue, stats, logger);

            queue.Enqueue(new Message { Content = "fail this" });

            consumer.Consume();

            Assert.Equal(0, stats.SuccessCount);
            Assert.Equal(1, stats.FailureCount);
        }
    }
}
