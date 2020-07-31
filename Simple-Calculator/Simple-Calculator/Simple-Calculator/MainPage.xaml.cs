using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Markup;
using System.Data;

namespace Simple_Calculator
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonACClicked(object sender, EventArgs e)
        {
            Equation.Text = "";
            Answer.Text = "";
        }   
        private void OnButtonDELClicked(object sender, EventArgs e)
        {
            if (Equation.Text.Length != 0)
            {
                Equation.Text = Equation.Text.Remove(Equation.Text.Length - 1, 1);
            }
        }
        private void OnButtonOPENBRClicked(object sender, EventArgs e)
        {
            char last = Equation.Text.ElementAtOrDefault(Equation.Text.Length - 1);

            if (last == '.')
            {
                Equation.Text = Equation.Text.Remove(Equation.Text.Length - 1, 1);
            }
                Equation.Text += "(";

        }

        private void OnButtonCLOSEBRClicked(object sender, EventArgs e)
        {
            int openCount = 0;
            int closeCount = 0;

            foreach (char c in Equation.Text)
            {
               
                if (c == '(')
                {
                    openCount++;
                }
                else if (c == ')')
                {
                    closeCount++;
                }
            }
            
            if (openCount > closeCount)
            {
                Equation.Text += ")";
            }
        }
        private void OnButtonADDClicked(object sender, EventArgs e)
        {
            char last = Equation.Text.ElementAtOrDefault(Equation.Text.Length - 1);

            if (last == '+' || last == '-' || last == 'x' || last == '÷' || last == '.' )
            {
                Equation.Text = Equation.Text.Remove(Equation.Text.Length - 1, 1);
            }
            if (Equation.Text.Length != 0)
            {
                Equation.Text += "+";
            }

        }
        private void OnButtonMINUSClicked(object sender, EventArgs e)
        {
            char last = Equation.Text.ElementAtOrDefault(Equation.Text.Length - 1);

            if (last == '+' || last == '-' || last == 'x' || last == '÷' || last == '.')
            {
                Equation.Text = Equation.Text.Remove(Equation.Text.Length - 1, 1);
            }
            Equation.Text += "-";
        }
        private void OnButtonTIMESClicked(object sender, EventArgs e)
        {

            char last = Equation.Text.ElementAtOrDefault(Equation.Text.Length - 1);

            if (last == '+' || last == '-' || last == 'x' || last == '÷' || last == '.')
            {
                Equation.Text = Equation.Text.Remove(Equation.Text.Length - 1, 1);
            }
            if (Equation.Text.Length != 0)
            {
                Equation.Text += "x";
            }

     }
        private void OnButtonDIVIDEClicked(object sender, EventArgs e)
        {
            char last = Equation.Text.ElementAtOrDefault(Equation.Text.Length - 1);

            if (last == '+' || last == '-' || last == 'x' || last == '÷' || last == '.')
            {
                Equation.Text = Equation.Text.Remove(Equation.Text.Length - 1, 1);
            }
            if (Equation.Text.Length != 0)
            {
                Equation.Text += "÷";
            }
        }
        private void OnButtonDECIMALClicked(object sender, EventArgs e)
        {
            bool invalid = true;
            int index = Equation.Text.Length - 1;
            char indexElement;
            while (invalid && index > 0)
            {
                indexElement = Equation.Text.ElementAtOrDefault(index);

                if (indexElement == '+' || indexElement == '-' || indexElement == 'x' || indexElement == '÷' || indexElement == '(' || indexElement == ')')
                {
                    invalid = false;
                } 
                else if (indexElement == '.')
                {
                    break;
                }
                else
                {
                    index--;
                }
            }
            if (!invalid || index <= 0)
            {
                char last = Equation.Text.ElementAtOrDefault(Equation.Text.Length - 1);

                if (last == '+' || last == '-' || last == 'x' || last == '÷' || last == '.' || last == '(' || last == ')' || Equation.Text.Length==0)
                {
                    Equation.Text += "0";
                }
                Equation.Text += ".";
            }
        }
        private void OnButtonEQUALSClicked(object sender, EventArgs e)
        {
            char last = Equation.Text.ElementAtOrDefault(Equation.Text.Length - 1);
            if (last == '+' || last == '-' || last == 'x' || last == '÷' || last == '.')
            {
                Equation.Text = Equation.Text.Remove(Equation.Text.Length - 1, 1);
            }

            int openCount = 0;
            int closeCount = 0;

            foreach (char c in Equation.Text)
            {

                if (c == '(')
                {
                    openCount++;
                }
                else if (c == ')')
                {
                    closeCount++;
                }
            }
            int bracketsNeeded = openCount - closeCount;
            for (int i=0; i<bracketsNeeded; i++)
            {
                Equation.Text += ")";
            }


            DataTable dt = new DataTable();
            string equation = Equation.Text.Replace('x', '*');
            equation = equation.Replace('÷', '/');
            var v = dt.Compute(equation, "");
            Answer.Text = v.ToString();
        }
        private void OnButton0Clicked(object sender, EventArgs e)
        {
            Equation.Text += "0";
        }
        private void OnButton1Clicked(object sender, EventArgs e)
        {
            Equation.Text += "1";
        }
        private void OnButton2Clicked(object sender, EventArgs e)
        {
            Equation.Text += "2";
        }
        private void OnButton3Clicked(object sender, EventArgs e)
        {
            Equation.Text += "3";
        }
        private void OnButton4Clicked(object sender, EventArgs e)
        {
            Equation.Text += "4";
        }
        private void OnButton5Clicked(object sender, EventArgs e)
        {
            Equation.Text += "5";
        }
        private void OnButton6Clicked(object sender, EventArgs e)
        {
            Equation.Text += "6";
        }
        private void OnButton7Clicked(object sender, EventArgs e)
        {
            Equation.Text += "7";
        }
        private void OnButton8Clicked(object sender, EventArgs e)
        {
            Equation.Text += "8";
        }
        private void OnButton9Clicked(object sender, EventArgs e)
        {
            Equation.Text += "9";
        }

    }
}
