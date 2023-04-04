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
    public partial class Ins_Nave : Form
    {
        internal Nave nave;
        public Ins_Nave()
        {
            InitializeComponent();
        }

        private void Ins_Nave_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void btn_AnnullaNave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btn_CreaNave_Click(object sender, EventArgs e)
        {
            if (tB_nomeNave.Text != string.Empty && tB_stazzaNave.Text != string.Empty && tB_velocitaNave.Text != string.Empty)
            {
                try
                {
                    nave = new Nave(tB_nomeNave.Text, tB_stazzaNave.Text, tB_velocitaNave.Text, (StatoNave)comboBox1.SelectedIndex);
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
