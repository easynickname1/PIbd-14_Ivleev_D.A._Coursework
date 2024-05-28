namespace ProjectCoursework.src;

/// <summary>
/// Класс-управленец
/// </summary>
public class PriorityQueueManager
{
    private PriorityQueue _queue;
    private PriorityQueueStorage _storage;

    public PriorityQueueManager()
    {
        _queue = new PriorityQueue();
        _storage = new PriorityQueueStorage();
    }

    public void Enqueue(QueueItem item)
    {
        _queue.Enqueue(item);
        _storage.AddState(_queue.GetState());
    }

    public QueueItem Dequeue()
    {
        QueueItem value = _queue.Dequeue();
        _storage.AddState(_queue.GetState());
        return value;
    }
    public int GetStateCount()
    {
        return _storage.Count();
    }

    public PriorityQueueState GetCurrentState()
    {
        return _queue.GetState();
    }

    public PriorityQueueState GetState(int index)
    {
        return _storage.GetState(index);
    }

    public void Reset()
    {
        _queue.Clear();
        _storage.Reset();
    }

    public void SaveToFile(string filePath)
    {
        _storage.SaveToFile(filePath);
    }

    public void LoadFromFile(string filePath)
    {
        _storage.LoadFromFile(filePath);
    }
}