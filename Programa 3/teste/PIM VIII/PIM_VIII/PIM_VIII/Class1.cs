using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;

namespace PIM_VIII
{
    public class Tarefas
    {
        public int Codigo { get; set; }
        public string TiposTarefa { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public string Campo1 { get; set; }
    }
}