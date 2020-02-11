using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MXM.TreinamentoWebForm2.Web.Treinamento
{
    public partial class Aluno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<String> strs = new List<string>();

            strs.Add("Matemática");
            strs.Add("História");
            strs.Add("Geografia");


            grpMateriaStore.DataSource = strs
                .Select(x => new { Disciplina = x });
            grpMateriaStore.DataBind();
        }
    }
}