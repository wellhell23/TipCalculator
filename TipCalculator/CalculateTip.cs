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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelBill;
        private System.Windows.Forms.TextBox billInput;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.Label inputtip;
        private System.Windows.Forms.Label labelNoPeople;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label inputperson;
        private System.Windows.Forms.Label outlabeltip;
        private System.Windows.Forms.Label labelperpersontip;
        private System.Windows.Forms.Label outlabeltotal;
        private System.Windows.Forms.Label labelperpersontotal;
        private System.Windows.Forms.Label outtipperperson;
        private System.Windows.Forms.Label outtotalperperson;
        private ButtonWrapper addTipButton;
        private ButtonWrapper subTipButton;
        private ButtonWrapper addPersonButton;
        private ButtonWrapper subPersonButton;

 
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

      

        private void CalculateTipLoad(object sender, EventArgs e)
        {
            
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelBill = new System.Windows.Forms.Label();
            this.billInput = new System.Windows.Forms.TextBox();
            this.labelTip = new System.Windows.Forms.Label();
            this.inputtip = new System.Windows.Forms.Label();
            this.labelNoPeople = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inputperson = new System.Windows.Forms.Label();
            this.outlabeltip = new System.Windows.Forms.Label();
            this.labelperpersontip = new System.Windows.Forms.Label();
            this.outlabeltotal = new System.Windows.Forms.Label();
            this.labelperpersontotal = new System.Windows.Forms.Label();
            this.outtipperperson = new System.Windows.Forms.Label();
            this.outtotalperperson = new System.Windows.Forms.Label();
            this.addTipButton = new ButtonWrapper("buttonTipA", new Size(40, 35), "+", 7, new Point(244, 152));
            this.subTipButton = new ButtonWrapper("buttonTipS", new Size(35, 35), "-", 6, new Point(40, 152));
            this.addPersonButton = new ButtonWrapper("buttonPersonA", new Size(40, 35), "+", 13, new Point(244, 238));
            this.subPersonButton = new ButtonWrapper("buttonPersonS", new Size(35, 35), "-", 11, new Point(40, 238));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(324, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(458, 311);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // labelBill
            // 
            this.labelBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBill.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelBill.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelBill.Location = new System.Drawing.Point(35, 28);
            this.labelBill.Name = "labelBill";
            this.labelBill.Size = new System.Drawing.Size(249, 23);
            this.labelBill.TabIndex = 2;
            this.labelBill.Text = "Bill";
            // 
            // billInput
            // 
            this.billInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.billInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billInput.Location = new System.Drawing.Point(40, 63);
            this.billInput.Name = "billInput";
            this.billInput.Size = new System.Drawing.Size(244, 34);
            this.billInput.TabIndex = 3;
            this.billInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.billInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bilInput_KeyPress);
            // 
            // labelTip
            // 
            this.labelTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTip.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelTip.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelTip.Location = new System.Drawing.Point(35, 115);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(249, 34);
            this.labelTip.TabIndex = 4;
            this.labelTip.Text = "Tip%";
            
            // 
            // inputtip
            // 
            this.inputtip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputtip.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputtip.Location = new System.Drawing.Point(75, 152);
            this.inputtip.Name = "inputtip";
            this.inputtip.Size = new System.Drawing.Size(173, 35);
            this.inputtip.TabIndex = 8;
            this.inputtip.Text = "10%";
            this.inputtip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNoPeople
            // 
            this.labelNoPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoPeople.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelNoPeople.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelNoPeople.Location = new System.Drawing.Point(35, 203);
            this.labelNoPeople.Name = "labelNoPeople";
            this.labelNoPeople.Size = new System.Drawing.Size(249, 35);
            this.labelNoPeople.TabIndex = 9;
            this.labelNoPeople.Text = "No of person ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 311);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // inputperson
            // 
            this.inputperson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputperson.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputperson.Location = new System.Drawing.Point(75, 238);
            this.inputperson.Name = "inputperson";
            this.inputperson.Size = new System.Drawing.Size(173, 34);
            this.inputperson.TabIndex = 12;
            this.inputperson.Text = "1";
            this.inputperson.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outlabeltip
            // 
            this.outlabeltip.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outlabeltip.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.outlabeltip.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.outlabeltip.Location = new System.Drawing.Point(334, 91);
            this.outlabeltip.Name = "outlabeltip";
            this.outlabeltip.Size = new System.Drawing.Size(81, 33);
            this.outlabeltip.TabIndex = 14;
            this.outlabeltip.Text = "Tip";
            // 
            // labelperpersontip
            // 
            this.labelperpersontip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelperpersontip.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelperpersontip.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelperpersontip.Location = new System.Drawing.Point(334, 124);
            this.labelperpersontip.Name = "labelperpersontip";
            this.labelperpersontip.Size = new System.Drawing.Size(158, 25);
            this.labelperpersontip.TabIndex = 15;
            this.labelperpersontip.Text = "Per person";
            // 
            // outlabeltotal
            // 
            this.outlabeltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outlabeltotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.outlabeltotal.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.outlabeltotal.Location = new System.Drawing.Point(334, 186);
            this.outlabeltotal.Name = "outlabeltotal";
            this.outlabeltotal.Size = new System.Drawing.Size(81, 33);
            this.outlabeltotal.TabIndex = 16;
            this.outlabeltotal.Text = "Total";
            // 
            // labelperpersontotal
            // 
            this.labelperpersontotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelperpersontotal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelperpersontotal.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelperpersontotal.Location = new System.Drawing.Point(335, 219);
            this.labelperpersontotal.Name = "labelperpersontotal";
            this.labelperpersontotal.Size = new System.Drawing.Size(158, 25);
            this.labelperpersontotal.TabIndex = 17;
            this.labelperpersontotal.Text = "Per person";
            // 
            // outtipperperson
            // 
            this.outtipperperson.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outtipperperson.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.outtipperperson.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.outtipperperson.Location = new System.Drawing.Point(477, 91);
            this.outtipperperson.Name = "outtipperperson";
            this.outtipperperson.Size = new System.Drawing.Size(249, 58);
            this.outtipperperson.TabIndex = 18;
            this.outtipperperson.Text = "$0";
            this.outtipperperson.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // outtotalperperson
            // 
            this.outtotalperperson.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outtotalperperson.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.outtotalperperson.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.outtotalperperson.Location = new System.Drawing.Point(477, 186);
            this.outtotalperperson.Name = "outtotalperperson";
            this.outtotalperperson.Size = new System.Drawing.Size(249, 58);
            this.outtotalperperson.TabIndex = 19;
            this.outtotalperperson.Text = "$0";
            this.outtotalperperson.TextAlign = System.Drawing.ContentAlignment.BottomRight;

            addTipButton.SetEventHandler(this.OnClickTipButton);
            subTipButton.SetEventHandler(this.OnClickTipButton);
            addPersonButton.SetEventHandler(this.OnClickPersonButton);
            subPersonButton.SetEventHandler(this.OnClickPersonButton);

            this.Controls.Add(this.outtotalperperson);
            this.Controls.Add(this.outtipperperson);
            this.Controls.Add(this.labelperpersontotal);
            this.Controls.Add(this.outlabeltotal);
            this.Controls.Add(this.labelperpersontip);
            this.Controls.Add(this.outlabeltip);
            this.Controls.Add(this.inputperson);
            this.Controls.Add(this.labelNoPeople);
            this.Controls.Add(this.inputtip);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.billInput);
            this.Controls.Add(this.labelBill);
            //
            //add Buttons
            //
            this.Controls.Add(this.addTipButton.GetButtonObject());
            this.Controls.Add(this.subTipButton.GetButtonObject());
            this.Controls.Add(this.addPersonButton.GetButtonObject());
            this.Controls.Add(this.subPersonButton.GetButtonObject());
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);

        }

        //
        //UpdateLableFunction
        //
        private void UpdateLableText(Label lable, String text)
        {
            lable.Text = text;
        }
        //
        //CalculateTipFunction
        //
        private void CalculateTipAmount()
        {
            try
            {
                double tipPercent = convertInt(inputtip.Text);
                double billAmount = Double.Parse(billInput.Text);
                double tipPerPerson = 0;
                double totalTip = 0;
                double noOfPpl = Double.Parse(inputperson.Text);
                if (billAmount > 0)
                {
                    double tipAmout = (billAmount * tipPercent) / 100;
                    tipPerPerson = tipAmout / noOfPpl;
                    totalTip = (billAmount + tipAmout) / noOfPpl;
                }
                UpdateLableText(outtipperperson, "$" + tipPerPerson);
                UpdateLableText(outtotalperperson, "$" + totalTip);
            } catch(Exception e)
            {
                // TODO: Print message for user
            }
        }
        //
        //OnClickTipBittonFunction
        //
        private void OnClickTipButton(object sender, EventArgs e)
        {
            double tipPercent = convertInt(this.inputtip.Text);
            Button btn = (Button)sender;
            int changePercent=0;
            if (btn.Name == "buttonTipA" && tipPercent < 100)
            {
                changePercent = 5;
            }
            if (btn.Name == "buttonTipS" && tipPercent > 0)
            {
                changePercent = -5;
            }

            tipPercent += changePercent;
            UpdateLableText(this.inputtip, " " + tipPercent + "%");
            CalculateTipAmount();
        }
        //
        //onclickpersonbuttonfunction
        //
        private void OnClickPersonButton(Object sender, EventArgs e)
        {
            double noOfPerson = Double.Parse(inputperson.Text);
            Button btn = (Button)sender;
            int change = 0;
            if (btn.Name == "buttonPersonS" && noOfPerson > 1)
                change = -1;
            if (btn.Name == "buttonPersonA")
                change = 1;
            noOfPerson += change;
            UpdateLableText(this.inputperson, "" + noOfPerson );
            CalculateTipAmount();
        }

        
        //to convrert string with % to int
        double convertInt(String st)
        {
            String[] temp = st.Split('%');
            return double.Parse(temp[0]);
        }



    }
}
