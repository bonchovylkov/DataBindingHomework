using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data;
namespace WebApplicationListView
{
    public partial class ListView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NorthwindEntities context = new NorthwindEntities();
            this.EmployeeListView.DataSource = context.Employees.ToList();
            this.EmployeeListView.DataBind();
        }
    }
}