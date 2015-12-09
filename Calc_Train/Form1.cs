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
        /// <summary>
        /// Creates gloabl variables
        /// </summary>
        public int x1;
        public int x2;
        public int y;
        public string task;
        public Boolean solving = false;

        /// <summary>
        /// Gets executed when the programm is started
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            textBoxResult.Enabled = false;
            buttonEnterResult.Enabled = false;
            buttonStart.Text = "Start";
        }

        /// <summary>
        /// Enables or disables task creating
        /// </summary>
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

        #region makeTasks
        /// <summary>
        /// gets a random operation
        /// </summary>
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

        /// <summary>
        /// makes a plus task
        /// </summary>
        public void operationPlus()
        {
            Random random = new Random();

            x1 = random.Next(0, 21);
            x2 = random.Next(0, 21);
            y = x1 + x2;

            task = x1 + " + " + x2;

            labelTask.Text = task;
        }

        /// <summary>
        /// makes a minus task
        /// </summary>
        public void operationMinus()
        {
            Random random = new Random();

            x1 = random.Next(0, 21);
            x2 = random.Next(0, x1);
            y = x1 - x2;

            task = x1 + " - " + x2;
            labelTask.Text = task;
        }

        /// <summary>
        /// makes a multiply task
        /// </summary>
        public void operationMultiply()
        {
            Random random = new Random();

            x1 = random.Next(0, 12);
            x2 = random.Next(0, 12);
            y = x1 * x2;

            task = x1 + " * " + x2;

            labelTask.Text = task;
        }

        /// <summary>
        /// makes a divide task
        /// </summary>
        public void operationDivide()
        {
            Random random = new Random();

            y = random.Next(0, 12);
            x2 = random.Next(1, 12);
            x1 = x2 * y;

            task = x1 + " / " + x2;
            labelTask.Text = task;
        }
        #endregion

        /// <summary>
        /// gets proceeded if the start / stop button gets klicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Enables / disables the form
            changeStart();

            // if calcuating mode is enabled, the first task gets generated, if not the label gets changed
            if (solving)
            {
                makeTask();
            }
            else
            {
                labelTask.Text = "Operation";
            }
        }

        /// <summary>
        /// gets enabled if while the textBoxResult is focused and a key gets pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key was enter
            if (e.KeyChar == (char) ConsoleKey.Enter)
            {
                // simulates a click on the enterButton
                buttonEnterResult_Click(null, null);

                // disables the beep
                e.Handled = true;
            }
        }

        /// <summary>
        /// gets enabled if the enter button gets klicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnterResult_Click(object sender, EventArgs e)
        {
            // tries to parse the textfield.text
            try
            {
                // Checks if entered answer is right, log gets written and next task gets generated, else also log and textfield.text gets cleared
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
            catch (FormatException) // if a FormatException appears, writes log and clears textfield.text
            {
                richTextBoxLog.AppendText("UnexpectedInput.Exception" + "\r\n");
                textBoxResult.Text = "";
                labelTask.Text = task;
            }

        }

        /// <summary>
        /// Closes the programm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
