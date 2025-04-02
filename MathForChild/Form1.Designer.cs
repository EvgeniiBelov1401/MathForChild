namespace MathForChild
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxOptions = new GroupBox();
            groupBoxTask = new GroupBox();
            labelCheckResult = new Label();
            labelHint = new Label();
            buttonStart = new Button();
            buttonCalculate = new Button();
            labelCharOperation = new Label();
            labelCharEqual = new Label();
            textBoxResult = new TextBox();
            textBoxNum2 = new TextBox();
            textBoxNum1 = new TextBox();
            groupBoxTask.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxOptions
            // 
            groupBoxOptions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxOptions.Location = new Point(24, 32);
            groupBoxOptions.Name = "groupBoxOptions";
            groupBoxOptions.Size = new Size(1384, 125);
            groupBoxOptions.TabIndex = 0;
            groupBoxOptions.TabStop = false;
            groupBoxOptions.Text = "Настройки";
            // 
            // groupBoxTask
            // 
            groupBoxTask.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxTask.Controls.Add(labelCheckResult);
            groupBoxTask.Controls.Add(labelHint);
            groupBoxTask.Controls.Add(buttonStart);
            groupBoxTask.Controls.Add(buttonCalculate);
            groupBoxTask.Controls.Add(labelCharOperation);
            groupBoxTask.Controls.Add(labelCharEqual);
            groupBoxTask.Controls.Add(textBoxResult);
            groupBoxTask.Controls.Add(textBoxNum2);
            groupBoxTask.Controls.Add(textBoxNum1);
            groupBoxTask.Location = new Point(32, 168);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(1016, 184);
            groupBoxTask.TabIndex = 1;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Задание";
            // 
            // labelCheckResult
            // 
            labelCheckResult.AutoSize = true;
            labelCheckResult.Location = new Point(760, 40);
            labelCheckResult.Name = "labelCheckResult";
            labelCheckResult.Size = new Size(50, 20);
            labelCheckResult.TabIndex = 5;
            labelCheckResult.Text = "label1";
            labelCheckResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelHint
            // 
            labelHint.AutoSize = true;
            labelHint.Location = new Point(288, 40);
            labelHint.Name = "labelHint";
            labelHint.Size = new Size(50, 20);
            labelHint.TabIndex = 2;
            labelHint.Text = "label1";
            labelHint.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonStart.Location = new Point(16, 32);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(232, 48);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Старт/Заново";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCalculate.Location = new Point(736, 120);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(232, 48);
            buttonCalculate.TabIndex = 4;
            buttonCalculate.Text = "Проверить результат";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // labelCharOperation
            // 
            labelCharOperation.AutoSize = true;
            labelCharOperation.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelCharOperation.Location = new Point(480, 72);
            labelCharOperation.Name = "labelCharOperation";
            labelCharOperation.Size = new Size(30, 31);
            labelCharOperation.TabIndex = 3;
            labelCharOperation.Text = "+";
            labelCharOperation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCharEqual
            // 
            labelCharEqual.AutoSize = true;
            labelCharEqual.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelCharEqual.Location = new Point(720, 72);
            labelCharEqual.Name = "labelCharEqual";
            labelCharEqual.Size = new Size(30, 31);
            labelCharEqual.TabIndex = 2;
            labelCharEqual.Text = "=";
            labelCharEqual.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(760, 72);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(192, 39);
            textBoxResult.TabIndex = 3;
            textBoxResult.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxNum2
            // 
            textBoxNum2.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxNum2.Location = new Point(520, 72);
            textBoxNum2.Name = "textBoxNum2";
            textBoxNum2.Size = new Size(192, 39);
            textBoxNum2.TabIndex = 2;
            textBoxNum2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxNum1
            // 
            textBoxNum1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxNum1.Location = new Point(280, 72);
            textBoxNum1.Name = "textBoxNum1";
            textBoxNum1.Size = new Size(192, 39);
            textBoxNum1.TabIndex = 1;
            textBoxNum1.TextAlign = HorizontalAlignment.Center;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 953);
            Controls.Add(groupBoxTask);
            Controls.Add(groupBoxOptions);
            Name = "FormMain";
            Text = "Математика для ребенка";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxOptions;
        private GroupBox groupBoxTask;
        private Button buttonStart;
        private TextBox textBoxResult;
        private TextBox textBoxNum2;
        private TextBox textBoxNum1;
        private Button buttonCalculate;
        private Label labelCharOperation;
        private Label labelCharEqual;
        private Label labelCheckResult;
        private Label labelHint;
    }
}
