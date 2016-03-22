using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;

namespace Controller
{
    public class ControllerMensagem
    {
        public bool GravarMensagem(Mensagem mensagem)
        {

            SqlConnection conexao = ADODBConnection.Connection();
            SqlCommand comando = conexao.CreateCommand();

            comando.CommandText = "insert into tbl_mensagem (id_usuario_remetente, id_usuario_destinatario, assunto, mensagem) values (@remetente, @destinatario, @assunto, @mensagem)";
            comando.Parameters.AddWithValue("@remetente", mensagem.Remetente.IDUsuario);
            comando.Parameters.AddWithValue("@destinatario", mensagem.Destinatario.IDUsuario);
            comando.Parameters.AddWithValue("@assunto", mensagem.Assunto);
            comando.Parameters.AddWithValue("@mensagem", mensagem.Conteudo);

            conexao.Open();

            int linhasModificadas = comando.ExecuteNonQuery();
            conexao.Close();
            if (linhasModificadas == 0)
                return false;
            else
                return true;

        }

        public List<Mensagem> ListarMensagensRecebidasPorUsuario(int idUsuario)
        {

            SqlConnection conexao = ADODBConnection.Connection();
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "select * from tbl_mensagem where id_usuario_destinatario = @destinatario";
            comando.Parameters.AddWithValue ("@destinatario", idUsuario);
            conexao.Open();
            List<Mensagem> listaMensagens = new List<Mensagem>();
            Mensagem mensagem;
            ControllerUsuario controle = new ControllerUsuario ();
            using (SqlDataReader reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    mensagem = new Mensagem();
                    mensagem.IDMensagem = reader.GetInt32(0);
                    mensagem.Remetente = controle.LocalizarUsuarioPorID (reader.GetInt32(1));
                    mensagem.Destinatario = controle.LocalizarUsuarioPorID(reader.GetInt32(2));
                    mensagem.Assunto = reader.GetString(3);
                    mensagem.Conteudo = reader.GetString(4);

                    listaMensagens.Add(mensagem);
                }
                conexao.Close();
                return listaMensagens;
            }
        }
    }
}
