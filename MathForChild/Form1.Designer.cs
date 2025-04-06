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
            toolTip1 = new ToolTip(components);
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
            groupBoxOptions.Location = new Point(32, 37);
            groupBoxOptions.Name = "groupBoxOptions";
            groupBoxOptions.Size = new Size(1384, 125);
            groupBoxOptions.TabIndex = 0;
            groupBoxOptions.TabStop = false;
            groupBoxOptions.Text = "Настройки";
            // 
            // textBoxCartoonLink
            // 
            textBoxCartoonLink.Location = new Point(502, 85);
            textBoxCartoonLink.Margin = new Padding(3, 4, 3, 4);
            textBoxCartoonLink.Name = "textBoxCartoonLink";
            textBoxCartoonLink.Size = new Size(514, 27);
            textBoxCartoonLink.TabIndex = 14;
            toolTip1.SetToolTip(textBoxCartoonLink, "Введите адрес ссылки");
            textBoxCartoonLink.Visible = false;
            // 
            // checkBoxCartoonLink
            // 
            checkBoxCartoonLink.AutoSize = true;
            checkBoxCartoonLink.Location = new Point(265, 88);
            checkBoxCartoonLink.Margin = new Padding(3, 4, 3, 4);
            checkBoxCartoonLink.Name = "checkBoxCartoonLink";
            checkBoxCartoonLink.Size = new Size(248, 24);
            checkBoxCartoonLink.TabIndex = 13;
            checkBoxCartoonLink.Text = "Поставить другой мультфильм:";
            toolTip1.SetToolTip(checkBoxCartoonLink, "Если оставить пустым, запустится мультфильм Мармеладный мишка");
            checkBoxCartoonLink.UseVisualStyleBackColor = true;
            checkBoxCartoonLink.CheckedChanged += checkBoxCartoonLink_CheckedChanged;
            // 
            // groupBoxOperation
            // 
            groupBoxOperation.Controls.Add(radioButtonSum);
            groupBoxOperation.Controls.Add(radioButtonMinus);
            groupBoxOperation.Location = new Point(1023, 16);
            groupBoxOperation.Margin = new Padding(3, 4, 3, 4);
            groupBoxOperation.Name = "groupBoxOperation";
            groupBoxOperation.Padding = new Padding(3, 4, 3, 4);
            groupBoxOperation.Size = new Size(149, 103);
            groupBoxOperation.TabIndex = 12;
            groupBoxOperation.TabStop = false;
            groupBoxOperation.Text = "Операции";
            toolTip1.SetToolTip(groupBoxOperation, "Выбрать операции");
            // 
            // radioButtonSum
            // 
            radioButtonSum.AutoSize = true;
            radioButtonSum.Checked = true;
            radioButtonSum.Location = new Point(7, 29);
            radioButtonSum.Margin = new Padding(3, 4, 3, 4);
            radioButtonSum.Name = "radioButtonSum";
            radioButtonSum.Size = new Size(125, 24);
            radioButtonSum.TabIndex = 10;
            radioButtonSum.TabStop = true;
            radioButtonSum.Text = "Сложение (+)";
            radioButtonSum.UseVisualStyleBackColor = true;
            // 
            // radioButtonMinus
            // 
            radioButtonMinus.AutoSize = true;
            radioButtonMinus.Location = new Point(7, 61);
            radioButtonMinus.Margin = new Padding(3, 4, 3, 4);
            radioButtonMinus.Name = "radioButtonMinus";
            radioButtonMinus.Size = new Size(127, 24);
            radioButtonMinus.TabIndex = 11;
            radioButtonMinus.Text = "Вычитание (-)";
            radioButtonMinus.UseVisualStyleBackColor = true;
            // 
            // textBoxValueTo
            // 
            textBoxValueTo.Location = new Point(895, 25);
            textBoxValueTo.Name = "textBoxValueTo";
            textBoxValueTo.Size = new Size(51, 27);
            textBoxValueTo.TabIndex = 9;
            textBoxValueTo.TextAlign = HorizontalAlignment.Center;
            // 
            // labelValueRangeTo
            // 
            labelValueRangeTo.AutoSize = true;
            labelValueRangeTo.Location = new Point(870, 32);
            labelValueRangeTo.Name = "labelValueRangeTo";
            labelValueRangeTo.Size = new Size(26, 20);
            labelValueRangeTo.TabIndex = 8;
            labelValueRangeTo.Text = "до";
            toolTip1.SetToolTip(labelValueRangeTo, "Если поле пустое, значит там 10. Максимальное число 20");
            // 
            // textBoxValueFrom
            // 
            textBoxValueFrom.Location = new Point(816, 25);
            textBoxValueFrom.Name = "textBoxValueFrom";
            textBoxValueFrom.Size = new Size(51, 27);
            textBoxValueFrom.TabIndex = 7;
            textBoxValueFrom.TextAlign = HorizontalAlignment.Center;
            // 
            // labelValueRangeFrom
            // 
            labelValueRangeFrom.AutoSize = true;
            labelValueRangeFrom.Location = new Point(738, 32);
            labelValueRangeFrom.Name = "labelValueRangeFrom";
            labelValueRangeFrom.Size = new Size(81, 20);
            labelValueRangeFrom.TabIndex = 6;
            labelValueRangeFrom.Text = "Цифры от:";
            toolTip1.SetToolTip(labelValueRangeFrom, "Если пустое, значит там 0");
            // 
            // textBoxTimeBetwenTours
            // 
            textBoxTimeBetwenTours.Location = new Point(633, 25);
            textBoxTimeBetwenTours.Name = "textBoxTimeBetwenTours";
            textBoxTimeBetwenTours.Size = new Size(51, 27);
            textBoxTimeBetwenTours.TabIndex = 5;
            textBoxTimeBetwenTours.TextAlign = HorizontalAlignment.Center;
            // 
            // labelTimeBetweenTours
            // 
            labelTimeBetweenTours.AutoSize = true;
            labelTimeBetweenTours.Location = new Point(465, 29);
            labelTimeBetweenTours.Name = "labelTimeBetweenTours";
            labelTimeBetweenTours.Size = new Size(177, 20);
            labelTimeBetweenTours.TabIndex = 4;
            labelTimeBetweenTours.Text = "Время между турами(c):";
            toolTip1.SetToolTip(labelTimeBetweenTours, "Если оставить пустым, время - 3 секунды\r\n");
            // 
            // textBoxTourCount
            // 
            textBoxTourCount.Location = new Point(378, 25);
            textBoxTourCount.Name = "textBoxTourCount";
            textBoxTourCount.Size = new Size(51, 27);
            textBoxTourCount.TabIndex = 3;
            textBoxTourCount.TextAlign = HorizontalAlignment.Center;
            // 
            // labelTourCount
            // 
            labelTourCount.AutoSize = true;
            labelTourCount.ImageAlign = ContentAlignment.MiddleRight;
            labelTourCount.Location = new Point(273, 28);
            labelTourCount.Name = "labelTourCount";
            labelTourCount.Size = new Size(108, 20);
            labelTourCount.TabIndex = 2;
            labelTourCount.Text = "Кол-во туров: ";
            toolTip1.SetToolTip(labelTourCount, "Если поле оставить пустым, туров будет 10");
            // 
            // buttonOptions
            // 
            buttonOptions.Location = new Point(7, 79);
            buttonOptions.Name = "buttonOptions";
            buttonOptions.Size = new Size(144, 41);
            buttonOptions.TabIndex = 1;
            buttonOptions.Text = "Применить";
            toolTip1.SetToolTip(buttonOptions, "Применить настройки");
            buttonOptions.UseVisualStyleBackColor = true;
            buttonOptions.Click += buttonOptions_Click;
            // 
            // checkBoxHintShow
            // 
            checkBoxHintShow.AutoSize = true;
            checkBoxHintShow.Location = new Point(97, 24);
            checkBoxHintShow.Name = "checkBoxHintShow";
            checkBoxHintShow.Size = new Size(161, 24);
            checkBoxHintShow.TabIndex = 0;
            checkBoxHintShow.Text = "Показать подсказу";
            toolTip1.SetToolTip(checkBoxHintShow, "Если включить, отобразится подсказка в виде сердечек");
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
            groupBoxTask.Location = new Point(32, 197);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(1016, 184);
            groupBoxTask.TabIndex = 1;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Задание";
            // 
            // labelTourNumber
            // 
            labelTourNumber.AutoSize = true;
            labelTourNumber.Location = new Point(952, 24);
            labelTourNumber.Name = "labelTourNumber";
            labelTourNumber.Size = new Size(0, 20);
            labelTourNumber.TabIndex = 6;
            labelTourNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCheckResult
            // 
            labelCheckResult.AutoSize = true;
            labelCheckResult.Location = new Point(760, 40);
            labelCheckResult.Name = "labelCheckResult";
            labelCheckResult.Size = new Size(0, 20);
            labelCheckResult.TabIndex = 5;
            labelCheckResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelHint
            // 
            labelHint.AutoSize = true;
            labelHint.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelHint.Location = new Point(288, 40);
            labelHint.Name = "labelHint";
            labelHint.Size = new Size(0, 28);
            labelHint.TabIndex = 2;
            labelHint.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonStart
            // 
            buttonStart.Enabled = false;
            buttonStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonStart.Location = new Point(16, 32);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(232, 48);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Старт";
            toolTip1.SetToolTip(buttonStart, "Начать считать");
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Enabled = false;
            buttonCalculate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCalculate.Location = new Point(736, 120);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(232, 48);
            buttonCalculate.TabIndex = 4;
            buttonCalculate.Text = "Проверить результат";
            toolTip1.SetToolTip(buttonCalculate, "Сравнить введенный результат с правдой");
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
            textBoxResult.Enabled = false;
            textBoxResult.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(760, 72);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(191, 39);
            textBoxResult.TabIndex = 3;
            textBoxResult.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(textBoxResult, "Введите результат ваших подсчетов");
            // 
            // textBoxNum2
            // 
            textBoxNum2.BackColor = SystemColors.Control;
            textBoxNum2.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxNum2.Location = new Point(520, 72);
            textBoxNum2.Name = "textBoxNum2";
            textBoxNum2.Size = new Size(191, 39);
            textBoxNum2.TabIndex = 2;
            textBoxNum2.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(textBoxNum2, "Здесь выпадает случайное число");
            // 
            // textBoxNum1
            // 
            textBoxNum1.BackColor = SystemColors.Control;
            textBoxNum1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxNum1.Location = new Point(280, 72);
            textBoxNum1.Name = "textBoxNum1";
            textBoxNum1.Size = new Size(191, 39);
            textBoxNum1.TabIndex = 1;
            textBoxNum1.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(textBoxNum1, "Здесь выпадает случайное число");
            // 
            // timer1
            // 
            timer1.Tick += Timer1_Tick;
            // 
            // textBoxTestresult
            // 
            textBoxTestresult.BackColor = SystemColors.Control;
            textBoxTestresult.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxTestresult.Location = new Point(1055, 207);
            textBoxTestresult.Margin = new Padding(3, 4, 3, 4);
            textBoxTestresult.Multiline = true;
            textBoxTestresult.Name = "textBoxTestresult";
            textBoxTestresult.Size = new Size(353, 171);
            textBoxTestresult.TabIndex = 2;
            textBoxTestresult.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(textBoxTestresult, "Твой результат");
            textBoxTestresult.Visible = false;
            // 
            // pictureBoxForChild
            // 
            pictureBoxForChild.Location = new Point(32, 388);
            pictureBoxForChild.Margin = new Padding(3, 4, 3, 4);
            pictureBoxForChild.Name = "pictureBoxForChild";
            pictureBoxForChild.Size = new Size(984, 533);
            pictureBoxForChild.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxForChild.TabIndex = 3;
            pictureBoxForChild.TabStop = false;
            pictureBoxForChild.Visible = false;
            // 
            // buttonCartoonStart
            // 
            buttonCartoonStart.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCartoonStart.Location = new Point(1058, 416);
            buttonCartoonStart.Margin = new Padding(3, 4, 3, 4);
            buttonCartoonStart.Name = "buttonCartoonStart";
            buttonCartoonStart.Size = new Size(350, 108);
            buttonCartoonStart.TabIndex = 4;
            buttonCartoonStart.Text = "Посмотреть мультфильм";
            toolTip1.SetToolTip(buttonCartoonStart, "ТЫ МОЛОДЕЦ!!! ТЕПЕРЬ ТЫ МОЖЕШЬ ПОСМОТРЕТЬ МУЛЬТФИЛЬМ");
            buttonCartoonStart.UseVisualStyleBackColor = true;
            buttonCartoonStart.Visible = false;
            buttonCartoonStart.Click += buttonCartoonStart_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 953);
            Controls.Add(buttonCartoonStart);
            Controls.Add(pictureBoxForChild);
            Controls.Add(textBoxTestresult);
            Controls.Add(groupBoxTask);
            Controls.Add(groupBoxOptions);
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
        private ToolTip toolTip1;
    }
}
