namespace ProjectCoursework.src;

/// <summary>
/// Класс-визуализатор
/// </summary>
public class PriorityQueueVisualizer
{
    private readonly int _elWidth = 100;
    private readonly int _elHeight = 40;
    private readonly int _elSpace = 50;
    private readonly int _arrowSize = 10;
    private readonly int _headTailBoxSize = 25;

    public Bitmap Visualize(QueueItem[] state)
    {
        int pictureWidth = (state.Length + 1) * _elWidth + (state.Length - 1) * _elSpace;
        int pictureHeight = _elHeight * 3 + _arrowSize + _headTailBoxSize;

        Bitmap image = new Bitmap(pictureWidth, pictureHeight);
        Graphics g = Graphics.FromImage(image);

        // Узлы
        int x = _elWidth / 2;
        for (int i = 0; i < state.Length; i++)
        {
            QueueItem el = state[i];

            // Элемент
            g.FillRectangle(Brushes.White, x, _elHeight, _elWidth, _elHeight);
            g.DrawRectangle(Pens.LightBlue, x, _elHeight, _elWidth, _elHeight);
            g.DrawString($"{el.Priority}", new Font("Arial", 9), Brushes.Black, new PointF(x + 10, _elHeight + 10));
            g.DrawLine(Pens.Black, x + 35, _elHeight, x + 35, _elHeight * 2);
            g.DrawString($"{el.Value}", new Font("Arial", 9), Brushes.Black, new PointF(x + 40, _elHeight + 10));

            // Стрелка на следующий элемент
            if (i < state.Length - 1)
            {
                g.DrawLine(Pens.Black, x + _elWidth, _elHeight * 2 - (_elHeight / 3), x + _elWidth + _elSpace, _elHeight * 2 - (_elHeight / 3));
                g.DrawLine(Pens.Black, x + _elWidth + _elSpace, _elHeight * 2 - (_elHeight / 3), x + _elWidth + _elSpace - _arrowSize, _elHeight * 2 - (_elHeight / 3) - _arrowSize);
                g.DrawLine(Pens.Black, x + _elWidth + _elSpace, _elHeight * 2 - (_elHeight / 3), x + _elWidth + _elSpace - _arrowSize, _elHeight * 2 - (_elHeight / 3) + _arrowSize);
            }

            // Стрелка на предыдущий элемент
            if (i > 0)
            {
                g.DrawLine(Pens.Black, x, Convert.ToInt32(_elHeight * 2 - _elHeight / 1.5), x - _elSpace, Convert.ToInt32(_elHeight * 2 - _elHeight / 1.5));
                g.DrawLine(Pens.Black, x - _elSpace, Convert.ToInt32(_elHeight * 2 - _elHeight / 1.5), x - _elSpace + _arrowSize, Convert.ToInt32(_elHeight * 2 - _elHeight / 1.5) - _arrowSize);
                g.DrawLine(Pens.Black, x - _elSpace, Convert.ToInt32(_elHeight * 2 - _elHeight / 1.5), x - _elSpace + _arrowSize, Convert.ToInt32(_elHeight * 2 - _elHeight / 1.5) + _arrowSize);
            }

            x += _elWidth + _elSpace;
        }

        if (state.Length > 0)
        {
            // Голова
            g.FillRectangle(Brushes.LightCoral, 0, pictureHeight - _headTailBoxSize - 2, _headTailBoxSize, _headTailBoxSize);
            g.DrawRectangle(Pens.Black, 0, pictureHeight - _headTailBoxSize - 2, _headTailBoxSize, _headTailBoxSize);
            g.DrawString("Head", new Font("Arial", 7), Brushes.Black, new PointF(0, pictureHeight - _headTailBoxSize + 5));

            // Стрелка
            g.DrawLine(Pens.Black, _headTailBoxSize / 2, pictureHeight - _headTailBoxSize - 2, _headTailBoxSize / 2, _elHeight * 2 - _elHeight / 2);
            g.DrawLine(Pens.Black, _headTailBoxSize / 2, _elHeight * 2 - _elHeight / 2, _elWidth / 2, _elHeight * 2 - _elHeight / 2);
            g.DrawLine(Pens.Black, _elWidth / 2, _elHeight * 2 - _elHeight / 2, _elWidth / 2 - _arrowSize, _elHeight * 2 - _elHeight / 2 - _arrowSize);
            g.DrawLine(Pens.Black, _elWidth / 2, _elHeight * 2 - _elHeight / 2, _elWidth / 2 - _arrowSize, _elHeight * 2 - _elHeight / 2 + _arrowSize);

            // Хвост
            g.FillRectangle(Brushes.LightCoral, pictureWidth - _headTailBoxSize - 2, pictureHeight - _headTailBoxSize - 2, _headTailBoxSize, _headTailBoxSize);
            g.DrawRectangle(Pens.Black, pictureWidth - _headTailBoxSize - 2, pictureHeight - _headTailBoxSize - 2, _headTailBoxSize, _headTailBoxSize);
            g.DrawString("Tail", new Font("Arial", 7), Brushes.Black, new PointF(pictureWidth - _headTailBoxSize + 2, pictureHeight - _headTailBoxSize + 5));

            // Стрелка
            g.DrawLine(Pens.Black, pictureWidth - _headTailBoxSize / 2 - 2, pictureHeight - _headTailBoxSize - 2, pictureWidth - _headTailBoxSize / 2 - 2, _elHeight * 2 - _elHeight / 2);
            g.DrawLine(Pens.Black, pictureWidth - _headTailBoxSize / 2 - 2, _elHeight * 2 - _elHeight / 2, pictureWidth - _elWidth / 2, _elHeight * 2 - _elHeight / 2);
            g.DrawLine(Pens.Black, pictureWidth - _elSpace, _elHeight * 2 - _elHeight / 2, pictureWidth - _elSpace + _arrowSize, _elHeight * 2 - _elHeight / 2 - _arrowSize);
            g.DrawLine(Pens.Black, pictureWidth - _elSpace, _elHeight * 2 - _elHeight / 2, pictureWidth - _elSpace + _arrowSize, _elHeight * 2 - _elHeight / 2 + _arrowSize);
        }

        return image;
    }

    // Метод для визуализации пошагово
    public Bitmap VisualizeByStep(QueueItem[] state, QueueItem addedEl, int step)
    {
        int pictureWidth = (state.Length + 1) * _elWidth + (state.Length - 1) * _elSpace;
        int pictureHeight = _elHeight * 3 + _arrowSize + _headTailBoxSize;
        int addedElIndex = -1;
        bool hasAddedElIndex = false;

        Bitmap image = new Bitmap(pictureWidth, pictureHeight);
        Graphics g = Graphics.FromImage(image);

        for (int i = state.Length - 1; i >= 0; i--)
        {
            if (!hasAddedElIndex && state[i].Priority == addedEl.Priority)
            {
                addedElIndex = i;
                hasAddedElIndex = true;
            }
        }

        // Узлы
        int x = _elWidth / 2;
        for (int i = 0; i < state.Length; i++)
        {
            QueueItem el = state[i];

            // Элемент
            if (i == addedElIndex)
            {
                g.FillRectangle(Brushes.White, x, 0, _elWidth, _elHeight);
                g.DrawRectangle(Pens.Red, x, 0, _elWidth, _elHeight);
                g.DrawString($"{el.Priority}", new Font("Arial", 9), Brushes.Black, new PointF(x + 10, 10));
                g.DrawLine(Pens.Black, x + 35, 0, x + 35, _elHeight);
                g.DrawString($"{el.Value}", new Font("Arial", 9), Brushes.Black, new PointF(x + 40, 10));
            }
            else
            {
                g.FillRectangle(Brushes.White, x, _elHeight, _elWidth, _elHeight);
                g.DrawRectangle(Pens.LightBlue, x, _elHeight, _elWidth, _elHeight);
                g.DrawString($"{el.Priority}", new Font("Arial", 9), Brushes.Black, new PointF(x + 10, _elHeight + 10));
                g.DrawLine(Pens.Black, x + 35, _elHeight, x + 35, _elHeight * 2);
                g.DrawString($"{el.Value}", new Font("Arial", 9), Brushes.Black, new PointF(x + 40, _elHeight + 10));
            }

            // Стрелка на следующий элемент
            if (i < state.Length - 1)
            {
                if (i + 1 == addedElIndex && step > 0)
                {
                    g.DrawLine(Pens.Black, x + _elWidth, _elHeight * 2 - (_elHeight / 3), x + _elWidth + _elSpace, _elHeight - (_elHeight / 3));
                    g.DrawLine(Pens.Black, x + _elWidth + _elSpace, _elHeight - (_elHeight / 3), x + _elWidth + _elSpace - (_arrowSize * 2), _elHeight - (_elHeight / 3));
                    g.DrawLine(Pens.Black, x + _elWidth + _elSpace, _elHeight - (_elHeight / 3), x + _elWidth + _elSpace - (_arrowSize / 2), _elHeight - (_elHeight / 3) + _arrowSize * 2);
                }
                else if (i == addedElIndex && step > 2)
                {
                    g.DrawLine(Pens.Black, x + _elWidth, _elHeight - (_elHeight / 3), x + _elWidth + _elSpace, _elHeight * 2 - (_elHeight / 3));
                    g.DrawLine(Pens.Black, x + _elWidth + _elSpace, _elHeight * 2 - (_elHeight / 3), x + _elWidth + _elSpace - (_arrowSize * 2), _elHeight * 2 - (_elHeight / 3));
                    g.DrawLine(Pens.Black, x + _elWidth + _elSpace, _elHeight * 2 - (_elHeight / 3), x + _elWidth + _elSpace - (_arrowSize / 2), _elHeight * 2 - (_elHeight / 3) - _arrowSize * 2);
                }
                else if (i + 1 != addedElIndex && i != addedElIndex)
                {
                    g.DrawLine(Pens.Black, x + _elWidth, _elHeight * 2 - (_elHeight / 3), x + _elWidth + _elSpace, _elHeight * 2 - (_elHeight / 3));
                    g.DrawLine(Pens.Black, x + _elWidth + _elSpace, _elHeight * 2 - (_elHeight / 3), x + _elWidth + _elSpace - _arrowSize, _elHeight * 2 - (_elHeight / 3) - _arrowSize);
                    g.DrawLine(Pens.Black, x + _elWidth + _elSpace, _elHeight * 2 - (_elHeight / 3), x + _elWidth + _elSpace - _arrowSize, _elHeight * 2 - (_elHeight / 3) + _arrowSize);
                }
            }

            // Стрелка на предыдущий элемент
            if (i > 0)
            {
                if (i == addedElIndex && step > 1)
                {
                    g.DrawLine(Pens.Black, x, Convert.ToInt32(_elHeight - _elHeight / 1.5), x - _elSpace, Convert.ToInt32(_elHeight * 2 - _elHeight / 1.5));
                    g.DrawLine(Pens.Black, x - _elSpace, Convert.ToInt32(_elHeight * 2 - _elHeight / 1.5), x - _elSpace + _arrowSize * 2, Convert.ToInt32(_elHeight * 2 - _elHeight / 1.5));
                    g.DrawLine(Pens.Black, x - _elSpace, Convert.ToInt32(_elHeight * 2 - _elHeight / 1.5), x - _elSpace + _arrowSize / 2, Convert.ToInt32(_elHeight * 2 - _elHeight / 1.5) - _arrowSize * 2);
                }
                else if (i - 1 == addedElIndex && step > 3)
                {
                    g.DrawLine(Pens.Black, x, Convert.ToInt32(_elHeight * 2 - _elHeight / 1.5), x - _elSpace, Convert.ToInt32(_elHeight - _elHeight / 1.5));
                    g.DrawLine(Pens.Black, x - _elSpace, Convert.ToInt32(_elHeight - _elHeight / 1.5), x - _elSpace + _arrowSize * 2, Convert.ToInt32(_elHeight - _elHeight / 1.5));
                    g.DrawLine(Pens.Black, x - _elSpace, Convert.ToInt32(_elHeight - _elHeight / 1.5), x - _elSpace + _arrowSize / 2, Convert.ToInt32(_elHeight - _elHeight / 1.5) + _arrowSize * 2);
                }
                else if (i - 1 != addedElIndex && i != addedElIndex)
                {
                    g.DrawLine(Pens.Black, x, Convert.ToInt32(_elHeight * 2 - _elHeight / 1.5), x - _elSpace, Convert.ToInt32(_elHeight * 2 - _elHeight / 1.5));
                    g.DrawLine(Pens.Black, x - _elSpace, Convert.ToInt32(_elHeight * 2 - _elHeight / 1.5), x - _elSpace + _arrowSize, Convert.ToInt32(_elHeight * 2 - _elHeight / 1.5) - _arrowSize);
                    g.DrawLine(Pens.Black, x - _elSpace, Convert.ToInt32(_elHeight * 2 - _elHeight / 1.5), x - _elSpace + _arrowSize, Convert.ToInt32(_elHeight * 2 - _elHeight / 1.5) + _arrowSize);
                }
            }

            x += _elWidth + _elSpace;
        }

        if (state.Length > 0)
        {
            // Голова
            g.FillRectangle(Brushes.LightCoral, 0, pictureHeight - _headTailBoxSize - 2, _headTailBoxSize, _headTailBoxSize);
            g.DrawRectangle(Pens.Black, 0, pictureHeight - _headTailBoxSize - 2, _headTailBoxSize, _headTailBoxSize);
            g.DrawString("Head", new Font("Arial", 7), Brushes.Black, new PointF(0, pictureHeight - _headTailBoxSize + 5));

            // Стрелка
            if (addedElIndex == 0)
            {
                if (step > 0)
                {
                    g.DrawLine(Pens.Black, _headTailBoxSize / 2, pictureHeight - _headTailBoxSize - 2, _headTailBoxSize / 2, _elHeight * 2 - _elHeight / 2);
                    g.DrawLine(Pens.Black, _headTailBoxSize / 2, _elHeight * 2 - _elHeight / 2, _elWidth / 2, _elHeight - _elHeight / 2);
                    g.DrawLine(Pens.Black, _elWidth / 2, _elHeight - _elHeight / 2, _elWidth / 2 - _arrowSize * 2, _elHeight - _elHeight / 2);
                    g.DrawLine(Pens.Black, _elWidth / 2, _elHeight - _elHeight / 2, _elWidth / 2 - _arrowSize / 2, _elHeight - _elHeight / 2 + _arrowSize * 2);
                }
            }
            else
            {
                g.DrawLine(Pens.Black, _headTailBoxSize / 2, pictureHeight - _headTailBoxSize - 2, _headTailBoxSize / 2, _elHeight * 2 - _elHeight / 2);
                g.DrawLine(Pens.Black, _headTailBoxSize / 2, _elHeight * 2 - _elHeight / 2, _elWidth / 2, _elHeight * 2 - _elHeight / 2);
                g.DrawLine(Pens.Black, _elWidth / 2, _elHeight * 2 - _elHeight / 2, _elWidth / 2 - _arrowSize, _elHeight * 2 - _elHeight / 2 - _arrowSize);
                g.DrawLine(Pens.Black, _elWidth / 2, _elHeight * 2 - _elHeight / 2, _elWidth / 2 - _arrowSize, _elHeight * 2 - _elHeight / 2 + _arrowSize);
            }

            // Хвост
            g.FillRectangle(Brushes.LightCoral, pictureWidth - _headTailBoxSize - 2, pictureHeight - _headTailBoxSize - 2, _headTailBoxSize, _headTailBoxSize);
            g.DrawRectangle(Pens.Black, pictureWidth - _headTailBoxSize - 2, pictureHeight - _headTailBoxSize - 2, _headTailBoxSize, _headTailBoxSize);
            g.DrawString("Tail", new Font("Arial", 7), Brushes.Black, new PointF(pictureWidth - _headTailBoxSize + 2, pictureHeight - _headTailBoxSize + 5));

            // Стрелка
            if (addedElIndex == state.Length - 1)
            {
                if (step > 3)
                {
                    g.DrawLine(Pens.Black, pictureWidth - _headTailBoxSize / 2 - 2, pictureHeight - _headTailBoxSize - 2, pictureWidth - _headTailBoxSize / 2 - 2, _elHeight * 2 - _elHeight / 2);
                    g.DrawLine(Pens.Black, pictureWidth - _headTailBoxSize / 2 - 2, _elHeight * 2 - _elHeight / 2, pictureWidth - _elWidth / 2, _elHeight- _elHeight / 2);
                    g.DrawLine(Pens.Black, pictureWidth - _elSpace, _elHeight - _elHeight / 2, pictureWidth - _elSpace + _arrowSize * 2, _elHeight - _elHeight / 2);
                    g.DrawLine(Pens.Black, pictureWidth - _elSpace, _elHeight - _elHeight / 2, pictureWidth - _elSpace + _arrowSize / 2, _elHeight - _elHeight / 2 + _arrowSize * 2);
                }
            }
            else
            {
                g.DrawLine(Pens.Black, pictureWidth - _headTailBoxSize / 2 - 2, pictureHeight - _headTailBoxSize - 2, pictureWidth - _headTailBoxSize / 2 - 2, _elHeight * 2 - _elHeight / 2);
                g.DrawLine(Pens.Black, pictureWidth - _headTailBoxSize / 2 - 2, _elHeight * 2 - _elHeight / 2, pictureWidth - _elWidth / 2, _elHeight * 2 - _elHeight / 2);
                g.DrawLine(Pens.Black, pictureWidth - _elSpace, _elHeight * 2 - _elHeight / 2, pictureWidth - _elSpace + _arrowSize, _elHeight * 2 - _elHeight / 2 - _arrowSize);
                g.DrawLine(Pens.Black, pictureWidth - _elSpace, _elHeight * 2 - _elHeight / 2, pictureWidth - _elSpace + _arrowSize, _elHeight * 2 - _elHeight / 2 + _arrowSize);
            }
        }
        return image;
    }
}