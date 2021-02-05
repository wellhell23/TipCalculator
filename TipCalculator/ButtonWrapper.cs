using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TipCalculator
{
    //
    //Custom Button class
    //
    class ButtonWrapper
    {
        public Button button;
        public ButtonWrapper(String name, Size buttonSize, String buttonText, int tabIndex, Point buttonLocation)
        {
            this.button = new Button();
            this.button.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button.Location = buttonLocation; //new System.Drawing.Point(244, 238);
            this.button.Name = name;
            this.button.Size = buttonSize; //new System.Drawing.Size(40, 35);
            this.button.TabIndex = tabIndex;
            this.button.Text = buttonText; //"+";
            this.button.UseVisualStyleBackColor = true;
        }

        public void SetEventHandler(System.EventHandler eventHandler)
        {
            this.button.Click += eventHandler;
        }

        public Button GetButtonObject()
        {
            return button;
        }
    }
}