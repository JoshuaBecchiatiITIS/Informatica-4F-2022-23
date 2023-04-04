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
    public partial class Nome_flotta : Form
    {
        public string nome;
        public Nome_flotta()
        {
            InitializeComponent();
        }

        private void Nome_flotta_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tB_NFlotta.Text != string.Empty)
            {
                nome = tB_NFlotta.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Nome della flotta non inserito!", "Errore inserimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
