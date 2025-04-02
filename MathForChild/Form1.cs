namespace MathForChild
{
    public partial class FormMain : Form
    {
        private uint num1;
        private uint num2;
        private uint MyResult;
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Execute();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (InputData())
            {
                textBoxResult.BackColor = Color.Green;
                labelCheckResult.Visible=true;
                labelCheckResult.Text = "œ–¿¬»À‹ÕŒ!!!";
            }
            else
            {
                textBoxResult.BackColor = Color.Red;
                labelCheckResult.Visible = true;
                labelCheckResult.Text = "Õ≈œ–¿¬»À‹ÕŒ!!!";
            }
        }
        private uint Sum(uint num1, uint num2)
        {
            return num1 + num2;
        }
        private uint Minus(uint num1, uint num2)
        {
            return num1 + num2;
        }
        private bool InputData()
        {
            try
            {
                if (uint.TryParse(textBoxResult.Text, out uint res))
                {
                    this.MyResult = res;
                    if (MyResult == Sum(num1, num2))return true;
                    else return false;
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("¬‚Â‰ËÚÂ ÍÓÂÍÚÌ˚Â ‰‡ÌÌ˚Â...");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void Execute()
        {
            Clear();
            Random rnd = new Random();

            num1 = (uint)rnd.Next(0, 10);
            num2 = (uint)rnd.Next(0, 10);

            textBoxNum1.Text=num1.ToString();
            textBoxNum2.Text=num2.ToString();

        }
        private void Clear()
        {
            textBoxNum1.Text=string.Empty;
            textBoxNum2.Text = string.Empty;
            textBoxResult.Text = string.Empty;
            textBoxResult.BackColor = Color.White;
            labelCheckResult.Visible = false;
            labelCheckResult.Text = string.Empty;
        }
    }
}
