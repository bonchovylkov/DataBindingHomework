using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationEmployeesUseingFormView
{
    public partial class EmployeesView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                NorthwindEntities context = new NorthwindEntities();
                var emp = context.Employees.ToList();
                this.EmployeesFromViewId.DataSource = emp;
                this.EmployeesFromViewId.DataBind();
            }
        }

        protected void EmployeesFromViewId_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {

            this.EmployeesFromViewId.PageIndex = e.NewPageIndex;
            NorthwindEntities context = new NorthwindEntities();
            var emp = context.Employees.ToList();
            this.EmployeesFromViewId.DataSource = emp;
            this.EmployeesFromViewId.DataBind();
        }

        protected void LinkButtonEdit_Click(object sender, EventArgs e)
        {
            this.EmployeesFromViewId.ChangeMode(FormViewMode.Edit);
            this.MultiViewButtons.SetActiveView(this.ViewEditMode);
            
        }

        protected void LinkButtonSave_Click(object sender, EventArgs e)
        {
            this.EmployeesFromViewId.ChangeMode(FormViewMode.ReadOnly);
            this.MultiViewButtons.SetActiveView(this.ViewNormalMode);
            int employeeIndex = this.EmployeesFromViewId.PageIndex;
            NorthwindEntities context = new NorthwindEntities();
            var emp = context.Employees.FirstOrDefault(em=>em.EmployeeID==employeeIndex);
            TextBox textBoxCity = (TextBox)
                this.EmployeesFromViewId.FindControl("TextBoxCity");
            emp.City = textBoxCity.Text;
            TextBox textBoxCountry = (TextBox)
                this.EmployeesFromViewId.FindControl("TextBoxCountry");
            emp.Country = textBoxCountry.Text;
            context.SaveChanges();
        }

        protected void LinkButtonCancel_Click(object sender, EventArgs e)
        {
            this.EmployeesFromViewId.ChangeMode(FormViewMode.ReadOnly);
            this.MultiViewButtons.SetActiveView(this.ViewNormalMode);
        }




    }
}