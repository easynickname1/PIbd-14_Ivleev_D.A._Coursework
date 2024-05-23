using System;
using System.Windows.Forms;

namespace ProjectCoursework;

public partial class FormQueueInput : Form
{
    public QueueItem QueueItem { get; private set; }

    public FormQueueInput()
    {
        InitializeComponent();
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        // Проверка введенных данных
        if (!int.TryParse(maskedPriorityTextBox.Text, out var priority))
        {
            MessageBox.Show("Введите число.");
            return;
        }
        string value = valueTextBox.Text;

        QueueItem = new QueueItem(priority, value);

        // Закрытие формы с результатом OK
        DialogResult = DialogResult.OK;
        Close();
    }

    private void CancelButton_Click(object sender, EventArgs e)
    {
        // Закрытие формы с результатом Cancel
        DialogResult = DialogResult.Cancel;
        Close();
    }
}