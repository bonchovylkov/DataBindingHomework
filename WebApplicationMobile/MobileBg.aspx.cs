using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Web.UI.HtmlControls;
namespace WebApplicationMobile
{
    public partial class MobileBg : System.Web.UI.Page
    {
        public static ICollection<Producer> producers = new HashSet<Producer>();
        public static ICollection<Extra> extras = new HashSet<Extra>();
        public static ICollection<EngineType> engineTypes = new HashSet<EngineType>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                 producers=  CreateProducers();
                 extras = CreateExtras();
                 engineTypes = CreateEngineTypes();
                this.ProducersDropDown.DataSource = producers;
                this.EngineTypes.DataSource = engineTypes;
                this.ExtrasCheckBox.DataSource = extras;
                Producer firsProducer = producers.FirstOrDefault();
                this.ModelsDropDown.DataSource = firsProducer.Models;

                this.Page.DataBind();
            }
        }
        protected void ChangeModels(object sender, EventArgs e)
        {
            DropDownList producer = sender as DropDownList;
            if (producer != null)
            {
                var name = producer.SelectedItem.Value;
                var models = producers.Where(p => p.Name == name).Select(m=>m.Models).FirstOrDefault();
                this.ModelsDropDown.DataSource = models;
                this.ModelsDropDown.DataBind();
            }
   
        }
        

        private ICollection<EngineType> CreateEngineTypes()
        {
            HashSet<EngineType> engineTypes = new HashSet<EngineType>();
            engineTypes.Add(new EngineType() { Type = "V00 " });
            engineTypes.Add(new EngineType() { Type = "Z800 " });
            engineTypes.Add(new EngineType() { Type = "P900 " });
            engineTypes.Add(new EngineType() { Type = "P901 " });
            engineTypes.Add(new EngineType() { Type = "5501Z " });
            return engineTypes;
        }

        private ICollection<Extra> CreateExtras()
        {
            HashSet<Extra> extras = new HashSet<Extra>();
            extras.Add(new Extra {ExtraName="Guiryk" });
            extras.Add(new Extra { ExtraName = "Chetiri gymi" });
            extras.Add(new Extra { ExtraName = "Dve vrati" });
            extras.Add(new Extra { ExtraName = "Farave" });
            extras.Add(new Extra { ExtraName = "Djanti" });
            return extras;
        }

        private ICollection<Producer> CreateProducers()
        {
            ICollection<Producer> producers = new HashSet<Producer>();
            producers.Add(new Producer
            {
                Id=1,
                Name="BMW",
                Models = new HashSet<Model>
                {
                    new Model{Name="Z300"},
                    new Model{Name="p500"},
                    new Model{Name="I700"},
                    new Model{Name="X720"}
                }

            });
           producers.Add( new Producer
            {
                Id=1,
                Name="Mercedes",
                Models = new HashSet<Model>
                {
                    new Model{Name="Benz"},
                    new Model{Name="120P"},
                    new Model{Name="New Merc"},
                    new Model{Name="S klassa"}
                }

            });
           producers.Add(new Producer
           {
               Id = 1,
               Name = "Volsvagen",
               Models = new HashSet<Model>
                {
                    new Model{Name="2ka"},
                    new Model{Name="3ka"},
                    new Model{Name="4ka"},
                    new Model{Name="5tica"}
                }

           });
            return producers;

        }

        public void CollectInfo(object sender, EventArgs e)
        {
          
            var selectedProducer = this.ProducersDropDown.SelectedItem.Value;
            var modelSelectedModel = this.ModelsDropDown.SelectedItem.Value;
            var checkedExtras = this.ExtrasCheckBox.Items.Cast<ListItem>().Where(z => z.Selected);
            var pickedEngine = this.EngineTypes.SelectedItem.Value;
            var p = new Literal();
            p.Text = "Producer :" + selectedProducer + "<br/>";
            p.Text += "Model :" + modelSelectedModel + "<br/>";
            p.Text += "Engine :" + pickedEngine + "<br/>";
            p.Text += "Extras <br/>";
            foreach (var extra in checkedExtras)
            {
                p.Text += extra + "<br/>";
            }

            this.form1.Controls.Add(p);
        }
    }
}