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
    public partial class Ins_Comandante : Form
    {
        internal Comandante comandante;
        public Ins_Comandante()
        {
            InitializeComponent();
        }

        private void Ins_Comandante_Load(object sender, EventArgs e)
        {
            dTP_Comandante.Value.ToShortDateString();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void btn_AnnullaComandante_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btn_CreaComandante_Click(object sender, EventArgs e)
        {
            if (tB_nomeComandante.Text != string.Empty && tB_Telefono.Text != string.Empty)
            {
                try
                {
                    comandante = new Comandante(tB_nomeComandante.Text, tB_Telefono.Text, dTP_Comandante.Value, (StatoComandante)comboBox1.SelectedIndex);
                    DialogResult = DialogResult.OK;
                }
                catch (Exception)
                {
                    MessageBox.Show("Sei andato oltre il range d'inserimento", "Errore inserimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Dati mancanti!", "Errore inserimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
