using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flotta_Navale_JB
{
    public partial class FlottaNavale : Form
    {
        public FlottaNavale()
        {
            InitializeComponent();
        }

        private void FlottaNavale_Load(object sender, EventArgs e)
        {
            dGV_Navi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGV_Navi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dGV_Navi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGV_Comandanti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGV_Comandanti.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dGV_Comandanti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Nome_flotta fNFlotta = new Nome_flotta();
            fNFlotta.ShowDialog();
        }
    }
}
