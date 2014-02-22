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
        private int numberOne;		//First number
        private int numberTwo;		//Second number
        private bool plusOrMinus;		//Whether plus or minus is clicked
        private int answer;		//The answer

        private void btn1_Click(object sender, EventArgs e)    //On button 1 click. Same process for every button.
        {
            displayNumber += "1";       //Conctanates 1 to string displayNumber
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

        private void btnClear_Click(object sender, EventArgs e)		//On the clear button click
        {
            displayNumber = "";		//Sets the number in the display as empty
            display.Text = displayNumber;
            numberOne = 0;		//Sets numberOne as 0
            numberTwo = 0;		//Sets numberTwo as 0
            answer = 0;		//Sets the answer to 0
        }

        private void btnPlus_Click(object sender, EventArgs e)		//Plus button click
        {
            numberOne = int.Parse(displayNumber);		//Converts the display value to an integer and stores it as the first number
            plusOrMinus = true;		//Sets plusOrMinus to true indicating the plus button is clicked
            display.Text = "";		//Resets the display
            displayNumber = "";
        }

        private void btnMinus_Click(object sender, EventArgs e)		//Minus button click
        {
			numberOne = int.Parse(displayNumber);		//Converts the display value to an integer and stores it as the first number
            plusOrMinus = false;		//Sets plusOrMinus to false indicating the minus button is clicked
			display.Text = "";		//Resets the display
            displayNumber = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)		//On equal button click
        {
			numberTwo = int.Parse(displayNumber);		//Converts the display value to an integer and stores it as the second number
            if (plusOrMinus)		//If plusOrMinus is true
            {
                answer = numberOne + numberTwo;		//When it is true it adds the numbers
                display.Text = Convert.ToString(answer);		//Makes the display show the answer as a string
            }
			else		//If plusOrMinus is negative
            {
				answer = numberOne - numberTwo;		//When it is false it subtracts the numbers
				display.Text = Convert.ToString(answer);		//Makes the display show the answer as a string
            }
        }
    }
}
