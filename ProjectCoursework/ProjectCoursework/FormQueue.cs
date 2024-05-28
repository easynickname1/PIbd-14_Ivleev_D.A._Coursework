using ProjectCoursework.src;

namespace ProjectCoursework;

/// <summary>
/// Главная форма, на которой визуализируется работа класса путем последовательного отображения состояний из списка состояний
/// </summary>
public partial class FormQueue : Form
{
    private PriorityQueueManager _queueManager;
    private PriorityQueueVisualizer _visualizer;
    private int _currentStep;

    public FormQueue()
    {
        InitializeComponent();
        _queueManager = new PriorityQueueManager();
        _visualizer = new PriorityQueueVisualizer();
        _currentStep = 0;
    }

    private void EnqueueButton_Click(object sender, EventArgs e)
    {
        // Вызов формы ввода для получения данных
        FormQueueInput formQueueInput = new FormQueueInput();
        if (formQueueInput.ShowDialog() == DialogResult.OK)
        {
            _queueManager.Enqueue(formQueueInput.QueueItem);
            UpdateVisualization();
            _currentStep++;
        }
    }

    private void DequeueButton_Click(object sender, EventArgs e)
    {
        if (_queueManager.GetStateCount() == 0)
        {
            MessageBox.Show("Очередь пуста");
        }
        else
        {
            try
            {
                QueueItem value = _queueManager.Dequeue();
                MessageBox.Show($"Извлечен элемент: Приоритет: {value.Priority}, Значение: {value.Value}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Очередь пуста");
                return;
            }
            UpdateVisualization();
            _currentStep++;
        }
    }

    private void NextStepButton_Click(object sender, EventArgs e)
    {
        if (_currentStep < _queueManager.GetStateCount() - 1)
        {
            _currentStep++;
            UpdateVisualization(_currentStep);
        }
        else
        {
            MessageBox.Show("Достигнут конец последовательности");
        }
    }

    private void PreviousStepButton_Click(object sender, EventArgs e)
    {
        if (_currentStep > 0)
        {
            _currentStep--;
            UpdateVisualization(_currentStep);
        }
        else
        {
            MessageBox.Show("Начальное состояние");
        }
    }

    private void ResetButton_Click(object sender, EventArgs e)
    {
        _queueManager.Reset();
        _currentStep = 0;
        UpdateVisualization();
    }

    private void SaveMenuItem_Click(object sender, EventArgs e)
    {
        // Вызов диалогового окна для выбора файла
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "Binary files (*.bin)|*.bin";
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            _queueManager.SaveToFile(saveFileDialog.FileName);
        }
    }

    private void LoadMenuItem_Click(object sender, EventArgs e)
    {
        // Вызов диалогового окна для выбора файла
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Binary files (*.bin)|*.bin";
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            _queueManager.LoadFromFile(openFileDialog.FileName);
            _currentStep = _queueManager.GetStateCount() - 1;
            UpdateVisualization(_currentStep);
        }
    }

    private void InfoMenuItem_Click(object sender, EventArgs e)
    {
        FormQueueInfo formQueueInfo = new FormQueueInfo();
        formQueueInfo.ShowDialog();
    }

    private void UpdateVisualization()
    {
        visualizationPictureBox.Image = _visualizer.Visualize(_queueManager.GetCurrentState().QueueItems);
    }

    private void UpdateVisualization(int step)
    {
        visualizationPictureBox.Image = _visualizer.Visualize(_queueManager.GetState(step).QueueItems);
    }
}