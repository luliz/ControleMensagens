using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller;

namespace GUIControleMensagens
{
    public partial class FormLeituraMensagem : Form
    {

        private List<Usuario> listaUsuarios;
        private AutoCompleteStringCollection listaNomeUsuarios;
        private ControllerUsuario controleUsuario;
        private ControllerMensagem controleMensagem;


        private Usuario usuarioAtual;

        public FormLeituraMensagem()
        {
            InitializeComponent();
            listaUsuarios = new List<Usuario> ();
            controleMensagem = new ControllerMensagem();
            controleUsuario = new ControllerUsuario();
        }

        private void labelAssunto_Click(object sender, EventArgs e)
        {

        }

        private void autocomplete()
        {

            textBoxUsuario.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxUsuario.AutoCompleteSource = AutoCompleteSource.CustomSource;
            listaUsuarios = controleUsuario.ListarUsuarios();
            listaNomeUsuarios = new AutoCompleteStringCollection();
            foreach (Usuario usuario in listaUsuarios)
            {

                listaNomeUsuarios.Add(usuario.Nome);
            }
            textBoxUsuario.AutoCompleteCustomSource = listaNomeUsuarios;


        }
        private void FormLeituraMensagem_Load(object sender, EventArgs e)
        {
            autocomplete();
        }
        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            int index = listaNomeUsuarios.IndexOf(textBoxUsuario.Text);
            if (index == -1)
            {
                usuarioAtual = null;
                return;
            }
            usuarioAtual = listaUsuarios[index];
        }

        private void atualizarDataGrid()
        {

            dataGridView1.DataSource =
                controleMensagem.ListarMensagensRecebidasPorUsuario(usuarioAtual.IDUsuario);
            dataGridView1.Columns[0].Visible = false;
        }

        private void buttonListarMensagens_Click(object sender, EventArgs e)
        {
            atualizarDataGrid();
        }
    }
}
