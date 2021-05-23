using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariableLecture2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string firstName;
            string lastName;

            firstName = firstNameInput.Text;
            lastName = lastNameInput.Text;

            outputText.Text = lastName + firstName;


            /*
            string output;
            output = firstNameInput.Text;
            outputText.Text = output;
            

            //String Concatenation


            //output.Text = firstNameInput.Text;

            //Variable
            
            string harryPotter = "해리포터";
            string theLordOfTheRing = " 반지의 제왕";
            string harryAndTheLord = "해리포터 반지의제왕";

            string bookBox = "해리포터 반지의 제왕";
            string varBookBox = harryAndTheLord;

            outputText.Text = varBookBox;
            */
        }

    }
}
