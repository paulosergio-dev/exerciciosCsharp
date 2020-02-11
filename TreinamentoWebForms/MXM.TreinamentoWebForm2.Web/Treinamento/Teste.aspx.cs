using Ext.Net;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MXM.TreinamentoWebForm2.Web.Treinamento
{
    public partial class Teste : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Customer> list = new List<Customer>(5);

                for (int i = 1; i <= 5; i++)
                {
                    Customer customer = new Customer
                    {
                        ID = i,
                        FirstName = ("FirstName" + i),
                        LastName = ("LastName" + i),
                        Company = ("Company" + i)
                    };

                    Address address = new Address
                    {
                        StreetAddress = ("Street" + i),
                        City = ("City" + i)
                    };

                    customer.Address = address;

                    list.Add(customer);
                }


                this.grpClienteStore.DataSource = list;
                this.grpClienteStore.DataBind();
            }

            btnGravar.DirectEvents.Click.Event += Click_Event;
            btnGravar.DirectEvents.Click.ExtraParams.Add(new Parameter("nomeParametro",
                "grpClienteStore.getRecordsValues({selectOnly:true})",
                ParameterMode.Raw,
                true));
        }

        private void Click_Event(object sender, DirectEventArgs e)
        {
            String nome = txfNome.Text;

            String clientes = e.ExtraParams["nomeParametro"];
            IList<Customer> pessoas
                = JSON.Deserialize<IList<Customer>>(clientes);

            X.MessageBox.Show(new MessageBoxConfig
            {
                Icon = MessageBox.Icon.INFO,
                Buttons = MessageBox.Button.OK,
                Title = "Conteudo grid",
                Message = String.Join(";", pessoas
                .Select(x => x.ToString()))
            });
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public Address Address { get; set; }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }

    public class Address
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
    }
}