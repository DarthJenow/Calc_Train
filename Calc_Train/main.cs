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
    public partial class main : Form
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
        /// class to access the variables from other forms
        /// </summary>
        public static class boolOperand
        {
            // indicte if the mode is active
            public static Boolean plus = true;
            public static Boolean minus = true;
            public static Boolean multiply = true;
            public static Boolean divide = true;
        }

        /// <summary>
        /// Gets executed when the programm is started
        /// </summary>
        public main()
        {
            InitializeComponent();

            // disables by program start the textbox and the enter button
            textBoxResult.Enabled = false;
            buttonEnterResult.Enabled = false;
            buttonStart.Text = "Start";

            // enables by default all 4 kinds of operations
            boolOperand.plus = true;
            boolOperand.minus = true;
            boolOperand.multiply = true;
            boolOperand.divide = true;
        }

        /// <summary>
        /// Enables or disables task creating
        /// </summary>
        public void changeStart()
        {
            if (solving)
            {
                // disables textbox and enter button
                textBoxResult.Enabled = false;
                buttonEnterResult.Enabled = false;
                buttonStart.Text = "Start";

                //enables menu strip
                menuStrip1.Enabled = true;

                // enables the window controls (e.g. close button etc)
                this.ControlBox = true;

                solving = false;
            }
            else
            {
                // enables textbox and enter button
                textBoxResult.Enabled = true;
                buttonEnterResult.Enabled = true;
                buttonStart.Text = "Stop";

                // disables menu strip
                menuStrip1.Enabled = false;

                // disables the window controls (e.g. close button etc)
                this.ControlBox = false;

                solving = true;
            }
        }

        #region makeTasks
        /// <summary>
        /// gets a random operation
        /// </summary>
        public void makeTask()
        {
            int operation;
            Boolean repeat = true;

            // loos repeats as long, until a task gets randomized which is "allowed" by the settings
            do {
                operation = (new Random()).Next(0, 4);

                switch (operation)
                {
                    case 0:
                        repeat = boolOperand.plus;

                        operationPlus();
                        break;
                    case 1:
                        repeat = boolOperand.minus;

                        operationMinus();
                        break;
                    case 2:
                        repeat = boolOperand.multiply;

                        operationMultiply();
                        break;
                    case 3:
                        repeat = boolOperand.divide;

                        operationDivide();
                        break;
                }
            } while (!repeat) ;
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
        /// gets enabled while the textBoxResult is focused and a key gets pressed
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

        /// <summary>
        /// opens the settings form if the tool strip entry for settings gets clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings settings = new settings();
            
            settings.ShowDialog();
        }

        // opens a version info popup if the tool strip entry for version gets clicked
        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version: v0.1.2", "Version info", MessageBoxButtons.OK);
        }
    }
}
