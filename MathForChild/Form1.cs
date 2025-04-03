using Microsoft.VisualBasic;
using System.Diagnostics.Eventing.Reader;

namespace MathForChild
{
    public partial class FormMain : Form
    {
        private uint num1;
        private uint num2;
        private uint result;
        private uint iteration;
        private uint tour;
        private uint wrightAnswer;
        private uint wrongAnswer;

        double procentResult;


        private string? hintNum1;
        private string? hintNum2;
        public FormMain()
        {
            InitializeComponent();
            timer1.Interval = 3000;
            timer1.Tick += Timer1_Tick;
        }
        //Таймер
        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Execute();


        }

        //Кнопка "Старт/Заново"
        private void buttonStart_Click(object sender, EventArgs e)
        {
            iteration = 1;

            wrightAnswer = 0;
            wrongAnswer = 0;
            procentResult = 0;

            Clear();
            Execute();

        }

        //Кнопка "Проверить результат"
        private void buttonCalculate_Click(object sender, EventArgs e)
        {

            if (InputData())
            {
                textBoxResult.BackColor = Color.Green;
                labelCheckResult.Visible = true;
                labelCheckResult.Text = "ПРАВИЛЬНО!!!";
                wrightAnswer++;
            }
            else
            {
                textBoxResult.BackColor = Color.Red;
                labelCheckResult.Visible = true;
                labelCheckResult.Text = "НЕПРАВИЛЬНО!!!";
                wrongAnswer++;
            }
            timer1.Start();

        }

        //Кнопка "Применить" к настройкам
        private void buttonOptions_Click(object sender, EventArgs e)
        {
            TourCount();

        }

        /// <summary>
        /// //////////////////////////////////////////////
        /// </summary>

        //Основной Метод "Выполнить"
        private void Execute()
        {
            Clear();
            if (iteration <= tour)
            {
                Random rnd = new Random();

                num1 = (uint)rnd.Next(0, 10);
                num2 = (uint)rnd.Next(0, 10);

                textBoxNum1.Text = num1.ToString();
                textBoxNum2.Text = num2.ToString();
                textBoxResult.Focus();

                labelHint.Text = $"{ShowHintNum1()} + {ShowHintNum2()}";
                
            }
            else
            {
                VisibleItems(true);
                textBoxTestresult.Visible = true;
                ShowTestResult();
            }
        }

        //Метод "Очистить данные"
        private void Clear()
        {
            textBoxResult.Clear();
            textBoxNum1.Clear();
            textBoxNum2.Clear();
            labelCheckResult.Visible = false;
            textBoxResult.BackColor = Color.White;
            labelHint.Text = string.Empty;
            hintNum1 = string.Empty;
            hintNum2 = string.Empty;
            textBoxTestresult.Clear();
            textBoxTestresult.Visible = false;

            if (checkBoxHintShow.Checked) labelHint.Visible = true;
            else labelHint.Visible = false;

        }

        //Метод "Ввод ожидаемого результата"
        private bool InputData()
        {
            textBoxResult.BackColor = Color.White;
            try
            {
                if (uint.TryParse(textBoxResult.Text, out uint MyRes))
                {
                    result = Sum(num1, num2);
                    labelCheckResult.Visible = true;
                    iteration++;
                    if (MyRes == result) return true;
                    else return false;
                    

                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные данные...");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }


        //Метод "Суммирование"
        private uint Sum(uint num1, uint num2)
        {
            return num1 + num2;
        }
        //Метод "Вычитание"
        private uint Minus(uint num1, uint num2)
        {
            return num1 + num2;
        }

        //Метод "Видимость данных"
        private void VisibleItems(bool vis)
        {
            groupBoxOptions.Visible = vis;
            checkBoxHintShow.Visible = vis;
            buttonOptions.Visible = vis;
            labelTourCount.Visible = vis;
            textBoxTourCount.Visible = vis;
        }

        //Чек-бокс "Показать подсказу"
        private void checkBoxHintShow_CheckedChanged(object sender, EventArgs e)
        {
                labelHint.Visible = true;
        }

        //Метод "Показать строку подсказки для числа 1"
        private string? ShowHintNum1()
        {
            for (uint i = 0; i < num1; i++)
            {
                hintNum1 += "♥";
            }
            return hintNum1;
        }

        //Метод "Показать строку подсказки для числа 2"
        private string? ShowHintNum2()
        {
            for (uint i = 0; i < num2; i++)
            {
                hintNum2 += "♥";
            }
            return hintNum2;
        }

        //Метод ввода кол-ва туров
        private void TourCount()
        {
            try
            {
                if (uint.TryParse(textBoxTourCount.Text, out uint tourCount))
                {
                    tour = tourCount;
                    VisibleItems(false);
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные данные...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Метод вывода в textBox результатов всего теста
        private void ShowTestResult()
        {
            procentResult = ((double)wrightAnswer / (double)tour)*100;
            textBoxTestresult.Text = $"Результаты:{Environment.NewLine}" +
                $"Проведено туров: {tour}{Environment.NewLine}" +
                $"Правильных ответов: {wrightAnswer}{Environment.NewLine}" +
                $"Неправильных ответов: {wrongAnswer}{Environment.NewLine}" +
                $"ИТОГ: {procentResult.ToString("F0")}%";
        }

    }
}
