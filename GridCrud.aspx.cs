using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Crud_Web_App
{
    public partial class GridCrud : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillGridView();
                LabelInsertStatus.Text = "";
            }
        }

        protected void FillGridView()
        {
            GridView1.DataSource = UserDal.GetData();
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            string UserID = row.Cells[0].Text;
            UserDal.DeleteRow(UserID);
            FillGridView();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            FillGridView();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            FillGridView();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            TextBox UserID = GridView1.Rows[e.RowIndex].Cells[0].Controls[0] as TextBox;
            TextBox Username = GridView1.Rows[e.RowIndex].Cells[1].Controls[0] as TextBox;
            TextBox Password = GridView1.Rows[e.RowIndex].Cells[2].Controls[0] as TextBox;
            TextBox Email = GridView1.Rows[e.RowIndex].Cells[3].Controls[0] as TextBox;

            UserDal.UpdateRow(UserID.Text, Username.Text, Password.Text, Email.Text);
            GridView1.EditIndex = -1;
            FillGridView();
        }
    }
}