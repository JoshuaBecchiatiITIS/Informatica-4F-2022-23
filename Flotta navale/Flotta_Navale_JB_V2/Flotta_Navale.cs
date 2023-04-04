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
            if (fNFlotta.DialogResult == DialogResult.Cancel)
            {
                Environment.Exit(0);
            }
            else if (fNFlotta.DialogResult == DialogResult.OK)
            {
                l_Flotta.Text = $"Flotta: {fNFlotta.nome}";
                FormBorderStyle = FormBorderStyle.FixedSingle;
                MaximizeBox = false;
                MinimizeBox = false;
            }
        }

        private void creaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ins_Nave fINave = new Ins_Nave();
            fINave.ShowDialog();
            if (fINave.DialogResult == DialogResult.OK)
            {
                dGV_Navi.Rows.Add(fINave.nave.Nome, fINave.nave.Stazza, fINave.nave.Velocita, fINave.nave.Stato);
            }
        }

        private void creaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ins_Comandante fIComandante = new Ins_Comandante();
            fIComandante.ShowDialog();
            if (fIComandante.DialogResult == DialogResult.OK)
            {
                dGV_Comandanti.Rows.Add(fIComandante.comandante.Nome, fIComandante.comandante.Telefono, fIComandante.comandante.DataNascita.ToShortDateString(), fIComandante.comandante.Stato);
            }
        }
    }
}
