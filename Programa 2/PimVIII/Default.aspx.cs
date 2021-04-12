using System;
using System.Web.UI;
using CamadaControle;           //Importar Camadas
using CamadaModelo;             //Importar Camadas

namespace PimVIII
{
    public partial class _Default : Page
    {

        void Page_Load(object sender, EventArgs e)
        {

        }    

        protected void Cadastrar_Click(object sender, EventArgs e)
        {
            CtlTareefa _ctlTareefa = new CtlTareefa();
            MdlTarefa _mdlTareefa = new MdlTarefa();

            _mdlTareefa.NomeTarefa = txtnome.Text;
            _mdlTareefa.Descricao = txtDescricao.Text;
            _mdlTareefa.DataEntrega = txtdataEntrega.Text;
           // _mdlTareefa.Status = TxbStatus.Text;


            bool retornoInsert = _ctlTareefa.Cadastrar(_mdlTareefa);

            if (retornoInsert == true)
            {
                ScriptManager.RegisterStartupScript(this,
                                                    this.GetType(),
                                                    "Secesso",
                                                    "alert('Tarefa salva com Sucesso !');",
                                                    true);
                
            }
            else
            {
                ScriptManager.RegisterStartupScript(this,
                                                    this.GetType(),
                                                    "Secesso",
                                                    "alert('Erro oa salvar !');",
                                                    true);
            }
            
        }

        private void Page_Load()
        {
            throw new NotImplementedException();
        }

        protected void Status_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}