namespace ProjectCoursework.src;

/// <summary>
/// Класс-реализатор
/// </summary>
public class PriorityQueue
{
    private QueueItem? _head;
    private QueueItem? _tail;

    public PriorityQueue()
    {
        _head = null;
        _tail = null;
    }

    public QueueItem Enqueue(QueueItem item)
    {
        // Вставка по приоритету (в порядке возрастания)
        if (_head == null || item.Priority < _head.Priority)
        {
            _head = new QueueItem(item.Priority, item.Value) { Next = _head };
            if (_tail == null)
            {
                _tail = _head;
            }
            else
            {
                _head.Next.Prev = _head;
            }
        }
        else
        {
            QueueItem current = _head;
            while (current.Next != null && item.Priority >= current.Next.Priority)
            {
                current = current.Next;
            }
            QueueItem newItem = new QueueItem(item.Priority, item.Value) { Prev = current, Next = current.Next };
            current.Next = newItem;
            if (newItem.Next == null)
            {
                _tail = newItem;
            }
            else
            {
                newItem.Next.Prev = newItem;
            }
            return newItem;
        }
        return _head;
    }

    public QueueItem Dequeue()
    {
        if (_head == null)
        {
            throw new Exception("Очередь пуста");
        }

        QueueItem value = _head;
        _head = _head.Next;
        if (_head != null)
        {
            _head.Prev = null;
        }
        else
        {
            _tail = null;
        }

        return value;
    }

    public void Clear()
    {
        _head = null;
        _tail = null;
    }

    public int Peek()
    {
        if (_head == null)
        {
            throw new Exception("Очередь пуста");
        }

        return _head.Priority;
    }

    public bool IsEmpty()
    {
        return _head == null;
    }

    // Метод для фиксации состояния
    public PriorityQueueState GetState()
    {
        return new PriorityQueueState(this);
    }

    // Метод получения head
    public QueueItem GetHead()
    {
        return _head;
    }
}