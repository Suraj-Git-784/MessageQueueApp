using MessageQueueApp.Logging;
using MessageQueueApp.Services;
using MessageQueueApp.Stats;

var logger = new LoggingService();
var queue = new MessageQueue();
var stats = new MessageStats();
var producer = new Producer(queue);
var consumer = new Consumer(queue, stats, logger);

var messages = new List<string>
        {
            "Hello World",
            "fail this message",
            "Message 3",
            "Another fail"
        };

producer.Produce(messages);

consumer.Consume();

stats.PrintStats();