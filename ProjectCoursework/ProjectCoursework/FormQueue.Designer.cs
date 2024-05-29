namespace ProjectCoursework
{
    partial class FormQueue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            previousStateButton = new Button();
            nextStateButton = new Button();
            dequeueButton = new Button();
            enqueueButton = new Button();
            resetButton = new Button();
            menuStrip = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            saveMenuItem = new ToolStripMenuItem();
            loadMenuItem = new ToolStripMenuItem();
            infoMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            panel2 = new Panel();
            previousStepButton = new Button();
            nextStepButton = new Button();
            visualizationPictureBox = new PictureBox();
            menuStrip.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)visualizationPictureBox).BeginInit();
            SuspendLayout();
            // 
            // previousStateButton
            // 
            previousStateButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            previousStateButton.Location = new Point(12, 9);
            previousStateButton.Name = "previousStateButton";
            previousStateButton.Size = new Size(120, 46);
            previousStateButton.TabIndex = 0;
            previousStateButton.Text = "Предыдущее\r\nсостояние";
            previousStateButton.UseVisualStyleBackColor = true;
            previousStateButton.Click += PreviousStateButton_Click;
            // 
            // nextStateButton
            // 
            nextStateButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nextStateButton.Location = new Point(138, 9);
            nextStateButton.Name = "nextStateButton";
            nextStateButton.Size = new Size(120, 46);
            nextStateButton.TabIndex = 1;
            nextStateButton.Text = "Следующее\r\nсостояние";
            nextStateButton.UseVisualStyleBackColor = true;
            nextStateButton.Click += NextStateButton_Click;
            // 
            // dequeueButton
            // 
            dequeueButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dequeueButton.Location = new Point(405, 3);
            dequeueButton.Name = "dequeueButton";
            dequeueButton.Size = new Size(150, 46);
            dequeueButton.TabIndex = 2;
            dequeueButton.Text = "Извлечь элемент";
            dequeueButton.UseVisualStyleBackColor = true;
            dequeueButton.Click += DequeueButton_Click;
            // 
            // enqueueButton
            // 
            enqueueButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            enqueueButton.Location = new Point(249, 3);
            enqueueButton.Name = "enqueueButton";
            enqueueButton.Size = new Size(150, 46);
            enqueueButton.TabIndex = 3;
            enqueueButton.Text = "Добавить элемент";
            enqueueButton.UseVisualStyleBackColor = true;
            enqueueButton.Click += EnqueueButton_Click;
            // 
            // resetButton
            // 
            resetButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            resetButton.Location = new Point(638, 9);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(150, 46);
            resetButton.TabIndex = 4;
            resetButton.Text = "Очистить очередь";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += ResetButton_Click;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, infoMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 5;
            menuStrip.Text = "menuStrip";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveMenuItem, loadMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // saveMenuItem
            // 
            saveMenuItem.Name = "saveMenuItem";
            saveMenuItem.Size = new Size(133, 22);
            saveMenuItem.Text = "Сохранить";
            saveMenuItem.Click += SaveMenuItem_Click;
            // 
            // loadMenuItem
            // 
            loadMenuItem.Name = "loadMenuItem";
            loadMenuItem.Size = new Size(133, 22);
            loadMenuItem.Text = "Загрузить";
            loadMenuItem.Click += LoadMenuItem_Click;
            // 
            // infoMenuItem
            // 
            infoMenuItem.Name = "infoMenuItem";
            infoMenuItem.Size = new Size(65, 20);
            infoMenuItem.Text = "Справка";
            infoMenuItem.Click += InfoMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(nextStateButton);
            panel1.Controls.Add(previousStateButton);
            panel1.Controls.Add(resetButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 383);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 67);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(previousStepButton);
            panel2.Controls.Add(nextStepButton);
            panel2.Controls.Add(dequeueButton);
            panel2.Controls.Add(enqueueButton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 101);
            panel2.TabIndex = 8;
            // 
            // previousStepButton
            // 
            previousStepButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            previousStepButton.Location = new Point(279, 52);
            previousStepButton.Name = "previousStepButton";
            previousStepButton.Size = new Size(120, 32);
            previousStepButton.TabIndex = 5;
            previousStepButton.Text = "Шаг назад";
            previousStepButton.UseVisualStyleBackColor = true;
            previousStepButton.Visible = false;
            previousStepButton.Click += PreviousStepButton_Click;
            // 
            // nextStepButton
            // 
            nextStepButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nextStepButton.Location = new Point(405, 52);
            nextStepButton.Name = "nextStepButton";
            nextStepButton.Size = new Size(120, 32);
            nextStepButton.TabIndex = 4;
            nextStepButton.Text = "Шаг вперед";
            nextStepButton.UseVisualStyleBackColor = true;
            nextStepButton.Visible = false;
            nextStepButton.Click += NextStepButton_Click;
            // 
            // visualizationPictureBox
            // 
            visualizationPictureBox.Dock = DockStyle.Fill;
            visualizationPictureBox.Location = new Point(0, 125);
            visualizationPictureBox.Name = "visualizationPictureBox";
            visualizationPictureBox.Size = new Size(800, 258);
            visualizationPictureBox.TabIndex = 9;
            visualizationPictureBox.TabStop = false;
            // 
            // FormQueue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(visualizationPictureBox);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "FormQueue";
            Text = "Визуализация АТД приоритетная очередь, реализованного на основе двусвязного списка";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)visualizationPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button previousStateButton;
        private Button nextStateButton;
        private Button dequeueButton;
        private Button enqueueButton;
        private Button resetButton;
        private MenuStrip menuStrip;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem saveMenuItem;
        private ToolStripMenuItem loadMenuItem;
        private Panel panel1;
        private Panel panel2;
        private ToolStripMenuItem infoMenuItem;
        private PictureBox visualizationPictureBox;
        private Button previousStepButton;
        private Button nextStepButton;
    }
}