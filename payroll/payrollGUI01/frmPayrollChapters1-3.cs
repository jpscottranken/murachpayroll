using System;
using System.Windows.Forms;

/*
 * 
 *      TEST DATA:
 *      =========
 *      Person 1:   hours 20    rate 20     gross  400
 *      Person 2:   hours 30    rate 20     gross  600
 *      Person 3:   hours 10    rate 20     gross  200
 *      Person 4:   hours 50    rate 10     gross  550
 *      Person 5:   hours 60    rate 30     gross 2100
 *      
 *      EXPECTED RESULTS:
 *      =================
 *      Total # Gross Pays: 5
 *      Total gross pay:    3850
 *      Average gross pay:   770
 *      Highest gross pay:  2100
 *      Lowest  gross pay:   200
 */

namespace payrollGUI01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //  Program constants
        const decimal MAXNONOT = 40.0m;         //  Max hours worked with no OT
        const decimal OTRATE   =  1.5m;         //  Overtime rate

        //  Class-Level variables
        int totalNumberGrossPays = 0;           //  Total number of gross pays calculated
        decimal totalGrossPay    = 0.0m;        //  Total of all gross pays
        decimal averageGrossPay  = 0.0m;        //  Average gross pay
        decimal highestGrossPay  = -1000m;      //  Highest gross pay
        decimal lowestGrossPay   = 11111111m;   //  Lowest  gross pay

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal hours = Convert.ToDecimal(txtHours.Text);
            decimal rate  = Convert.ToDecimal(txtRate.Text);
            decimal gross = 0m;

            //  Calculate gross pay, first check for no OT worked
            if (hours <= MAXNONOT)  // Worked 0 - 40 hours NO Overtime
            {
                gross = hours * rate;
            }
            else
            {                       // Worked > 40 hour have Overtime
                gross = ((MAXNONOT * rate)   +                  //  straight time (40 hours)
                         ((hours - MAXNONOT) * rate * OTRATE)); //  overtime (> 40 hours)
            }

            //  Set associated textbox
            txtGross.Text = gross.ToString("c");

            //  Increment totalNumberGrossPays
            //  Set associated textbox
            ++totalNumberGrossPays;
            txtTotalNumberGrossPays.Text = totalNumberGrossPays.ToString();

            //  Add current gross pay to totalGrossPay
            //  Set associated textbox
            totalGrossPay += gross;
            txtTotalGrossPay.Text = totalGrossPay.ToString("c");

            //  Calculate average gross pay
            //  Set associated textbox
            averageGrossPay = totalGrossPay / totalNumberGrossPays;
            txtAverageGrossPay.Text = averageGrossPay.ToString("c");

            //  Calculate highest gross Pay
            if (gross > highestGrossPay)
            {
                highestGrossPay = gross;
            }

            //  Set associated textbox
            txtHighestGrossPay.Text = highestGrossPay.ToString("c");

            //  Calculate lowest gross Pay
            if (gross < lowestGrossPay)
            {
                lowestGrossPay = gross;
            }

            //  Set associated textbox
            txtLowestGrossPay.Text = lowestGrossPay.ToString("c");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text  = "";
            txtHours.Text     = "";
            txtRate.Text      = "";
            txtGross.Text     = "";
            txtFirstName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                "Do You Really Want To Exit?",
                "EXIT NOW?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
