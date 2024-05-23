namespace ProjectCoursework;

public class PriorityQueue
{
    private QueueItem? _head;
    private QueueItem? _tail;

    public PriorityQueue()
    {
        _head = null;
        _tail = null;
    }

    public void Enqueue(QueueItem item)
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
            QueueItem newNode = new QueueItem(item.Priority, item.Value) { Prev = current, Next = current.Next };
            current.Next = newNode;
            if (newNode.Next == null)
            {
                _tail = newNode;
            }
            else
            {
                newNode.Next.Prev = newNode;
            }
        }
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

    //// Метод для возвращения в состояние
    //public void RestoreState(PriorityQueueState state)
    //{
    //    Clear();
    //    if (state.QueueItems != null)
    //    {
    //        _head = new QueueItem(state.QueueItems[0]);
    //        QueueItem current = _head;
    //        for (int i = 1; i < state.Nodes.Length; i++)
    //        {
    //            current.Next = new QueueItem(state.QueueItems[i]) { Prev = current };
    //            current = current.Next;
    //        }
    //        _tail = current;
    //    }
    //}
}
