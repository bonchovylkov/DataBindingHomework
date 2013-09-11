using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationUsingNorthwind
{
    public partial class DetailsEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var id = Request.Params["id"];
            if (id!=null)
            {
                var empId = int.Parse(id);
                NorthwindEntities context = new NorthwindEntities();
                var emplpoyeee = context.Employees.FirstOrDefault(em => em.EmployeeID == empId);
                if (emplpoyeee!=null)
                {
                    List<Employee> emps = new List<Employee>();
                    emps.Add(emplpoyeee);
                    this.DetailsViewEmployee.DataSource = emps;
                    
                    this.DetailsViewEmployee.DataBind();
                }
                else
                {
                    throw new ArgumentException("The employee misses");
                }
            }
        }
    }
}