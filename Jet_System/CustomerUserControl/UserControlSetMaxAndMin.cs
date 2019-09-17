using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jet_System.CustomerUserControl
{
    public partial class UserControlSetMaxAndMin : UserControl
    {
        public DataGridView CurrentGrid { set; get; }
        public UserControlSetMaxAndMin()
        {
            InitializeComponent();
        }

        private void btnSetMax_Click(object sender, EventArgs e)
        {
            SetDataGrid("上限", Convert.ToDouble(txtMax.Text));
        }

        void SetDataGrid(string index,double value)
        {
            for (int i = 0; i < CurrentGrid.Rows.Count; i++)
            {
                CurrentGrid[index, i].Value = value;
            }
        }

        private void btnSetRate_Click(object sender, EventArgs e)
        {
            SetDataGrid("比例系数", Convert.ToDouble(txtRate.Text));
        }

        private void btnSetMin_Click(object sender, EventArgs e)
        {
            SetDataGrid("下限", Convert.ToDouble(txtMin.Text));
        }

        private void btnSetOffer_Click(object sender, EventArgs e)
        {
            SetDataGrid("偏移", Convert.ToDouble(txtOffer.Text));
        }
    }
}
