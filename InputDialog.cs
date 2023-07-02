using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ChatProgram
{
    public partial class InputDialog : Form
    {
        public string inputText;
        private bool onlyNumber;
        public InputDialog(string title, string prompt, string value, bool acceptOnlyNumbers)
        {
            InitializeComponent();

            Text = title;
            MessageLbl.Text = prompt;
            DialogInput.Text = value;

            onlyNumber = acceptOnlyNumbers;
        }

        private void InputDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            inputText = DialogInput.Text; //Sets the value of the result
        }

        private void DialogInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && onlyNumber) //Only allows numbers, if needed
            {
                e.Handled = true;
            }
        }
    }
}
