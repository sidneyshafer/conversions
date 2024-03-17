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
    public partial class frmConversions : Form
    {
        public frmConversions()
        {
            InitializeComponent();
        }

        public List<Conversion> conversions = null;

        private void frmConversions_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            errorMessage += Validator.IsPresent(txtValue.Text, "Value");

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Entry Error", MessageBoxButtons.OKCancel);
            }

            else
            {
                decimal value = Convert.ToDecimal(txtValue.Text);

                foreach (var item in lstConversions.SelectedItems)
                {
                    foreach (Conversion conversion in conversions)
                    {
                        if (conversion.ToString() == item.ToString())
                        {
                            string result = conversion.DisplayConversion(value);
                            lstCalculations.Items.Add(result);
                        }
                    }    
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtValue.Text = "";
            lstCalculations.Items.Clear();
            lstConversions.SelectedItems.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnManageConversions_Click(object sender, EventArgs e)
        {
            frmManageConversions frmManageConversions = new frmManageConversions();
            frmManageConversions.ShowDialog();
            this.Refresh();
        }
        
        override public void Refresh()
        {
            conversions = ConversionsDB.GetConversions();
            lstConversions.Items.Clear();
            foreach (Conversion conversion in conversions)
            {
                lstConversions.Items.Add(conversion.ToString());
            }
        }
        
        
    }
}
