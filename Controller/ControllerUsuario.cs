using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
namespace Controller
{
    public class ControllerUsuario
    {
        public bool GravarUsuario(Usuario usuario)
        {
            SqlConnection conexao = ADODBConnection.Connection();
            SqlCommand comando = conexao.CreateCommand();

            if(usuario.IDUsuario==0)
            {
                comando.CommandText = "insert into tbl_usuario (nome,email) values(@nome,@email)";
                comando.Parameters.AddWithValue("@nome", usuario.Nome);
                comando.Parameters.AddWithValue("@email", usuario.Email);
            }else
            {
                comando.CommandText = "update tbl_usuario set nome=@nome,email=@email where id_usuario=@idusuario";
                comando.Parameters.AddWithValue("@nome", usuario.Nome);
                comando.Parameters.AddWithValue("@email", usuario.Email);
                comando.Parameters.AddWithValue("@idusuario", usuario.IDUsuario);
            }
            conexao.Open();
            int linhasModificadas = comando.ExecuteNonQuery();
            conexao.Close();
            if (linhasModificadas == 0)
                return false;
            else
                return true;
        }

        public bool ExcluirUsuario(int idUsuario)
        {
            SqlConnection conexao = ADODBConnection.Connection();
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "delete from tbl_usuario where id_usuario=@idusuario";
            comando.Parameters.AddWithValue("@idusuario", idUsuario);
            conexao.Open();
            int linhasModificadas = comando.ExecuteNonQuery();
            conexao.Close();
            if (linhasModificadas == 0)
                return false;
            else
                return true;
        }

        public List<Usuario> ListarUsuarios()
        {
            SqlConnection conexao = ADODBConnection.Connection();
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "select * from tbl_usuario order by nome";
            conexao.Open();
            List<Usuario> listaUsuarios = new List<Usuario>();
            Usuario usuario;
            using (SqlDataReader reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    usuario = new Usuario();
                    usuario.IDUsuario = reader.GetInt32(0);
                    usuario.Nome = reader.GetString(1);
                    usuario.Email = reader.GetString(2);
                    listaUsuarios.Add(usuario);
                }
                conexao.Close();
                return listaUsuarios;
            }
        }

        public Usuario LocalizarUsuarioPorID(int idUsuario)
        {
            SqlConnection conexo = ADODBConnection.Connection();
            SqlCommand comand = conexo.CreateCommand();
            comand.CommandText = "select * from tbl_usuario where id_usuario=@idusuario";
            comand.Parameters.AddWithValue("@idusuario", idUsuario);
            conexo.Open();
            Usuario usuario = null;
            using (SqlDataReader read = comand.ExecuteReader())
            {
                if (read.Read())
                {
                    usuario = new Usuario();
                    usuario.IDUsuario = read.GetInt32(0);
                    usuario.Nome = read.GetString(1);
                    usuario.Email = read.GetString(2);
                }

                conexo.Close();
                return usuario;
            }
        }
    }
}
