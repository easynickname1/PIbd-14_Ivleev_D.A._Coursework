namespace ProjectCoursework.src;

/// <summary>
/// Класс-состояние
/// </summary>
[Serializable]
public class PriorityQueueState
{
    public QueueItem[] QueueItems { get; private set; }

    public PriorityQueueState(PriorityQueue queue)
    {
        List<QueueItem> item = new List<QueueItem>();
        QueueItem current = queue.GetHead();
        while (current != null)
        {
            item.Add(current);
            current = current.Next;
        }
        QueueItems = item.ToArray();
    }
}