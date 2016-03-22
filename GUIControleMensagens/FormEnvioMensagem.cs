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
    public partial class FormEnvioMensagem : Form
    {

        private AutoCompleteStringCollection listaNomeUsuarios;
        private ControllerUsuario controleUsuario;
        private ControllerMensagem controleMensagem;
        private List<Usuario> listaUsuarios;


        private Usuario remetenteAtual;
        private Usuario destinatarioAtual;
        private Mensagem mensagemAtual;

        public FormEnvioMensagem()
        {
            InitializeComponent();
            controleMensagem = new ControllerMensagem();
            controleUsuario = new ControllerUsuario();
        }

        private void novo()
        {
            mensagemAtual = new Mensagem();
            textBoxRemetente.Text = "";
            textBoxDestinatario.Text = "";
            textBoxAssunto.Text = "";
            richTextBoxMensagem.Text = "";
        }

        private void autocomplete()
        {

            textBoxRemetente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxRemetente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            listaUsuarios = controleUsuario.ListarUsuarios();
            listaNomeUsuarios = new AutoCompleteStringCollection();
            foreach (Usuario remetente in listaUsuarios)
            {
                
                listaNomeUsuarios.Add(remetente.Nome);
            }
            textBoxRemetente.AutoCompleteCustomSource = listaNomeUsuarios;

            textBoxDestinatario.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxDestinatario.AutoCompleteSource = AutoCompleteSource.CustomSource;

            textBoxDestinatario.AutoCompleteCustomSource = listaNomeUsuarios;

        }

        private void FormEnvioMensagem_Load(object sender, EventArgs e)
        {
            novo();
            autocomplete();
        }

        private void textBoxRemetente_TextChanged(object sender, EventArgs e)
        {
            int index = listaNomeUsuarios.IndexOf(textBoxRemetente.Text);
            if (index == -1)
            {
                remetenteAtual = null;
                return;
            }
            remetenteAtual = listaUsuarios[index];
            mensagemAtual.Remetente = remetenteAtual;
        }

        private void textBoxDestinatario_TextChanged(object sender, EventArgs e)
        {
            int index = listaNomeUsuarios.IndexOf(textBoxDestinatario.Text);
            if (index == -1)
            {
                destinatarioAtual = null;
                return;
            }
            destinatarioAtual = listaUsuarios[index];
            mensagemAtual.Destinatario = destinatarioAtual;
        }
        
        private void buttonEnviarMensagem_Click(object sender, EventArgs e)
        {

            mensagemAtual.Assunto = textBoxAssunto.Text;
            mensagemAtual.Conteudo = richTextBoxMensagem.Text;
            if (controleMensagem.GravarMensagem(mensagemAtual))
            {
                MessageBox.Show("Mensagem enviada com sucesso!");
                novo();
            }
            else
            {
                MessageBox.Show("Erro ao enviar mensagem!");
            }
        }

        private void buttonNovaMensagem_Click(object sender, EventArgs e)
        {
            novo();
        }
    }
}
