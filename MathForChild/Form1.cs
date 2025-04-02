using System.Diagnostics.Eventing.Reader;

namespace MathForChild
{
    public partial class FormMain : Form
    {
        private uint num1;
        private uint num2;
        private uint MyResult;
        private uint iteration;
        private uint tour;

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
            tour = 0;
            VisibleItems(false);
            Execute();
            VisibleItems(true);
        }

        //Кнопка "Проверить результат"
        private void buttonCalculate_Click(object sender, EventArgs e)
        {

            if (InputData())
            {
                textBoxResult.BackColor = Color.Green;
                labelCheckResult.Visible = true;
                labelCheckResult.Text = "ПРАВИЛЬНО!!!";
            }
            else
            {
                textBoxResult.BackColor = Color.Red;
                labelCheckResult.Visible = true;
                labelCheckResult.Text = "НЕПРАВИЛЬНО!!!";
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
           while(tour <= iteration)
            {
                Clear();
                Random rnd = new Random();

                num1 = (uint)rnd.Next(0, 10);
                num2 = (uint)rnd.Next(0, 10);

                textBoxNum1.Text = num1.ToString();
                textBoxNum2.Text = num2.ToString();
                textBoxResult.Focus();

                labelHint.Text = $"{ShowHintNum1()} + {ShowHintNum2()}";
                tour++;
            }
            
                VisibleItems(true);
                Clear();
        }

        //Метод "Очистить данные"
        private void Clear()
        {
            textBoxNum1.Text = string.Empty;
            textBoxNum2.Text = string.Empty;
            textBoxResult.Text = string.Empty;
            textBoxResult.BackColor = Color.White;


            labelCheckResult.Visible = false;
            labelCheckResult.Text = string.Empty;

            hintNum1 = string.Empty;
            hintNum2 = string.Empty;

        }

        //Метод "Ввод ожидаемого результата"
        private bool InputData()
        {
            try
            {
                if (uint.TryParse(textBoxResult.Text, out uint res))
                {
                    this.MyResult = res;
                    if (MyResult == Sum(num1, num2)) return true;
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
        }

        //Чек-бокс "Показать подсказу"
        private void checkBoxHintShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHintShow.Checked)
            {
                labelHint.Visible = true;
            }
            else
            {
                labelHint.Visible = false;
            }
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

        //Чек-бок "Кол-во туров
        private void TourCount()
        {
            try
            {
                if (uint.TryParse(textBoxTourCount.Text, out uint tourCount))
                {
                    this.iteration = tourCount;
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

    }
}
