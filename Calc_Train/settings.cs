using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_Train
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();

            checkBoxPlus.Checked = main.boolOperand.plus;
            checkBoxMinus.Checked = main.boolOperand.minus;
            checkBoxMultiply.Checked = main.boolOperand.multiply;
            checkBoxDivide.Checked = main.boolOperand.divide;
        }

        /// <summary>
        /// just closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Saves all and then closes the box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (saveSettings())
            {
               this.Close();
            }
        }

        /// <summary>
        /// saves the current settings
        /// </summary>
        public Boolean saveSettings()
        {
            main main = new main();

            // checks if at least one operation method is checked
            if (checkBoxPlus.Checked || checkBoxMinus.Checked || checkBoxMultiply.Checked || checkBoxDivide.Checked)
            {
                // writes state to variables in "main"
                main.boolOperand.plus = checkBoxPlus.Checked;
                main.boolOperand.minus = checkBoxMinus.Checked;
                main.boolOperand.multiply = checkBoxMultiply.Checked;
                main.boolOperand.divide = checkBoxDivide.Checked;

                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("You need to check at least one operation type!", "Error", MessageBoxButtons.OK);
                return false;
            }
        }

        private void settings_Load(object sender, EventArgs e)
        {
            // loads the settings when the window gets opened

            checkBoxPlus.Checked = main.boolOperand.plus;
            checkBoxMinus.Checked = main.boolOperand.minus;
            checkBoxMultiply.Checked = main.boolOperand.multiply;
            checkBoxDivide.Checked = main.boolOperand.divide;
        }
    }
}
