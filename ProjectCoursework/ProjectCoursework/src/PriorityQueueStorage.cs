using System.Runtime.Serialization.Formatters.Binary;

namespace ProjectCoursework.src;

/// <summary>
/// Класс-хранилище
/// </summary>
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
        // Создание бинарного сериализатора
        BinaryFormatter formatter = new BinaryFormatter();

        // Открытие файла для записи
        using (FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        {
            // Сериализация списка состояний
#pragma warning disable SYSLIB0011 // Тип или член устарел
            formatter.Serialize(stream, _states);
#pragma warning restore SYSLIB0011 // Тип или член устарел
        }
    }

    public void LoadFromFile(string filePath)
    {
        // Создание бинарного сериализатора
        BinaryFormatter formatter = new BinaryFormatter();

        // Проверка существования файла
        if (!File.Exists(filePath))
        {
            return; // Выход, если файл не найден
        }

        // Открытие файла для чтения
        using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            // Десериализация списка состояний
#pragma warning disable SYSLIB0011 // Тип или член устарел
            _states = (List<PriorityQueueState>)formatter.Deserialize(stream);
#pragma warning restore SYSLIB0011 // Тип или член устарел
        }
    }
}