using System;
using System.Data;
using System.Data.OleDb;
using CamadaModelo;
using System.Configuration;

namespace CamadaControle
{
    public class CtlTareefa

    {
        public bool Cadastrar(MdlTarefa _mdlTarefa)
        {
            try
            {
                string conexaoAccess = ConfigurationManager.ConnectionStrings["conexaoAccess"].ToString();               
                OleDbConnection conexaodb = new OleDbConnection(conexaoAccess);
                conexaodb.Open();

                string query = "INSERT INTO tarefa (nomeTarefa, Descricao, dataEntrega) VALUES (@nomeTarefa, @Descricao, @dataEntrega)";
                OleDbCommand cmd = new OleDbCommand(query, conexaodb);

                var pmtnomeTarefa = cmd.CreateParameter();
                pmtnomeTarefa.ParameterName = "@nomeTarefa";
                pmtnomeTarefa.DbType = DbType.String;
                pmtnomeTarefa.Value = _mdlTarefa.NomeTarefa;
                cmd.Parameters.Add(pmtnomeTarefa);

                var pmtDescricao = cmd.CreateParameter();
                pmtDescricao.ParameterName = "@Descricao";
                pmtDescricao.DbType = DbType.String;
                pmtDescricao.Value = _mdlTarefa.Descricao;
                cmd.Parameters.Add(pmtDescricao);

                var pmtdataEntrega = cmd.CreateParameter();
                pmtdataEntrega.ParameterName = "@dataEntrega";
                pmtdataEntrega.DbType = DbType.String;
                pmtdataEntrega.Value = _mdlTarefa.DataEntrega;
                cmd.Parameters.Add(pmtdataEntrega);

                var pmtStatus = cmd.CreateParameter();
                pmtStatus.ParameterName = "@Status";
                pmtStatus.DbType = DbType.String;
                pmtStatus.Value = _mdlTarefa.Status;
                cmd.Parameters.Add(pmtStatus);


                if (cmd.ExecuteNonQuery() > 0)
                {
                    conexaodb.Close();
                     return true;
                }


                else
                {
                    conexaodb.Close();
                    return false;
                }


        }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
