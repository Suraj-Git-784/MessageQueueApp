using MessageQueueApp.Logging;
using MessageQueueApp.Services;
using MessageQueueApp.Stats;

var logger = new LoggingService();
var queue = new MessageQueue();
var stats = new MessageStats();
var producer = new Producer(queue);
var consumer = new Consumer(queue, stats, logger);

// Simulate producing
producer.Produce("Message 1");
producer.Produce("Message that should fail");

// Simulate consuming
consumer.Consume();

// Output stats
stats.PrintStats();