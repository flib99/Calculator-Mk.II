using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Claculator : Form
    {
        public Claculator()
        {
            InitializeComponent();
        }

        private string displayNumber = "";  //Declare integer
        private int numberOne;      
        private int numberTwo;
        private bool plusOrMinus;
        private int answer;

        private void btn1_Click(object sender, EventArgs e)    //On button 1 click. Same process for every button.
        {
            displayNumber += "1";       //Cncatinates 1 to string displayNumber
            display.Text = displayNumber;   //Make the display be equal to displayNumber
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            displayNumber += "2";
            display.Text = displayNumber;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            displayNumber += "3";
            display.Text = displayNumber;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            displayNumber += "4";
            display.Text = displayNumber;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            displayNumber += "5";
            display.Text = displayNumber;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            displayNumber += "6";
            display.Text = displayNumber;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            displayNumber += "7";
            display.Text = displayNumber;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            displayNumber += "8";
            display.Text = displayNumber;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            displayNumber += "9";
            display.Text = displayNumber;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            displayNumber += "0";
            display.Text = displayNumber;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            displayNumber = "";
            display.Text = displayNumber;
            numberOne = 0;
            numberTwo = 0;
            answer = 0;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            numberOne = int.Parse(displayNumber);
            plusOrMinus = true;
            display.Text = "";
            displayNumber = "";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            numberOne = int.Parse(displayNumber);
            plusOrMinus = false;
            display.Text = "";
            displayNumber = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            numberTwo = int.Parse(displayNumber);
            if (plusOrMinus)
            {
                answer = numberOne + numberTwo;
                display.Text = Convert.ToString(answer);
            }
            else
            {
                answer = numberOne - numberTwo;
                display.Text = Convert.ToString(answer);
            }
        }

    }
}
