using ProjectCoursework.src;

namespace ProjectCoursework;

/// <summary>
/// Главная форма, на которой визуализируется работа класса путем последовательного отображения состояний из списка состояний
/// </summary>
public partial class FormQueue : Form
{
    private PriorityQueueManager _queueManager;
    private PriorityQueueVisualizer _visualizer;
    private int _currentState;
    private int _currentStep;
    QueueItem addedQueueItem;

    public FormQueue()
    {
        InitializeComponent();
        _queueManager = new PriorityQueueManager();
        _visualizer = new PriorityQueueVisualizer();
        _currentState = 0;
    }

    private void EnqueueButton_Click(object sender, EventArgs e)
    {
        if (_queueManager.GetCurrentState().QueueItems.Length > 4)
        {
            MessageBox.Show("Очередь переполнена");
            return;
        }

        // Вызов формы ввода для получения данных
        FormQueueInput formQueueInput = new FormQueueInput();
        if (formQueueInput.ShowDialog() == DialogResult.OK)
        {
            _currentStep = 0;
            addedQueueItem = _queueManager.Enqueue(formQueueInput.QueueItem);
            
            nextStepButton.Visible = true;
            previousStepButton.Visible = true;
            nextStateButton.Enabled = false;
            previousStateButton.Enabled = false;

            UpdateVisualizationByStep();
            _currentState++;
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
                QueueItem item = _queueManager.Dequeue();
                MessageBox.Show($"Извлечен элемент: Приоритет: {item.Priority}, Значение: {item.Value}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Очередь пуста");
                return;
            }
            UpdateVisualization();
            _currentState++;
        }
    }

    private void NextStateButton_Click(object sender, EventArgs e)
    {
        if (_currentState < _queueManager.GetStateCount() - 1)
        {
            _currentState++;
            UpdateVisualization(_currentState);
        }
        else
        {
            MessageBox.Show("Достигнут конец последовательности");
        }
    }

    private void PreviousStateButton_Click(object sender, EventArgs e)
    {
        if (_currentState > 0)
        {
            _currentState--;
            UpdateVisualization(_currentState);
        }
        else
        {
            MessageBox.Show("Начальное состояние");
        }
    }

    private void NextStepButton_Click(object sender, EventArgs e)
    {
        if (_currentStep < 4)
        {
            _currentStep++;
            UpdateVisualizationByStep();
        }
        else
        {
            nextStepButton.Visible = false;
            previousStepButton.Visible = false;
            nextStateButton.Enabled = true;
            previousStateButton.Enabled = true;
            UpdateVisualization();
        }
    }

    private void PreviousStepButton_Click(object sender, EventArgs e)
    {
        if (_currentStep > 0)
        {
            _currentStep--;
            UpdateVisualizationByStep();
        }
        else
        {
            nextStepButton.Visible = false;
            previousStepButton.Visible = false;
            nextStateButton.Enabled = true;
            previousStateButton.Enabled = true;
            UpdateVisualization();
        }
    }

    private void ResetButton_Click(object sender, EventArgs e)
    {
        _queueManager.Reset();
        _currentState = 0;
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
            _currentState = _queueManager.GetStateCount() - 1;
            UpdateVisualization(_currentState);
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

    private void UpdateVisualizationByStep()
    {
        if (addedQueueItem.Prev == null && _currentStep == 2) _currentStep++;
        if (addedQueueItem.Next == null && _currentStep == 3) _currentStep++;
        visualizationPictureBox.Image = _visualizer.VisualizeByStep(_queueManager.GetCurrentState().QueueItems, addedQueueItem, _currentStep);
    }
}