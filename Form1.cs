using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public double underprice=1.2;


        public Form1()
        {
            InitializeComponent();
        }
        #region custom methods
        private int Multiply(int firstnumber, int secondnumber)
        {
              
            int answer;
            answer = firstnumber * secondnumber;
            return answer;
        }

        private double Areaa(double lengthx, double heightx)
        {
            double answer;
            answer = lengthx * heightx;
            return answer;
        }

        private double Underr(double lengthx, double heightx)
        {
            double answer;
            answer = lengthx * heightx * underprice;
            return answer;
        }
#endregion
        private void calcBTN_Click(object sender, EventArgs e)
        {
                double number1;
                double number2;
                double returnValue = 0;

                number1 = double.Parse(textBox1.Text);
                number2 = double.Parse(textBox2.Text);

                returnValue = Areaa(number1, number2);
                textBox3.Text = Convert.ToString(returnValue);
        }

        private void undBTN_Click(object sender, EventArgs e)
        {
            double underprice;
            double number1;
            double number2;
            double returnValue = 0;
            

            number1 = double.Parse(textBox1.Text);
            number2 = double.Parse(textBox2.Text);
            
            returnValue = Underr(number1 += number2);
            textBox4.Text = Convert.ToString(returnValue);

         }

        private double Underr(double p)
        {
            throw new NotImplementedException();
        }

     }
}
