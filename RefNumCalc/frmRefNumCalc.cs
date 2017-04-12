using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ReferenceNumberCalculator
{
    public partial class frmRefNumCalc : Form
    {
        public frmRefNumCalc()
        {
            InitializeComponent();

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnCalcRefNum, "Multiplies the value by 1 / 3 / 7 (123 = 1*1 + 3*2 + 7*3) and substracts the outcome from the nearest ten (123 = ... = 30-28 -> 2).");
        }

        private void btnCalcRefNum_Click(object sender, EventArgs e)
        {
            calcRefNumber(txtInputNumber.Text);
        }

        private void calcRefNumber(String txtNumber)
        {

            int result;
            Int64 number;

            if (IsNumeric(txtNumber))
            {
               number = Convert.ToInt64(txtNumber);
               RefNumberCalculator refCalculator = new RefNumberCalculator();
               result = refCalculator.Calculate(number);
            }
            else
            {
                MessageBox.Show("Only positive integer allowed.", "Error", MessageBoxButtons.OK);
                return;
            }
            txtResult.Text = result.ToString();

        }

        /// <summary>
        /// Check if a string value is numeric.
        /// </summary>
        /// <param name="strTextEntry">String value</param>
        /// <returns>True/False</returns>
        private bool IsNumeric(string strTextEntry)
        {
            Regex objNotWholePattern = new Regex("[^0-9]");
            return !objNotWholePattern.IsMatch(strTextEntry)
                 && (strTextEntry != "");
        }

    }
}
