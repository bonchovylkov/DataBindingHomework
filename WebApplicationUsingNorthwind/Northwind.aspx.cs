using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationUsingNorthwind
{
    public partial class Northwind : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
            if (!Page.IsPostBack)
            {
                NorthwindEntities context = new NorthwindEntities();
                var emp = context.Employees;
                this.GridViewCustomers.DataSource = emp.ToList();
                this.GridViewCustomers.DataBind();
            }
        }
    }
}