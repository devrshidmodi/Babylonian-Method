using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BabylonianMethod
{
    public partial class BabylonianMethodForm : Form
    {
        /*
         * The following method is a "constructor method" for the class 'BabylonianMethodForm'.
         * This method is called whenever a new instance of thie class is created (i.e. a new form).
         * See the file 'Program.cs' for the statement that creates a new form object using the class
         * 'BabylonianMethodForm' and then runs the application. 
         * ( Statement is 'Application.Run(new BabylonianMethodForm());' )
         */

        public BabylonianMethodForm()
        {
            // Call object initialization method in 'BabylonianForm.Designer.cs'
            InitializeComponent();

            // The keyword 'this' is a placeholder for the object name. See https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/this
            // Pressing the 'ENTER' key is equivalent to clicking 'SquareRootButton'
            this.AcceptButton = SquareRootButton;

            // The control 'BabylonianDataGridView' has been included mostly for debugging purposes. 
            // You are NOT required to master how to use a DataGridView control. For those of you who are
            // interested, more info can be found on the Web pages listed below:
            // https://stackoverflow.com/questions/32576160/can-i-use-datagridview-without-using-database-data
            // https://stackoverflow.com/questions/2154154/datagridview-how-to-set-column-width
            // https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridviewcolumn.fillweight?redirectedfrom=MSDN&view=netframework-4.8#System_Windows_Forms_DataGridViewColumn_FillWeight
            // http://csharp.net-informations.com/datagridview/csharp-datagridview-tutorial.htm

            /* Set important properties of 'BabylonianDataGridView'.
             * Many (if not all) of these properties can be set through the form designer.
             * However, doing so would lack transparency. That is, someone unfamiliar with the app
             * would have a difficult time understanding how various things were accomplished.
             */
            
            // This property must be set to 'false' to allow for various customizations of 'BabylonianDataGridView'
            BabylonianDataGridView.EnableHeadersVisualStyles = false;

            /* 
             * Set properties relating to the appearance of 'BabylonianDataGridView'.
             */ 
            BabylonianDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightCyan;
            BabylonianDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            BabylonianDataGridView.ColumnHeadersDefaultCellStyle.Font
                                                    = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Pixel);
            BabylonianDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BabylonianDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Columns fill entire width of 'BabylonianDataGridView'
            BabylonianDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Set relative column widths e.g. column 0 width = 1/(1+5+5+5) = 1/16th of total width
            BabylonianDataGridView.Columns[0].FillWeight = 1;
            BabylonianDataGridView.Columns[1].FillWeight = 5;
            BabylonianDataGridView.Columns[2].FillWeight = 5;
            BabylonianDataGridView.Columns[3].FillWeight = 5;

            // Row headers not needed
            BabylonianDataGridView.RowHeadersVisible = false;

            // Disallow editing since the DataGridView control is being used purely for output purposes.
            BabylonianDataGridView.ReadOnly = true;
        }

        /*
         * This procedure has certain nasty bugs that were included intentionally.
         * Your job is to identify, explain, and correct the bugs.
         */
        private void SquareRootButton_Click(object sender, EventArgs e)
        {
            // Clear any existing rows from 'BabylonianDataGridView'.
            BabylonianDataGridView.Rows.Clear();
            BabylonianDataGridView.Refresh();

            int n = 1;

            double q = Convert.ToDouble(qTextBox.Text);
            double qN = q / 2; // Simple way to calculate q1 (first term in sequence)
            double qDividedByQn = q / qN;
            double b = 0;
            double difference = qN - qDividedByQn;
            
            // Add a row to 'BabylonianDataGridView' of initial values.
            BabylonianDataGridView.Rows.Add(new string[] {n.ToString(), qN.ToString(),
                                                          qDividedByQn.ToString(), difference.ToString() });

            while (b - difference != 0)
            {
                qN = (qN + qDividedByQn) / 2;
                qDividedByQn = q / qN;
                n++;
                b = difference;
                difference = qN - qDividedByQn;

                // Add a row to 'BabylonianDataGridView' for iteration 'n'.
                BabylonianDataGridView.Rows.Add(new string[] {n.ToString(), qN.ToString(),
                                                          qDividedByQn.ToString(), difference.ToString() });

                Application.DoEvents(); // Process the event queue to prevent application hang.
            }

            SquareRootLabel.Text = "The square root of " + q.ToString() + " is approximately " + qN.ToString() + ".";
        }
    }


}
