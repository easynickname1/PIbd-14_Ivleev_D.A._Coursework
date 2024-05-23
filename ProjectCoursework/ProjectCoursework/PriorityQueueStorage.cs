namespace ProjectCoursework;

public class PriorityQueueStorage
{
    private List<PriorityQueueState> _states = new List<PriorityQueueState>();

    public void AddState(PriorityQueueState state)
    {
        _states.Add(state);
    }

    public PriorityQueueState GetState(int index)
    {
        return _states[index];
    }

    public int Count()
    {
        return _states.Count;
    }

    public void Reset()
    {
        _states.Clear();
    }

    public void SaveToFile(string filePath)
    {
        // TODO
    }

    public void LoadFromFile(string filePath)
    {
        // TODO
    }
}
