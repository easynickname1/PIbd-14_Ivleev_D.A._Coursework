namespace ProjectCoursework.src;

/// <summary>
/// Класс-визуализатор
/// </summary>
public class PriorityQueueVisualizer
{
    private readonly int _itemWidth = 100;
    private readonly int _itemHeight = 40;
    private readonly int _itemSpace = 50;
    private readonly int _arrowSize = 10;
    private readonly int _headTailBoxSize = 25;

    public Bitmap Visualize(QueueItem[] state)
    {
        int pictureWidth = (state.Length + 1) * _itemWidth + (state.Length - 1) * _itemSpace;
        int pictureHeight = _itemHeight + _arrowSize + _headTailBoxSize;

        Bitmap image = new Bitmap(pictureWidth, pictureHeight);
        Graphics g = Graphics.FromImage(image);

        // Узлы
        int x = _itemWidth / 2;
        for (int i = 0; i < state.Length; i++)
        {
            QueueItem item = state[i];

            // Элемент
            g.FillRectangle(Brushes.White, x, 0, _itemWidth, _itemHeight);
            g.DrawRectangle(Pens.LightBlue, x, 0, _itemWidth, _itemHeight);
            g.DrawString($"{item.Priority}", new Font("Arial", 9), Brushes.Black, new PointF(x + 10, 10));
            g.DrawLine(Pens.Black, x + 35, 0, x + 35, _itemHeight);
            g.DrawString($"{item.Value}", new Font("Arial", 9), Brushes.Black, new PointF(x + 40, 10));

            // Стрелка на следующий элемент
            if (i < state.Length - 1)
            {
                g.DrawLine(Pens.Black, x + _itemWidth, _itemHeight / 3, x + _itemWidth + _itemSpace, _itemHeight / 3);
                g.DrawLine(Pens.Black, x + _itemWidth + _itemSpace, _itemHeight / 3, x + _itemWidth + _itemSpace - _arrowSize, _itemHeight / 3 - _arrowSize);
                g.DrawLine(Pens.Black, x + _itemWidth + _itemSpace, _itemHeight / 3, x + _itemWidth + _itemSpace - _arrowSize, _itemHeight / 3 + _arrowSize);
            }

            // Стрелка на предыдущий элемент
            if (i > 0)
            {
                g.DrawLine(Pens.Black, x, Convert.ToInt32(_itemHeight / 1.5), x - _itemSpace, Convert.ToInt32(_itemHeight / 1.5));
                g.DrawLine(Pens.Black, x - _itemSpace, Convert.ToInt32(_itemHeight / 1.5), x - _itemSpace + _arrowSize, Convert.ToInt32(_itemHeight / 1.5) - _arrowSize);
                g.DrawLine(Pens.Black, x - _itemSpace, Convert.ToInt32(_itemHeight / 1.5), x - _itemSpace + _arrowSize, Convert.ToInt32(_itemHeight / 1.5) + _arrowSize);
            }

            x += _itemWidth + _itemSpace;
        }

        if (state.Length > 0)
        {
            // Голова
            g.FillRectangle(Brushes.LightCoral, 0, pictureHeight - _headTailBoxSize - 2, _headTailBoxSize, _headTailBoxSize);
            g.DrawRectangle(Pens.Black, 0, pictureHeight - _headTailBoxSize - 2, _headTailBoxSize, _headTailBoxSize);
            g.DrawString("Head", new Font("Arial", 7), Brushes.Black, new PointF(0, pictureHeight - _headTailBoxSize + 5));

            // Стрелка
            g.DrawLine(Pens.Black, _headTailBoxSize / 2, pictureHeight - _headTailBoxSize - 2, _headTailBoxSize / 2, _itemHeight / 2);
            g.DrawLine(Pens.Black, _headTailBoxSize / 2, _itemHeight / 2, _itemWidth / 2, _itemHeight / 2);
            g.DrawLine(Pens.Black, _itemWidth / 2, _itemHeight / 2, _itemWidth / 2 - _arrowSize, _itemHeight / 2 - _arrowSize);
            g.DrawLine(Pens.Black, _itemWidth / 2, _itemHeight / 2, _itemWidth / 2 - _arrowSize, _itemHeight / 2 + _arrowSize);

            // Хвост
            g.FillRectangle(Brushes.LightCoral, pictureWidth - _headTailBoxSize - 5, _itemHeight + 8, _headTailBoxSize, _headTailBoxSize);
            g.DrawRectangle(Pens.Black, pictureWidth - _headTailBoxSize - 5, _itemHeight + 8, _headTailBoxSize, _headTailBoxSize);
            g.DrawString("Tail", new Font("Arial", 7), Brushes.Black, new PointF(pictureWidth - _headTailBoxSize, pictureHeight - _headTailBoxSize + 5));

            // Стрелка
            g.DrawLine(Pens.Black, pictureWidth - _headTailBoxSize / 2 - 5, pictureHeight - _headTailBoxSize - 2, pictureWidth - _headTailBoxSize / 2 - 5, _itemHeight / 2);
            g.DrawLine(Pens.Black, pictureWidth - _headTailBoxSize / 2 - 5, _itemHeight / 2, pictureWidth - _itemWidth / 2, _itemHeight / 2);
            g.DrawLine(Pens.Black, pictureWidth - _itemSpace, _itemHeight / 2, pictureWidth - _itemSpace + _arrowSize, _itemHeight / 2 - _arrowSize);
            g.DrawLine(Pens.Black, pictureWidth - _itemSpace, _itemHeight / 2, pictureWidth - _itemSpace + _arrowSize, _itemHeight / 2 + _arrowSize);
        }

        return image;
    }

    // Метод для визуализации пошагово
    public Bitmap VisualizeStepByStep(QueueItem[] state, QueueItem newItem, int currentStep)
    {
        // Определяем ширину изображения
        int pictureWidth = (state.Length + 1) * _itemWidth + (state.Length) * _itemSpace;
        int pictureHeight = _itemHeight + _arrowSize + _headTailBoxSize;

        Bitmap image = new Bitmap(pictureWidth, pictureHeight);
        Graphics g = Graphics.FromImage(image);

        // Рисуем элементы очереди
        int x = _itemWidth / 2;
        for (int i = 0; i < state.Length; i++)
        {
            QueueItem item = state[i];

            // Элемент
            g.FillRectangle(Brushes.White, x, 0, _itemWidth, _itemHeight);
            g.DrawRectangle(Pens.LightBlue, x, 0, _itemWidth, _itemHeight);
            g.DrawString($"{item.Priority}", new Font("Arial", 9), Brushes.Black, new PointF(x + 10, 10));
            g.DrawLine(Pens.Black, x + 35, 0, x + 35, _itemHeight);
            g.DrawString($"{item.Value}", new Font("Arial", 9), Brushes.Black, new PointF(x + 40, 10));

            // Стрелка на следующий элемент
            if (i < state.Length - 1)
            {
                g.DrawLine(Pens.Black, x + _itemWidth, _itemHeight / 3, x + _itemWidth + _itemSpace, _itemHeight / 3);
                g.DrawLine(Pens.Black, x + _itemWidth + _itemSpace, _itemHeight / 3, x + _itemWidth + _itemSpace - _arrowSize, _itemHeight / 3 - _arrowSize);
                g.DrawLine(Pens.Black, x + _itemWidth + _itemSpace, _itemHeight / 3, x + _itemWidth + _itemSpace - _arrowSize, _itemHeight / 3 + _arrowSize);
            }

            // Стрелка на предыдущий элемент
            if (i > 0)
            {
                g.DrawLine(Pens.Black, x, Convert.ToInt32(_itemHeight / 1.5), x - _itemSpace, Convert.ToInt32(_itemHeight / 1.5));
                g.DrawLine(Pens.Black, x - _itemSpace, Convert.ToInt32(_itemHeight / 1.5), x - _itemSpace + _arrowSize, Convert.ToInt32(_itemHeight / 1.5) - _arrowSize);
                g.DrawLine(Pens.Black, x - _itemSpace, Convert.ToInt32(_itemHeight / 1.5), x - _itemSpace + _arrowSize, Convert.ToInt32(_itemHeight / 1.5) + _arrowSize);
            }

            x += _itemWidth + _itemSpace;
        }

        // Рисуем новый элемент
        if (currentStep < state.Length)
        {
            // Рисуем новый элемент на своем месте
            x = (currentStep + 1) * _itemWidth + (currentStep) * _itemSpace;
            g.FillRectangle(Brushes.White, x, 0, _itemWidth, _itemHeight);
            g.DrawRectangle(Pens.LightBlue, x, 0, _itemWidth, _itemHeight);
            g.DrawString($"{newItem.Priority}", new Font("Arial", 9), Brushes.Black, new PointF(x + 10, 10));
            g.DrawLine(Pens.Black, x + 35, 0, x + 35, _itemHeight);
            g.DrawString($"{newItem.Value}", new Font("Arial", 9), Brushes.Black, new PointF(x + 40, 10));

            // Стрелки на новый элемент 
            if (currentStep > 0)
            {
                g.DrawLine(Pens.Black, x, Convert.ToInt32(_itemHeight / 1.5), x - _itemSpace, Convert.ToInt32(_itemHeight / 1.5));
                g.DrawLine(Pens.Black, x - _itemSpace, Convert.ToInt32(_itemHeight / 1.5), x - _itemSpace + _arrowSize, Convert.ToInt32(_itemHeight / 1.5) - _arrowSize);
                g.DrawLine(Pens.Black, x - _itemSpace, Convert.ToInt32(_itemHeight / 1.5), x - _itemSpace + _arrowSize, Convert.ToInt32(_itemHeight / 1.5) + _arrowSize);
            }
            if (currentStep < state.Length - 1)
            {
                g.DrawLine(Pens.Black, x + _itemWidth, _itemHeight / 3, x + _itemWidth + _itemSpace, _itemHeight / 3);
                g.DrawLine(Pens.Black, x + _itemWidth + _itemSpace, _itemHeight / 3, x + _itemWidth + _itemSpace - _arrowSize, _itemHeight / 3 - _arrowSize);
                g.DrawLine(Pens.Black, x + _itemWidth + _itemSpace, _itemHeight / 3, x + _itemWidth + _itemSpace - _arrowSize, _itemHeight / 3 + _arrowSize);
            }
        }

        // Рисуем Head и Tail
        if (state.Length > 0)
        {
            // Голова
            g.FillRectangle(Brushes.LightCoral, 0, pictureHeight - _headTailBoxSize - 2, _headTailBoxSize, _headTailBoxSize);
            g.DrawRectangle(Pens.Black, 0, pictureHeight - _headTailBoxSize - 2, _headTailBoxSize, _headTailBoxSize);
            g.DrawString("Head", new Font("Arial", 7), Brushes.Black, new PointF(0, pictureHeight - _headTailBoxSize + 5));

            // Стрелка
            g.DrawLine(Pens.Black, _headTailBoxSize / 2, pictureHeight - _headTailBoxSize - 2, _headTailBoxSize / 2, _itemHeight / 2);
            g.DrawLine(Pens.Black, _headTailBoxSize / 2, _itemHeight / 2, _itemWidth / 2, _itemHeight / 2);
            g.DrawLine(Pens.Black, _itemWidth / 2, _itemHeight / 2, _itemWidth / 2 - _arrowSize, _itemHeight / 2 - _arrowSize);
            g.DrawLine(Pens.Black, _itemWidth / 2, _itemHeight / 2, _itemWidth / 2 - _arrowSize, _itemHeight / 2 + _arrowSize);

            // Хвост
            g.FillRectangle(Brushes.LightCoral, pictureWidth - _headTailBoxSize - 5, _itemHeight + 8, _headTailBoxSize, _headTailBoxSize);
            g.DrawRectangle(Pens.Black, pictureWidth - _headTailBoxSize - 5, _itemHeight + 8, _headTailBoxSize, _headTailBoxSize);
            g.DrawString("Tail", new Font("Arial", 7), Brushes.Black, new PointF(pictureWidth - _headTailBoxSize, pictureHeight - _headTailBoxSize + 5));

            // Стрелка
            g.DrawLine(Pens.Black, pictureWidth - _headTailBoxSize / 2 - 5, pictureHeight - _headTailBoxSize - 2, pictureWidth - _headTailBoxSize / 2 - 5, _itemHeight / 2);
            g.DrawLine(Pens.Black, pictureWidth - _headTailBoxSize / 2 - 5, _itemHeight / 2, pictureWidth - _itemWidth / 2, _itemHeight / 2);
            g.DrawLine(Pens.Black, pictureWidth - _itemSpace, _itemHeight / 2, pictureWidth - _itemSpace + _arrowSize, _itemHeight / 2 - _arrowSize);
            g.DrawLine(Pens.Black, pictureWidth - _itemSpace, _itemHeight / 2, pictureWidth - _itemSpace + _arrowSize, _itemHeight / 2 + _arrowSize);
        }

        return image;
    }
}