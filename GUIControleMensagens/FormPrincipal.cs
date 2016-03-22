using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIControleMensagens
{
    public partial class FormPrincipal : Form
    {
        private FormEnvioMensagem formEnvioMensagem;
        private FormUsuario formusuario;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void envioDeMensagensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formEnvioMensagem == null)
            {
                formEnvioMensagem = new FormEnvioMensagem();
            }
            formEnvioMensagem.ShowDialog(this);
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formusuario == null)
            {
                formusuario = new FormUsuario();
            }
            formusuario.ShowDialog(this);
        }
    }
}
