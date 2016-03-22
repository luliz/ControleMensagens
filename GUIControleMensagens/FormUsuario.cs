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
    public partial class FormUsuario : Form
    {
        private ControllerUsuario controle;

        public FormUsuario()
        {
            InitializeComponent();
            controle = new ControllerUsuario();
        }

        private void novo()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "0";
        }

        private void atualizaGrid()
        {
            dataGridView1.DataSource = controle.ListarUsuarios();
            dataGridView1.Columns[0].Visible = false;
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            atualizaGrid();
            novo();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nome = textBox1.Text;
            usuario.Email = textBox2.Text;


            if (controle.GravarUsuario(usuario))
            {
                MessageBox.Show("Usuario salvo com sucesso");
                novo();
                atualizaGrid();
            }
            else
            {
                MessageBox.Show("Erro ao salvar usuario");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idUsuario = Convert.ToInt32(textBox3.Text);
            if (idUsuario != 0)
            {
                if (controle.ExcluirUsuario(idUsuario))
                {
                    MessageBox.Show("Usuario excluido com sucesso");
                    novo();
                    atualizaGrid();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir Usuario");
                }
            }
            else
            {
                MessageBox.Show("Selecione um Usuario para exclusão");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            novo();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                List<Usuario> lista = (List<Usuario>)dataGridView1.DataSource;
                Usuario usuario = lista[dataGridView1.CurrentRow.Index];
                textBox1.Text = usuario.Nome;
                textBox2.Text = usuario.Email;
                textBox3.Text = usuario.IDUsuario.ToString();
            }
        }

       
    }
}

