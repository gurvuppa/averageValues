using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace averageValues
{
    public partial class Form1 : Form
    {
        double sum;
        double average;

        int counter;
        int numb;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                numb = Convert.ToInt32(inputBox.Text);

                if (numb != 0)
                {
                    counter++;                                                  //add to the counter every single time the button is pressed
                    sum += numb;                                                //add the sum and the new number
                    outputLabel.Text = $"{numb} was added to the sum";
                }
                else 
                {
                     average = sum / counter;                                                           //divide the sum by the counter to get the aveage
                    outputLabel.Text = $"The avaerage of all numbers enetered is: {average.ToString("#.##")}";
                }
            }
            catch
            {
                outputLabel.Text = "Pleae input a number";
            }
            inputBox.Clear();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            sum = 0;
            average = 0;
            counter = 0;

            outputLabel.Text = "";
        }
    }






}
