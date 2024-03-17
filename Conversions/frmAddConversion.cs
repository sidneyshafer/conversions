using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversions
{
    public partial class frmAddConversion : Form
    {
        public frmAddConversion()
        {
            InitializeComponent();
        }

        private Conversion conversion = null;
        public Conversion GetNewConversion()
        {
            this.ShowDialog();
            return conversion;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            errorMessage += Validator.IsPresent(txtFrom.Text, "From");
            errorMessage += Validator.IsPresent(txtTo.Text, "To");
            errorMessage += Validator.IsDecimal(txtMultiplier.Text, "Multiplier");

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Entry Error", MessageBoxButtons.OKCancel);
            }
            else
            {
                conversion = new Conversion(txtFrom.Text, txtTo.Text, Convert.ToDecimal(txtMultiplier.Text));
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
