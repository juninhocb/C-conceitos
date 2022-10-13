using ClassLibrary_Model.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_Main.Interface;

namespace BibliotecaClasses_Model.DataBase
{
    public class ContatoRepositorio 
    {
        public Contato SaveContato(Contato contato, MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_CONTATO, conn);

                //TODO: Testar o comando sem o @, pois não vejo caractere especial
                cmd.Parameters.Add(@"nome", MySqlDbType.VarChar, 45).Value = contato.Nome;
                cmd.Parameters.Add(@"celular", MySqlDbType.VarChar, 15).Value = contato.Celular;
                cmd.Parameters.Add(@"email", MySqlDbType.VarChar, 50).Value = contato.Email;
                cmd.Parameters.Add(@"rua", MySqlDbType.VarChar, 45).Value = contato.Rua;
                cmd.Parameters.Add(@"numero", MySqlDbType.Int32).Value = contato.Numero;
                cmd.Parameters.Add(@"bairro", MySqlDbType.VarChar, 45).Value = contato.Bairro;
                cmd.Parameters.Add(@"cidade", MySqlDbType.VarChar, 45).Value = contato.Cidade;
                cmd.Parameters.Add(@"uf", MySqlDbType.VarChar, 45).Value = contato.Uf;
                cmd.Parameters.Add(@"status", MySqlDbType.Enum).Value = 'A';
                cmd.ExecuteNonQuery();

                return contato;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Ocorreu um erro no MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }


        public MySqlDataReader GetContatos(MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_CONTATOS, conn);
                MySqlDataReader dadosContato = cmd.ExecuteReader();
                return dadosContato;

            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }  

        }

        public MySqlDataReader GetContato(int id, MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_CONTATO, conn);
                cmd.Parameters.Add("@id_contato", MySqlDbType.Int32).Value = id;
                MySqlDataReader dadosContato = cmd.ExecuteReader();
                return dadosContato;

            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        public void UpdateContato(int id, Contato contato, MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_UPADTE_CONTATO, conn);
                cmd.Parameters.Add(@"nome", MySqlDbType.VarChar, 45).Value = contato.Nome;
                cmd.Parameters.Add(@"celular", MySqlDbType.VarChar, 15).Value = contato.Celular;
                cmd.Parameters.Add(@"email", MySqlDbType.VarChar, 50).Value = contato.Email;
                cmd.Parameters.Add(@"rua", MySqlDbType.VarChar, 45).Value = contato.Rua;
                cmd.Parameters.Add(@"numero", MySqlDbType.Int32).Value = contato.Numero;
                cmd.Parameters.Add(@"bairro", MySqlDbType.VarChar, 45).Value = contato.Bairro;
                cmd.Parameters.Add(@"cidade", MySqlDbType.VarChar, 45).Value = contato.Cidade;
                cmd.Parameters.Add(@"uf", MySqlDbType.VarChar, 45).Value = contato.Uf;
                cmd.Parameters.Add(@"status", MySqlDbType.Enum).Value = 'A';
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                cmd.ExecuteReader();
                

            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        public void DeleteContato(int id, MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_DELETE_CONTATO, conn);
                cmd.Parameters.Add("@id_contato", MySqlDbType.Int32).Value = id;
                cmd.ExecuteReader();
                MessageBox.Show("Contato excluído com sucesso!");
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }


        #region QUERYS
        private const String SQL_SELECT_CONTATOS = @"SELECT * FROM agecontatos.contatos;";
        private const String SQL_DELETE_CONTATO = @"DELETE FROM agecontatos.contatos WHERE id = @id_contato;"; 
        private const String SQL_SELECT_CONTATO = @"SELECT * FROM agecontatos.contatos where id = @id_contato;";
        private const String SQL_UPADTE_CONTATO = @" UPDATE agecontatos.contatos
            set nome = @nome,
            celular = @celular,
            email = @email,
            rua = @rua,
            numero = @numero,
            bairro = @bairro,
            cidade = @cidade,
            uf = @uf,
            status = @status
            where id = @id;
             ";

        private const String SQL_INSERT_CONTATO = @"INSERT INTO contatos
            (nome,
            celular,
            email,
            rua,
            numero,    
            bairro, 
            cidade,
            uf, 
            status
            )
            VALUES
            (@nome,
            @celular,
            @email,
            @rua,
            @numero,
            @bairro,
            @cidade,
            @uf,
            @status)";
    }

    #endregion
}
