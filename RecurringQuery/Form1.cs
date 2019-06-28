using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecurringQuery
{
    public partial class Form1 : Form
    {
       
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            domainUpDownInterval.SelectedIndex = 0;



        }



        private void DomainUpDownInterval_SelectedItemChanged(object sender, EventArgs e)
        {
            var x = domainUpDownInterval.Text;

            float.TryParse(x, out var y);
            if (y > 60)
            label1.Text = $"Interval: {y / 60} Hours";
            else
            label1.Text = $"Interval: {y} Minutes";

        }

        private void BtnRunOne_Click(object sender, EventArgs e)
        {
            dgvResults.DataSource = DatabaseUtilities.GetDataSet(txtConnectionString.Text,txtQuery.Text).Tables[0];
            dgvResults.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvResults.AutoResizeColumns();
            dgvResults.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvResults.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            tabControl1.SelectedIndex = 1;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }
    }
}
