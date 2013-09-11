using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data;
namespace WebApplicationRepeater
{
    public partial class Repeater : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           var context = new NorthwindEntities();
           RepeaterEmployees.DataSource = context.Employees.ToList();
           RepeaterEmployees.DataBind();
        }
    }
}