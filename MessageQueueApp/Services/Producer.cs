using MessageQueueApp.Models;

namespace MessageQueueApp.Services
{
    public class Producer
    {
      private readonly MessageQueue _queue;
        public Producer(MessageQueue queue) => _queue = queue;
        public void Produce(string content)
        {
            var message = new Message { Content = content };
            _queue.Enqueue(message);
        }
    }
}
