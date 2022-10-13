using ClassLibrary_Model.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_Main.Interface;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp_Main.DataBase
{
    public class CompromissoRepositorio : IRepositorios
    {
        

        public object Save(Object compr, MySqlConnection conn)
        {
            Compromisso instanceCompr =  (Compromisso)compr;
            
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_COMPROMISSO, conn);

                //TODO: Testar o comando sem o @, pois não vejo caractere especial
                cmd.Parameters.Add(@"titulo", MySqlDbType.VarChar, 45).Value = instanceCompr.Titulo;
                cmd.Parameters.Add(@"descricao", MySqlDbType.VarChar, 255).Value = instanceCompr.Descricao;
                cmd.Parameters.Add(@"dataini", MySqlDbType.DateTime).Value = instanceCompr.DataInicial;
                cmd.Parameters.Add(@"datafinal", MySqlDbType.DateTime).Value = instanceCompr.DataFinal;
                cmd.Parameters.Add(@"status", MySqlDbType.Enum).Value = instanceCompr.Estado;
                cmd.Parameters.Add(@"id_contato", MySqlDbType.Int32).Value = instanceCompr.Id_contato;
                cmd.ExecuteNonQuery();

                return instanceCompr;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Ocorreu um erro no MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        MySqlDataReader IRepositorios.Load()
        {
            throw new NotImplementedException();
        }

        public MySqlDataReader GetCompromissos(MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_COMPROMISSOS, conn);
                MySqlDataReader dadosCompromissos = cmd.ExecuteReader();
                return dadosCompromissos;

            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }  

        }

        public MySqlDataReader GetCompromisso(int id, MySqlConnection conn)
        {

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_COMPROMISSO, conn);
                cmd.Parameters.Add("@id_compromisso", MySqlDbType.Int32).Value = id;
                return cmd.ExecuteReader();

            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        public void SetUpdateStatus(char comboValue, int id, MySqlConnection conn)
        {

           

            if (comboValue == 'Z')
            {
                //TODO: Fazer virar o char atual
                comboValue = 'A';
            }
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_UPDATE_COMPROMISSOS, conn);
                cmd.Parameters.Add(@"id", MySqlDbType.Int32).Value = id;
                cmd.Parameters.Add(@"status", MySqlDbType.Enum).Value = comboValue;
                cmd.ExecuteReader();
                MessageBox.Show("Compromisso alterado com sucesso!");
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }


        public void DeleteCompromisso(int id, MySqlConnection conn)
        {

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_DELETE_COMPROMISSO, conn);
                cmd.Parameters.Add("@id_compr", MySqlDbType.Int32).Value = id;
                cmd.ExecuteReader();
                MessageBox.Show("Compromisso excluído com sucesso!");
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        #region Querys

        private const String SQL_SELECT_COMPROMISSOS = @"SELECT * FROM agecontatos.compromissos;";

        private const String SQL_DELETE_COMPROMISSO = @"DELETE FROM agecontatos.contatos WHERE id = @id_compr;";

        private const String SQL_SELECT_COMPROMISSO = @"SELECT * FROM agecontatos.compromissos where id = @id_compromisso;";

        private const String SQL_UPDATE_COMPROMISSOS = @"UPDATE agecontatos.compromissos 
                set status = @status
                where id = @id; ";

        private const String SQL_INSERT_COMPROMISSO = @"INSERT INTO compromissos
            (
            titulo,
            descricao,
            dataini,
            datafim,
            status,    
            id_contato
            )
            VALUES
            (
            @titulo,
            @descricao,
            @dataini,
            @datafinal,
            @status,
            @id_contato
            )";


        #endregion



    }
}
