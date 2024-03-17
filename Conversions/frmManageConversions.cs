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
    public partial class frmManageConversions : Form
    {
        public frmManageConversions()
        {
            InitializeComponent();
        }

        public List<Conversion> conversions = null;

        private void frmManageConversions_Load(object sender, EventArgs e)
        {
            conversions = ConversionsDB.GetConversions();
            this.LoadConversions();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddConversion frmAddConversion = new frmAddConversion();
            Conversion conversion = frmAddConversion.GetNewConversion();

            if (conversion != null )
            {
                conversions.Add(conversion);
                ConversionsDB.SaveConversions(conversions);
                this.LoadConversions();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int selectedConversion = lstConversions.SelectedIndex;
            if (selectedConversion != -1)
            {
                Conversion conversion = conversions[selectedConversion];
                string message = "Are you sure you want to delete '" + conversion.ToString() + "'?";

                DialogResult button = MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);

                if (button == DialogResult.Yes)
                {
                    conversions = ConversionsDB.RemoveConversion(conversion);
                    this.LoadConversions();
                }
            }

        }

        private void btnRestoreDefaults_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to restore default conversions?";

            DialogResult button = MessageBox.Show(message, "Confirm Delete",
                MessageBoxButtons.YesNo);

            if (button == DialogResult.Yes)
            {
                ConversionsDB.RestoreDefaultConversions();
                conversions = ConversionsDB.GetConversions();
                this.LoadConversions();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (conversions != null)
            {
                ConversionsDB.SaveConversions(conversions);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadConversions()
        {
            lstConversions.Items.Clear();
            foreach (Conversion conversion in conversions)
            {
                lstConversions.Items.Add(conversion.GetFullText());
            }
        }
    }
}
