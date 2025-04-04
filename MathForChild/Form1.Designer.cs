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
            textBoxCartoonLink = new TextBox();
            checkBoxCartoonLink = new CheckBox();
            groupBoxOperation = new GroupBox();
            radioButtonSum = new RadioButton();
            radioButtonMinus = new RadioButton();
            textBoxValueTo = new TextBox();
            labelValueRangeTo = new Label();
            textBoxValueFrom = new TextBox();
            labelValueRangeFrom = new Label();
            textBoxTimeBetwenTours = new TextBox();
            labelTimeBetweenTours = new Label();
            textBoxTourCount = new TextBox();
            labelTourCount = new Label();
            buttonOptions = new Button();
            checkBoxHintShow = new CheckBox();
            groupBoxTask = new GroupBox();
            labelTourNumber = new Label();
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
            textBoxTestresult = new TextBox();
            pictureBoxForChild = new PictureBox();
            buttonCartoonStart = new Button();
            groupBoxOptions.SuspendLayout();
            groupBoxOperation.SuspendLayout();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForChild).BeginInit();
            SuspendLayout();
            // 
            // groupBoxOptions
            // 
            groupBoxOptions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxOptions.Controls.Add(textBoxCartoonLink);
            groupBoxOptions.Controls.Add(checkBoxCartoonLink);
            groupBoxOptions.Controls.Add(groupBoxOperation);
            groupBoxOptions.Controls.Add(textBoxValueTo);
            groupBoxOptions.Controls.Add(labelValueRangeTo);
            groupBoxOptions.Controls.Add(textBoxValueFrom);
            groupBoxOptions.Controls.Add(labelValueRangeFrom);
            groupBoxOptions.Controls.Add(textBoxTimeBetwenTours);
            groupBoxOptions.Controls.Add(labelTimeBetweenTours);
            groupBoxOptions.Controls.Add(textBoxTourCount);
            groupBoxOptions.Controls.Add(labelTourCount);
            groupBoxOptions.Controls.Add(buttonOptions);
            groupBoxOptions.Controls.Add(checkBoxHintShow);
            groupBoxOptions.Location = new Point(28, 28);
            groupBoxOptions.Margin = new Padding(3, 2, 3, 2);
            groupBoxOptions.Name = "groupBoxOptions";
            groupBoxOptions.Padding = new Padding(3, 2, 3, 2);
            groupBoxOptions.Size = new Size(1211, 94);
            groupBoxOptions.TabIndex = 0;
            groupBoxOptions.TabStop = false;
            groupBoxOptions.Text = "Настройки";
            // 
            // textBoxCartoonLink
            // 
            textBoxCartoonLink.Location = new Point(439, 64);
            textBoxCartoonLink.Name = "textBoxCartoonLink";
            textBoxCartoonLink.Size = new Size(450, 23);
            textBoxCartoonLink.TabIndex = 14;
            textBoxCartoonLink.Visible = false;
            // 
            // checkBoxCartoonLink
            // 
            checkBoxCartoonLink.AutoSize = true;
            checkBoxCartoonLink.Location = new Point(232, 66);
            checkBoxCartoonLink.Name = "checkBoxCartoonLink";
            checkBoxCartoonLink.Size = new Size(201, 19);
            checkBoxCartoonLink.TabIndex = 13;
            checkBoxCartoonLink.Text = "Поставить другой мультфильм:";
            checkBoxCartoonLink.UseVisualStyleBackColor = true;
            checkBoxCartoonLink.CheckedChanged += checkBoxCartoonLink_CheckedChanged;
            // 
            // groupBoxOperation
            // 
            groupBoxOperation.Controls.Add(radioButtonSum);
            groupBoxOperation.Controls.Add(radioButtonMinus);
            groupBoxOperation.Location = new Point(895, 12);
            groupBoxOperation.Name = "groupBoxOperation";
            groupBoxOperation.Size = new Size(130, 77);
            groupBoxOperation.TabIndex = 12;
            groupBoxOperation.TabStop = false;
            groupBoxOperation.Text = "Операции";
            // 
            // radioButtonSum
            // 
            radioButtonSum.AutoSize = true;
            radioButtonSum.Checked = true;
            radioButtonSum.Location = new Point(6, 22);
            radioButtonSum.Name = "radioButtonSum";
            radioButtonSum.Size = new Size(101, 19);
            radioButtonSum.TabIndex = 10;
            radioButtonSum.TabStop = true;
            radioButtonSum.Text = "Сложение (+)";
            radioButtonSum.UseVisualStyleBackColor = true;
            // 
            // radioButtonMinus
            // 
            radioButtonMinus.AutoSize = true;
            radioButtonMinus.Location = new Point(6, 46);
            radioButtonMinus.Name = "radioButtonMinus";
            radioButtonMinus.Size = new Size(102, 19);
            radioButtonMinus.TabIndex = 11;
            radioButtonMinus.Text = "Вычитание (-)";
            radioButtonMinus.UseVisualStyleBackColor = true;
            // 
            // textBoxValueTo
            // 
            textBoxValueTo.Location = new Point(783, 19);
            textBoxValueTo.Margin = new Padding(3, 2, 3, 2);
            textBoxValueTo.Name = "textBoxValueTo";
            textBoxValueTo.Size = new Size(45, 23);
            textBoxValueTo.TabIndex = 9;
            textBoxValueTo.TextAlign = HorizontalAlignment.Center;
            // 
            // labelValueRangeTo
            // 
            labelValueRangeTo.AutoSize = true;
            labelValueRangeTo.Location = new Point(761, 24);
            labelValueRangeTo.Name = "labelValueRangeTo";
            labelValueRangeTo.Size = new Size(20, 15);
            labelValueRangeTo.TabIndex = 8;
            labelValueRangeTo.Text = "до";
            // 
            // textBoxValueFrom
            // 
            textBoxValueFrom.Location = new Point(714, 19);
            textBoxValueFrom.Margin = new Padding(3, 2, 3, 2);
            textBoxValueFrom.Name = "textBoxValueFrom";
            textBoxValueFrom.Size = new Size(45, 23);
            textBoxValueFrom.TabIndex = 7;
            textBoxValueFrom.TextAlign = HorizontalAlignment.Center;
            // 
            // labelValueRangeFrom
            // 
            labelValueRangeFrom.AutoSize = true;
            labelValueRangeFrom.Location = new Point(646, 24);
            labelValueRangeFrom.Name = "labelValueRangeFrom";
            labelValueRangeFrom.Size = new Size(66, 15);
            labelValueRangeFrom.TabIndex = 6;
            labelValueRangeFrom.Text = "Цифры от:";
            // 
            // textBoxTimeBetwenTours
            // 
            textBoxTimeBetwenTours.Location = new Point(554, 19);
            textBoxTimeBetwenTours.Margin = new Padding(3, 2, 3, 2);
            textBoxTimeBetwenTours.Name = "textBoxTimeBetwenTours";
            textBoxTimeBetwenTours.Size = new Size(45, 23);
            textBoxTimeBetwenTours.TabIndex = 5;
            textBoxTimeBetwenTours.TextAlign = HorizontalAlignment.Center;
            // 
            // labelTimeBetweenTours
            // 
            labelTimeBetweenTours.AutoSize = true;
            labelTimeBetweenTours.Location = new Point(407, 22);
            labelTimeBetweenTours.Name = "labelTimeBetweenTours";
            labelTimeBetweenTours.Size = new Size(141, 15);
            labelTimeBetweenTours.TabIndex = 4;
            labelTimeBetweenTours.Text = "Время между турами(c):";
            // 
            // textBoxTourCount
            // 
            textBoxTourCount.Location = new Point(331, 19);
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
            labelTourCount.Location = new Point(239, 21);
            labelTourCount.Name = "labelTourCount";
            labelTourCount.Size = new Size(86, 15);
            labelTourCount.TabIndex = 2;
            labelTourCount.Text = "Кол-во туров: ";
            // 
            // buttonOptions
            // 
            buttonOptions.Location = new Point(6, 59);
            buttonOptions.Margin = new Padding(3, 2, 3, 2);
            buttonOptions.Name = "buttonOptions";
            buttonOptions.Size = new Size(126, 31);
            buttonOptions.TabIndex = 1;
            buttonOptions.Text = "Применить";
            buttonOptions.UseVisualStyleBackColor = true;
            buttonOptions.Click += buttonOptions_Click;
            // 
            // checkBoxHintShow
            // 
            checkBoxHintShow.AutoSize = true;
            checkBoxHintShow.Location = new Point(85, 18);
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
            groupBoxTask.Controls.Add(labelTourNumber);
            groupBoxTask.Controls.Add(labelCheckResult);
            groupBoxTask.Controls.Add(labelHint);
            groupBoxTask.Controls.Add(buttonStart);
            groupBoxTask.Controls.Add(buttonCalculate);
            groupBoxTask.Controls.Add(labelCharOperation);
            groupBoxTask.Controls.Add(labelCharEqual);
            groupBoxTask.Controls.Add(textBoxResult);
            groupBoxTask.Controls.Add(textBoxNum2);
            groupBoxTask.Controls.Add(textBoxNum1);
            groupBoxTask.Location = new Point(28, 148);
            groupBoxTask.Margin = new Padding(3, 2, 3, 2);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Padding = new Padding(3, 2, 3, 2);
            groupBoxTask.Size = new Size(889, 138);
            groupBoxTask.TabIndex = 1;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Задание";
            // 
            // labelTourNumber
            // 
            labelTourNumber.AutoSize = true;
            labelTourNumber.Location = new Point(833, 18);
            labelTourNumber.Name = "labelTourNumber";
            labelTourNumber.Size = new Size(0, 15);
            labelTourNumber.TabIndex = 6;
            labelTourNumber.TextAlign = ContentAlignment.MiddleCenter;
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
            buttonStart.Enabled = false;
            buttonStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonStart.Location = new Point(14, 24);
            buttonStart.Margin = new Padding(3, 2, 3, 2);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(203, 36);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Старт";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Enabled = false;
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
            textBoxResult.Enabled = false;
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
            textBoxNum2.BackColor = SystemColors.Control;
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
            textBoxNum1.BackColor = SystemColors.Control;
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
            // textBoxTestresult
            // 
            textBoxTestresult.BackColor = SystemColors.Control;
            textBoxTestresult.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxTestresult.Location = new Point(923, 155);
            textBoxTestresult.Multiline = true;
            textBoxTestresult.Name = "textBoxTestresult";
            textBoxTestresult.Size = new Size(309, 129);
            textBoxTestresult.TabIndex = 2;
            textBoxTestresult.TextAlign = HorizontalAlignment.Center;
            textBoxTestresult.Visible = false;
            // 
            // pictureBoxForChild
            // 
            pictureBoxForChild.Location = new Point(28, 291);
            pictureBoxForChild.Name = "pictureBoxForChild";
            pictureBoxForChild.Size = new Size(861, 400);
            pictureBoxForChild.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxForChild.TabIndex = 3;
            pictureBoxForChild.TabStop = false;
            pictureBoxForChild.Visible = false;
            // 
            // buttonCartoonStart
            // 
            buttonCartoonStart.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCartoonStart.Location = new Point(926, 312);
            buttonCartoonStart.Name = "buttonCartoonStart";
            buttonCartoonStart.Size = new Size(306, 81);
            buttonCartoonStart.TabIndex = 4;
            buttonCartoonStart.Text = "Посмотреть мультфильм";
            buttonCartoonStart.UseVisualStyleBackColor = true;
            buttonCartoonStart.Visible = false;
            buttonCartoonStart.Click += buttonCartoonStart_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 715);
            Controls.Add(buttonCartoonStart);
            Controls.Add(pictureBoxForChild);
            Controls.Add(textBoxTestresult);
            Controls.Add(groupBoxTask);
            Controls.Add(groupBoxOptions);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            Text = "Математика для ребенка";
            groupBoxOptions.ResumeLayout(false);
            groupBoxOptions.PerformLayout();
            groupBoxOperation.ResumeLayout(false);
            groupBoxOperation.PerformLayout();
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForChild).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox textBoxTestresult;
        private TextBox textBoxTimeBetwenTours;
        private Label labelTimeBetweenTours;
        private TextBox textBoxValueFrom;
        private Label labelValueRangeFrom;
        private TextBox textBoxValueTo;
        private Label labelValueRangeTo;
        private RadioButton radioButtonMinus;
        private RadioButton radioButtonSum;
        private GroupBox groupBoxOperation;
        private PictureBox pictureBoxForChild;
        private Label labelTourNumber;
        private Button buttonCartoonStart;
        private TextBox textBoxCartoonLink;
        private CheckBox checkBoxCartoonLink;
    }
}
