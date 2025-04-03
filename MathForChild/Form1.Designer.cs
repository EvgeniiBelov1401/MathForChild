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
            components = new System.ComponentModel.Container();
            groupBoxOptions = new GroupBox();
            textBoxTourCount = new TextBox();
            labelTourCount = new Label();
            buttonOptions = new Button();
            checkBoxHintShow = new CheckBox();
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
            timer1 = new System.Windows.Forms.Timer(components);
            groupBoxOptions.SuspendLayout();
            groupBoxTask.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxOptions
            // 
            groupBoxOptions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxOptions.Controls.Add(textBoxTourCount);
            groupBoxOptions.Controls.Add(labelTourCount);
            groupBoxOptions.Controls.Add(buttonOptions);
            groupBoxOptions.Controls.Add(checkBoxHintShow);
            groupBoxOptions.Location = new Point(21, 24);
            groupBoxOptions.Margin = new Padding(3, 2, 3, 2);
            groupBoxOptions.Name = "groupBoxOptions";
            groupBoxOptions.Padding = new Padding(3, 2, 3, 2);
            groupBoxOptions.Size = new Size(1211, 94);
            groupBoxOptions.TabIndex = 0;
            groupBoxOptions.TabStop = false;
            groupBoxOptions.Text = "Настройки";
            // 
            // textBoxTourCount
            // 
            textBoxTourCount.Location = new Point(274, 28);
            textBoxTourCount.Margin = new Padding(3, 2, 3, 2);
            textBoxTourCount.Name = "textBoxTourCount";
            textBoxTourCount.Size = new Size(45, 23);
            textBoxTourCount.TabIndex = 3;
            textBoxTourCount.TextAlign = HorizontalAlignment.Center;
            // 
            // labelTourCount
            // 
            labelTourCount.AutoSize = true;
            labelTourCount.ImageAlign = ContentAlignment.MiddleRight;
            labelTourCount.Location = new Point(182, 30);
            labelTourCount.Name = "labelTourCount";
            labelTourCount.Size = new Size(86, 15);
            labelTourCount.TabIndex = 2;
            labelTourCount.Text = "Кол-во туров: ";
            // 
            // buttonOptions
            // 
            buttonOptions.Location = new Point(28, 66);
            buttonOptions.Margin = new Padding(3, 2, 3, 2);
            buttonOptions.Name = "buttonOptions";
            buttonOptions.Size = new Size(126, 22);
            buttonOptions.TabIndex = 1;
            buttonOptions.Text = "Применить";
            buttonOptions.UseVisualStyleBackColor = true;
            buttonOptions.Click += buttonOptions_Click;
            // 
            // checkBoxHintShow
            // 
            checkBoxHintShow.AutoSize = true;
            checkBoxHintShow.Location = new Point(28, 30);
            checkBoxHintShow.Margin = new Padding(3, 2, 3, 2);
            checkBoxHintShow.Name = "checkBoxHintShow";
            checkBoxHintShow.Size = new Size(128, 19);
            checkBoxHintShow.TabIndex = 0;
            checkBoxHintShow.Text = "Показать подсказу";
            checkBoxHintShow.UseVisualStyleBackColor = true;
            checkBoxHintShow.CheckedChanged += checkBoxHintShow_CheckedChanged;
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
            groupBoxTask.Location = new Point(28, 126);
            groupBoxTask.Margin = new Padding(3, 2, 3, 2);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Padding = new Padding(3, 2, 3, 2);
            groupBoxTask.Size = new Size(889, 138);
            groupBoxTask.TabIndex = 1;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Задание";
            // 
            // labelCheckResult
            // 
            labelCheckResult.AutoSize = true;
            labelCheckResult.Location = new Point(665, 30);
            labelCheckResult.Name = "labelCheckResult";
            labelCheckResult.Size = new Size(0, 15);
            labelCheckResult.TabIndex = 5;
            labelCheckResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelHint
            // 
            labelHint.AutoSize = true;
            labelHint.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelHint.Location = new Point(252, 30);
            labelHint.Name = "labelHint";
            labelHint.Size = new Size(0, 21);
            labelHint.TabIndex = 2;
            labelHint.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonStart.Location = new Point(14, 24);
            buttonStart.Margin = new Padding(3, 2, 3, 2);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(203, 36);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Старт/Заново";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCalculate.Location = new Point(644, 90);
            buttonCalculate.Margin = new Padding(3, 2, 3, 2);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(203, 36);
            buttonCalculate.TabIndex = 4;
            buttonCalculate.Text = "Проверить результат";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // labelCharOperation
            // 
            labelCharOperation.AutoSize = true;
            labelCharOperation.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelCharOperation.Location = new Point(420, 54);
            labelCharOperation.Name = "labelCharOperation";
            labelCharOperation.Size = new Size(26, 25);
            labelCharOperation.TabIndex = 3;
            labelCharOperation.Text = "+";
            labelCharOperation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCharEqual
            // 
            labelCharEqual.AutoSize = true;
            labelCharEqual.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelCharEqual.Location = new Point(630, 54);
            labelCharEqual.Name = "labelCharEqual";
            labelCharEqual.Size = new Size(26, 25);
            labelCharEqual.TabIndex = 2;
            labelCharEqual.Text = "=";
            labelCharEqual.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(665, 54);
            textBoxResult.Margin = new Padding(3, 2, 3, 2);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(168, 32);
            textBoxResult.TabIndex = 3;
            textBoxResult.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxNum2
            // 
            textBoxNum2.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxNum2.Location = new Point(455, 54);
            textBoxNum2.Margin = new Padding(3, 2, 3, 2);
            textBoxNum2.Name = "textBoxNum2";
            textBoxNum2.Size = new Size(168, 32);
            textBoxNum2.TabIndex = 2;
            textBoxNum2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxNum1
            // 
            textBoxNum1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxNum1.Location = new Point(245, 54);
            textBoxNum1.Margin = new Padding(3, 2, 3, 2);
            textBoxNum1.Name = "textBoxNum1";
            textBoxNum1.Size = new Size(168, 32);
            textBoxNum1.TabIndex = 1;
            textBoxNum1.TextAlign = HorizontalAlignment.Center;
            // 
            // timer1
            // 
            timer1.Tick += Timer1_Tick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 715);
            Controls.Add(groupBoxTask);
            Controls.Add(groupBoxOptions);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            Text = "Математика для ребенка";
            groupBoxOptions.ResumeLayout(false);
            groupBoxOptions.PerformLayout();
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
        private CheckBox checkBoxHintShow;
        private Button buttonOptions;
        private System.Windows.Forms.Timer timer1;
        private Label labelTourCount;
        private TextBox textBoxTourCount;
    }
}
