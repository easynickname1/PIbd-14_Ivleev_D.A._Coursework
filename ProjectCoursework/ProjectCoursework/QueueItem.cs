namespace ProjectCoursework;
public class QueueItem
{
    public int Priority { get; set; }
    public string Value { get; set; }
    public QueueItem? Next { get; set; }
    public QueueItem? Prev { get; set; }

    public QueueItem(int priority, string value)
    {
        Priority = priority;
        Value = value;
    }
}