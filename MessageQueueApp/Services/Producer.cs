using MessageQueueApp.Models;

namespace MessageQueueApp.Services
{
    public class Producer
    {
      private readonly MessageQueue _queue;
        public Producer(MessageQueue queue) => _queue = queue;
        public void Produce(List<string> content)
        {
            foreach (var message in content)
            {
                _queue.Enqueue(new Message { Content = message });
            }
        }
    }
}
