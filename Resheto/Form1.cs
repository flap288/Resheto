using Microsoft.VisualBasic.Logging;

namespace Resheto
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            Auth auth_form = new Auth();
            auth_form.ShowDialog();
        }

        public void Make_Click(object sender, EventArgs e)
        {
            string input1 = Input1.Text;
            if (string.IsNullOrEmpty(input1))
            {
                MessageBox.Show("строка пуста, введите значение");
                return;
            }
            if(Convert.ToInt32(input1) > 100 || Convert.ToInt32(input1)<0)
            {
                Output.Text = "Недопустимый диапазон значений, повторите ввод";
                return;
            }
            var n1 = Convert.ToUInt32(input1);
            var primeNumbers = SieveEratosthenes(n1);
            Output.Text = string.Join(", ", primeNumbers);

        }
        public List<uint> SieveEratosthenes(uint n)
        {
            var numbers = new List<uint>();

            for (var i = 2u; i < n; i++)
            {
                numbers.Add(i);
            }

            for (var i = 0; i < numbers.Count; i++)
            {
                for (var j = 2u; j < n; j++)
                {
                    numbers.Remove(numbers[i] * j);
                }
            }
            return numbers;
        }

    }
}