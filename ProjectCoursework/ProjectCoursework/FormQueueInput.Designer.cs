namespace ProjectCoursework
{
    partial class FormQueueInput
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
            cancelButton = new Button();
            addButton = new Button();
            valueTextBox = new TextBox();
            priorityLabel = new Label();
            valueLabel = new Label();
            maskedPriorityTextBox = new MaskedTextBox();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(172, 131);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 37);
            cancelButton.TabIndex = 0;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(91, 131);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 37);
            addButton.TabIndex = 1;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // valueTextBox
            // 
            valueTextBox.Location = new Point(25, 93);
            valueTextBox.MaxLength = 7;
            valueTextBox.Name = "valueTextBox";
            valueTextBox.Size = new Size(278, 23);
            valueTextBox.TabIndex = 3;
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new Point(25, 22);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new Size(67, 15);
            priorityLabel.TabIndex = 4;
            priorityLabel.Text = "Приоритет";
            // 
            // valueLabel
            // 
            valueLabel.AutoSize = true;
            valueLabel.Location = new Point(25, 75);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new Size(60, 15);
            valueLabel.TabIndex = 5;
            valueLabel.Text = "Значение";
            // 
            // maskedPriorityTextBox
            // 
            maskedPriorityTextBox.Location = new Point(25, 40);
            maskedPriorityTextBox.Mask = "00";
            maskedPriorityTextBox.Name = "maskedPriorityTextBox";
            maskedPriorityTextBox.Size = new Size(278, 23);
            maskedPriorityTextBox.TabIndex = 6;
            maskedPriorityTextBox.ValidatingType = typeof(int);
            // 
            // FormQueueInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 189);
            Controls.Add(maskedPriorityTextBox);
            Controls.Add(valueLabel);
            Controls.Add(priorityLabel);
            Controls.Add(valueTextBox);
            Controls.Add(addButton);
            Controls.Add(cancelButton);
            Name = "FormQueueInput";
            Text = "Добавление элемента";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button addButton;
        private TextBox valueTextBox;
        private Label priorityLabel;
        private Label valueLabel;
        private MaskedTextBox maskedPriorityTextBox;
    }
}