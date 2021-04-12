using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;

namespace CamadaModelo
{
    public class MdlTarefa
    {
        public int IdTarefa { get; set; }
       
        public string NomeTarefa { get; set; }
        
        public string Descricao { get; set; }
        public string DataEntrega { get; set; }
        public string Status { get; set; }
    }
}
