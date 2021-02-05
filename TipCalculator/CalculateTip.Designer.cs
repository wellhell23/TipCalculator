
namespace TipCalculator
{
    partial class CalculateTip
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelBill = new System.Windows.Forms.Label();
            this.billInput = new System.Windows.Forms.TextBox();
            this.labelTip = new System.Windows.Forms.Label();
            this.buttontipS = new System.Windows.Forms.Button();
            this.buttontipA = new System.Windows.Forms.Button();
            this.inputtip = new System.Windows.Forms.Label();
            this.labelNoPeople = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonpersonS = new System.Windows.Forms.Button();
            this.inputperson = new System.Windows.Forms.Label();
            this.buttonpersonA = new System.Windows.Forms.Button();
            this.outlabeltip = new System.Windows.Forms.Label();
            this.labelperpersontip = new System.Windows.Forms.Label();
            this.outlabeltotal = new System.Windows.Forms.Label();
            this.labelperpersontotal = new System.Windows.Forms.Label();
            this.outtipperperson = new System.Windows.Forms.Label();
            this.outtotalperperson = new System.Windows.Forms.Label();
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
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            // buttontipS
            // 
            this.buttontipS.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttontipS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttontipS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttontipS.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttontipS.Location = new System.Drawing.Point(40, 152);
            this.buttontipS.Name = "buttontipS";
            this.buttontipS.Size = new System.Drawing.Size(35, 35);
            this.buttontipS.TabIndex = 6;
            this.buttontipS.Text = "-";
            this.buttontipS.UseVisualStyleBackColor = true;
            this.buttontipS.Click += new System.EventHandler(this.onButtonClick);
            // 
            // buttontipA
            // 
            this.buttontipA.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttontipA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttontipA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttontipA.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttontipA.Location = new System.Drawing.Point(244, 152);
            this.buttontipA.Name = "buttontipA";
            this.buttontipA.Size = new System.Drawing.Size(40, 35);
            this.buttontipA.TabIndex = 7;
            this.buttontipA.Text = "+";
            this.buttontipA.UseVisualStyleBackColor = true;
            this.buttontipA.Click += new System.EventHandler(this.onButtonClick);
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
            // buttonpersonS
            // 
            this.buttonpersonS.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonpersonS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonpersonS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonpersonS.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonpersonS.Location = new System.Drawing.Point(40, 238);
            this.buttonpersonS.Name = "buttonpersonS";
            this.buttonpersonS.Size = new System.Drawing.Size(35, 35);
            this.buttonpersonS.TabIndex = 11;
            this.buttonpersonS.Text = "-";
            this.buttonpersonS.UseVisualStyleBackColor = true;
            this.buttonpersonS.Click += new System.EventHandler(this.onButtonClick);
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
            // buttonpersonA
            // 
            this.buttonpersonA.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonpersonA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonpersonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonpersonA.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonpersonA.Location = new System.Drawing.Point(244, 238);
            this.buttonpersonA.Name = "buttonpersonA";
            this.buttonpersonA.Size = new System.Drawing.Size(40, 35);
            this.buttonpersonA.TabIndex = 13;
            this.buttonpersonA.Text = "+";
            this.buttonpersonA.UseVisualStyleBackColor = true;
            this.buttonpersonA.Click += new System.EventHandler(this.onButtonClick);
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
            // 
            // CalculateTip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 303);
            this.Controls.Add(this.outtotalperperson);
            this.Controls.Add(this.outtipperperson);
            this.Controls.Add(this.labelperpersontotal);
            this.Controls.Add(this.outlabeltotal);
            this.Controls.Add(this.labelperpersontip);
            this.Controls.Add(this.outlabeltip);
            this.Controls.Add(this.buttonpersonA);
            this.Controls.Add(this.inputperson);
            this.Controls.Add(this.buttonpersonS);
            this.Controls.Add(this.labelNoPeople);
            this.Controls.Add(this.inputtip);
            this.Controls.Add(this.buttontipA);
            this.Controls.Add(this.buttontipS);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.billInput);
            this.Controls.Add(this.labelBill);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(800, 350);
            this.Name = "CalculateTip";
            this.Text = "Tip Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelBill;
        private System.Windows.Forms.TextBox billInput;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.Button buttontipS;
        private System.Windows.Forms.Button buttontipA;
        private System.Windows.Forms.Label inputtip;
        private System.Windows.Forms.Label labelNoPeople;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonpersonS;
        private System.Windows.Forms.Label inputperson;
        private System.Windows.Forms.Button buttonpersonA;
        private System.Windows.Forms.Label outlabeltip;
        private System.Windows.Forms.Label labelperpersontip;
        private System.Windows.Forms.Label outlabeltotal;
        private System.Windows.Forms.Label labelperpersontotal;
        private System.Windows.Forms.Label outtipperperson;
        private System.Windows.Forms.Label outtotalperperson;
    }
}

