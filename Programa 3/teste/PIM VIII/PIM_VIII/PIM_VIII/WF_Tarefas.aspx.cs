using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Configuration;
using System.Data;

namespace PIM_VIII
{
    public partial class WF_Tarefas : System.Web.UI.Page
    {
        internal object showDialog;

        public int BD_PIM_VIIIConnectionString2 { get; private set; }

        internal void show()
        {
            throw new NotImplementedException();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
            
        protected void Titulo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void Cadastrar(object sender, EventArgs e)
        {
            try
            {
                string BD_PIM_VIIICon = ConfigurationManager.ConnectionStrings["BD_PIM_VIIICon"].ToString();
                OleDbConnection conexaodb = new OleDbConnection(BD_PIM_VIIICon);
                conexaodb.Open();

                string query = "INSERT INTO tarefa (TiposTarefa, Descricao, Data, Campo1) VALEUS (@nomeTarefa, @descricao, @dataEntrega, @Campo1)";
                OleDbCommand cmd = new OleDbCommand(query, conexaodb);

                var pmtnomeTarefa = cmd.CreateParameter();
                pmtnomeTarefa.ParameterName = "@nomeTarefa";
                pmtnomeTarefa.DbType = DbType.String;
                pmtnomeTarefa.Value = Tarefas.TiposTarefa;
                cmd.Parameters.Add(pmtnomeTarefa);

                var pmtDescricao = cmd.CreateParameter();
                pmtDescricao.ParameterName = "@descricao";
                pmtDescricao.DbType = DbType.String;
                pmtDescricao.Value = novaTareefa.Descricao;
                cmd.Parameters.Add(pmtDescricao);

                var pmtdataEntrega = cmd.CreateParameter();
                pmtdataEntrega.ParameterName = "@dataEntrega";
                pmtdataEntrega.DbType = DbType.String;
                pmtdataEntrega.Value = novaTareefa.Data;
                cmd.Parameters.Add(pmtdataEntrega);

                var pmtCampo1 = cmd.CreateParameter();
                pmtCampo1.ParameterName = "@dataEntrega";
                pmtCampo1.DbType = DbType.String;
                pmtCampo1.Value = novaTareefa.Data;
                cmd.Parameters.Add(pmtCampo1);


                if (cmd.ExecuteNonQuery() > 0)
                {
                    conexaodb.Close();
                    return true;
                }
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}