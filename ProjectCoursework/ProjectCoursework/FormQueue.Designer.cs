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
            previousStepButton = new Button();
            nextStepButton = new Button();
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
            visualizationPictureBox = new PictureBox();
            menuStrip.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)visualizationPictureBox).BeginInit();
            SuspendLayout();
            // 
            // previousStepButton
            // 
            previousStepButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            previousStepButton.Location = new Point(12, 9);
            previousStepButton.Name = "previousStepButton";
            previousStepButton.Size = new Size(150, 46);
            previousStepButton.TabIndex = 0;
            previousStepButton.Text = "Предыдущий шаг";
            previousStepButton.UseVisualStyleBackColor = true;
            previousStepButton.Click += PreviousStepButton_Click;
            // 
            // nextStepButton
            // 
            nextStepButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            nextStepButton.Location = new Point(168, 9);
            nextStepButton.Name = "nextStepButton";
            nextStepButton.Size = new Size(150, 46);
            nextStepButton.TabIndex = 1;
            nextStepButton.Text = "Следующий шаг";
            nextStepButton.UseVisualStyleBackColor = true;
            nextStepButton.Click += NextStepButton_Click;
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
            panel1.Controls.Add(nextStepButton);
            panel1.Controls.Add(previousStepButton);
            panel1.Controls.Add(resetButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 383);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 67);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(dequeueButton);
            panel2.Controls.Add(enqueueButton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 120);
            panel2.TabIndex = 8;
            // 
            // visualizationPictureBox
            // 
            visualizationPictureBox.Dock = DockStyle.Fill;
            visualizationPictureBox.Location = new Point(0, 144);
            visualizationPictureBox.Name = "visualizationPictureBox";
            visualizationPictureBox.Size = new Size(800, 239);
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

        private Button previousStepButton;
        private Button nextStepButton;
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
    }
}