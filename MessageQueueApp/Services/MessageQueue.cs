using MessageQueueApp.Models;
using System.Collections.Concurrent;

namespace MessageQueueApp.Services
{
    public class MessageQueue
    {
        public ConcurrentQueue<Message> Queue { get; } = new();
        public void Enqueue(Message message) => Queue.Enqueue(message);
        public bool TryDequeue(out Message message) => Queue.TryDequeue(out message);
    }
}
