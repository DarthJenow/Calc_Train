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
        /// Just closes the form
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
            saveSettings();

            this.Close();
        }

        /// <summary>
        /// saves the current settings
        /// </summary>
        public void saveSettings()
        {
            main main = new main();
            
            main.boolOperand.plus = checkBoxPlus.Checked;
            main.boolOperand.minus = checkBoxMinus.Checked;
            main.boolOperand.multiply = checkBoxMultiply.Checked;
            main.boolOperand.divide = checkBoxDivide.Checked;
        }

        private void settings_Load(object sender, EventArgs e)
        {
            checkBoxPlus.Checked = main.boolOperand.plus;
            checkBoxMinus.Checked = main.boolOperand.minus;
            checkBoxMultiply.Checked = main.boolOperand.multiply;
            checkBoxDivide.Checked = main.boolOperand.divide;
        }
    }
}
