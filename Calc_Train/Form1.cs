using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Calc_Train
{
    public partial class Form1 : Form
    {
        public int x1;
        public int x2;
        public int y;
        public string task;
        public Boolean solving = false;

        public Form1()
        {
            InitializeComponent();

            textBoxResult.Enabled = false;
            buttonEnterResult.Enabled = false;
            buttonStart.Text = "Start";
        }

        public void changeStart()
        {
            if (solving)
            {
                textBoxResult.Enabled = false;
                buttonEnterResult.Enabled = false;
                buttonStart.Text = "Start";

                solving = false;
            }
            else
            {
                textBoxResult.Enabled = true;
                buttonEnterResult.Enabled = true;
                buttonStart.Text = "Strop";

                solving = true;
            }
        }

        public void makeTask()
        {
            int operation = (new Random()).Next(0, 4);

            switch (operation)
            {
                case 0:
                    operationPlus();
                    break;
                case 1:
                    operationMinus();
                    break;
                case 2:
                    operationMultiply();
                    break;
                case 3:
                    operationDivide();
                    break;
            }
        }

        public void operationPlus()
        {
            Random random = new Random();

            x1 = random.Next(0, 21);
            x2 = random.Next(0, 21);
            y = x1 + x2;

            task = x1 + " + " + x2;

            labelTask.Text = task;
        }

        public void operationMinus()
        {
            Random random = new Random();

            x1 = random.Next(0, 21);
            x2 = random.Next(0, x1);
            y = x1 - x2;

            task = x1 + " - " + x2;
            labelTask.Text = task;
        }

        public void operationMultiply()
        {
            Random random = new Random();

            x1 = random.Next(0, 12);
            x2 = random.Next(0, 12);
            y = x1 * x2;

            task = x1 + " * " + x2;

            labelTask.Text = task;
        }

        public void operationDivide()
        {
            Random random = new Random();

            y = random.Next(0, 12);
            x2 = random.Next(1, 12);
            x1 = x2 * y;

            task = x1 + " / " + x2;
            labelTask.Text = task;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            changeStart();

            if (solving)
            {
                makeTask();
            }
            else
            {
                labelTask.Text = "Operation";
            }
        }

        private void textBoxResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) ConsoleKey.Enter)
            {
                buttonEnterResult_Click(null, null);

                e.Handled = true;
            }
}

        private void buttonEnterResult_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(textBoxResult.Text) == y)
                {
                    richTextBoxLog.AppendText("\u2714" + " " + task + "\r\n");
                    textBoxResult.Text = "";
                    makeTask();
                }
                else
                {
                    richTextBoxLog.AppendText("\u2718" + " " + task + "\r\n");
                    textBoxResult.Text = "";
                    labelTask.Text = task;
                }
            }
            catch (FormatException)
            {
                richTextBoxLog.AppendText("UnexpectedInput.Exception" + "\r\n");
                textBoxResult.Text = "";
                labelTask.Text = task;
            }

        }
    }
}
