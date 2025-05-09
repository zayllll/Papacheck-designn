using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = new DataGridView();
            dgv.Dock = DockStyle.Fill;
            this.Controls.Add(dgv);

            // Add a column for names
            dgv.Columns.Add("nameColumn", "Name");

            // Add some rows
            dgv.Rows.Add("Alice");
            dgv.Rows.Add("Bob");
            dgv.Rows.Add("Charlie");
        }
    }
}
