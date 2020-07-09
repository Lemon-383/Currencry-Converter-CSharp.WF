using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_CSharp
{
    public partial class AddCrncForm : Form
    {
        public string crncName;

        public AddCrncForm()
        {
            InitializeComponent();
            MinimumSize = Size;
            MaximumSize = Size;
        }


        private void tBox_crncName_TextChanged(object sender, EventArgs e)
        {
            if (tBox_crncName.Text.Length >= 4)
                tBox_crncName.Text = tBox_crncName.Text.Remove(3);

            tBox_crncName.Text = tBox_crncName.Text.ToUpper();
            crncName = tBox_crncName.Text;

            tBox_crncName.SelectionStart = tBox_crncName.Text.Length;
            tBox_crncName.SelectionLength = 0;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (tBox_crncName.Text.Length != 3)
            {
                MessageBox.Show("Invalid Currency Code", "Error", MessageBoxButtons.OK);
                return;
            }

            DialogResult = DialogResult.OK;
        }

    }
}
