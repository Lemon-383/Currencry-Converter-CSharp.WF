using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Currency_CSharp
{
    public partial class MainForm : Form
    {
        private List<string> currencies = new List<string>();
        private List<NumericUpDown> numTB_crncRates = new List<NumericUpDown>();
        private List<TextBox> tBox_convResults = new List<TextBox>();

        private int selCrncId;
        private decimal srcCrncValue;

        private string databasePath = "database.txt";

        public MainForm()
        {
            InitializeComponent();
            MinimumSize = new Size(Width, Height);
            MaximumSize = new Size(Width, Height);

            selCrncId = -1;
            srcCrncValue = numTB_srcCrncValue.Value;
            numTB_srcCrncValue.Maximum = decimal.MaxValue;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDataBase(databasePath);
        }
        

        private void cBox_srcCrnc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBox_srcCrnc.SelectedIndex == -1) 
                return;

            if (selCrncId == -1)
            {
                pnl_crncRates.Enabled = true;
                pnl_convRes.Enabled = true;
            }
            else
            {
                pnl_crncRates.Controls[selCrncId].Enabled = true;
                pnl_convRes.Controls[selCrncId].Enabled = true;
            }

            selCrncId = cBox_srcCrnc.SelectedIndex;
            numTB_crncRates[selCrncId].Value = 0;
            tBox_convResults[selCrncId].Text = string.Empty;
            pnl_crncRates.Controls[selCrncId].Enabled = false;
            pnl_convRes.Controls[selCrncId].Enabled = false;
        }

        private void numTB_srcCrncValue_ValueChanged(object sender, EventArgs e)
        {
            srcCrncValue = numTB_srcCrncValue.Value;
            for (int i = 0; i < currencies.Count; i++)
                if (numTB_crncRates[i].Value != 0 && pnl_crncRates.Controls[i].Enabled)
                    Convert(i);
        }

        private void btn_addCrnc_Click(object sender, EventArgs e)
        {
            AddCrncForm addCrncForm = new AddCrncForm();
            addCrncForm.ShowDialog();

            if (addCrncForm.DialogResult == DialogResult.OK)
                if (!currencies.Contains(addCrncForm.crncName))
                    AddCrnc(addCrncForm.crncName);
                else
                    MessageBox.Show("Such currency has already been added", "Error", MessageBoxButtons.OK);
            SaveDataBase(databasePath);
        }


        private void LoadDataBase(string path)
        {
            StreamReader sr;

            try
            {
                sr = new StreamReader(path);
            }
            catch(Exception ex)
            {
                MessageBox.Show("DataBase read error: " + ex.Message, "Error", MessageBoxButtons.OK);
                return;
            }

            string line;
            while ((line = sr.ReadLine()) != null)
                if (line.Length == 3)
                    AddCrnc(line);

            sr.Close();
        }

        private void SaveDataBase(string path)
        {
            StreamWriter sw;

            try
            {
                sw = new StreamWriter(path);
            }
            catch(Exception ex)
            {
                MessageBox.Show("DataBase write error: " + ex.Message, "Error", MessageBoxButtons.OK);
                return;
            }

            foreach (string item in currencies)
                sw.WriteLine(item);

            sw.Close();
        }

        void Convert(int trgCrncId)
        {
            tBox_convResults[trgCrncId].Text = 
                string.Format("{0:0.00##}", numTB_crncRates[trgCrncId].Value * srcCrncValue);
        }

        void AddCrnc(string name)
        {
            cBox_srcCrnc.Items.Add(name);


            Label lbl_rate = new Label();
            lbl_rate.Font = new Font("Microsoft Sans Serif", 9F);
            lbl_rate.Location = new Point(0, 0);
            lbl_rate.Size = new Size(65, 15);
            lbl_rate.AutoSize = true;
            lbl_rate.Text = name + " Rate:";

            NumericUpDown numTB_rate = new NumericUpDown();
            numTB_rate.Location = new Point(lbl_rate.Width, 0);
            numTB_rate.Size = new Size(75, 20);
            numTB_rate.TextAlign = HorizontalAlignment.Right;
            numTB_rate.DecimalPlaces = 4;
            numTB_rate.Maximum = decimal.MaxValue;
            numTB_rate.ValueChanged += delegate { Convert(currencies.IndexOf(name)); };

            Panel pnl_rateField = new Panel();
            pnl_rateField.Size = new Size(numTB_rate.Width + lbl_rate.Width, numTB_rate.Height);
            pnl_rateField.Controls.Add(lbl_rate);
            pnl_rateField.Controls.Add(numTB_rate);
            pnl_crncRates.Controls.Add(pnl_rateField);


            Label lbl_res = new Label();
            lbl_res.AutoSize = true;
            lbl_res.Font = new Font("Microsoft Sans Serif", 9F);
            lbl_res.Location = new Point(0, 0);
            lbl_res.Size = new Size(40, 15);
            lbl_res.Text = name + ":";

            TextBox tBox_res = new TextBox();
            tBox_res.Location = new Point(lbl_res.Width, 0);
            tBox_res.Size = new Size(100, 20);
            tBox_res.ReadOnly = true;

            Panel pnl_res = new Panel();
            pnl_res.Size = new Size(lbl_res.Width + tBox_res.Width, tBox_res.Height);
            pnl_res.Controls.Add(lbl_res);
            pnl_res.Controls.Add(tBox_res);
            pnl_convRes.Controls.Add(pnl_res);


            currencies.Add(name);
            numTB_crncRates.Add(numTB_rate);
            tBox_convResults.Add(tBox_res);
        }
    }
}
