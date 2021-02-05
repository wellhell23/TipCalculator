using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class CalculateTip : Form
    {


        public CalculateTip()
        {

            InitializeComponent();
        }

      

       

        private void bilInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsDigit(ch)&& ch !=8)
            {
                e.Handled = true;
            }
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           // PictureBox p = (PictureBox)sender;
           // p.Name==
        }

        private void onButtonClick(object sender, EventArgs e)
        {
            double tip = 10;
            double noOfPpl = 1;
            double billAmount = 0;
            if (billInput.Text != "")
            {
                billAmount=Double.Parse(billInput.Text);
                Button bt = (Button)sender;
                if(bt.Name== "buttontipS")
                {
                    tip = convertInt(inputtip.Text);
                    if(tip>0)
                    {
                        tip -= 5;
                        inputtip.Text = "" + tip + "%";
                    }
                    
                }
                if (bt.Name == "buttontipA")
                {
                    tip = convertInt(inputtip.Text);
                    if (tip  < 100)
                    {
                        tip += 5;
                        inputtip.Text = "" + tip + "%";
                    }
                }
                if (bt.Name == "buttonpersonS")
                {
                    noOfPpl = Double.Parse(inputperson.Text);
                    if(noOfPpl>1)
                    {
                        noOfPpl -= 1;
                        inputperson.Text = "" + noOfPpl;
                    }
                }
                if (bt.Name == "buttonpersonA")
                {
                    noOfPpl = Double.Parse(inputperson.Text);
                    noOfPpl += 1;
                    inputperson.Text = "" + noOfPpl;

                }
                noOfPpl = Double.Parse(inputperson.Text);
                tip = convertInt(inputtip.Text);
                outtipperperson.Text= "$" + calculateTipPerPerson(tip, noOfPpl, billAmount).ToString("F");
                outtotalperperson.Text = "$" + calculateTotalPerPerson(tip, noOfPpl, billAmount).ToString("F");
            }
        }

        double calculateTipPerPerson(double tip, double noOfPpl, double bill)
        {
            return (bill * tip) / (100 * noOfPpl);
        }
        double calculateTotalPerPerson(double tip, double noOfPpl, double bill)
        {
            return (bill + ((bill * tip) / 100)) / noOfPpl;

        }
        double convertInt(String st)
        {
            String[] temp = st.Split('%');
            return double.Parse(temp[0]);
        }



    }
}
