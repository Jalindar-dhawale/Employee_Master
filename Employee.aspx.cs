using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;

namespace Employee_Master
{
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = SqlDataSource1;
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = SqlDataSource1;
            GridView1.DataBind();
            Label8.Text = "";
            GridView1.EditRowStyle.BackColor = System.Drawing.Color.Orange;
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = SqlDataSource1;
            GridView1.DataBind();
            Label8.Text = "";
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label EMP_ID = GridView1.Rows[e.RowIndex].FindControl("Label7") as Label;
            TextBox FULLNAME = GridView1.Rows[e.RowIndex].FindControl("TextBox1") as TextBox;
            TextBox EMAIL = GridView1.Rows[e.RowIndex].FindControl("TextBox2") as TextBox;
            TextBox PHONE = GridView1.Rows[e.RowIndex].FindControl("TextBox3") as TextBox;
            string mycon = "Data Source=JALINDARDHAWALE\\SQLEXPRESS; Initial Catalog=Employeedb; Integrated Security=True";
            string updatedata = "Update Employeedb set FULLNAME='" + FULLNAME.Text + "',EMAIL='" + EMAIL.Text + "',PHONE='" + PHONE + "'where EMP_ID='" + EMP_ID.Text + "'";
            SqlConnection con = new SqlConnection(mycon);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = updatedata;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            Label8.Text = "Row data has been successfully updated";
            GridView1.EditIndex = -1;
            SqlDataSource1.DataBind();
            GridView1.DataSource = SqlDataSource1;
            GridView1.DataBind();




        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            TextBox EMP_ID = GridView1.FooterRow.FindControl("TextBox4") as TextBox;
            TextBox FULLNAME = GridView1.FooterRow.FindControl("TextBox5") as TextBox;
            TextBox EMAIL = GridView1.FooterRow.FindControl("TextBox6") as TextBox;
            TextBox PHONE = GridView1.FooterRow.FindControl("TextBox7") as TextBox;

            string query="insert into Employeedb(EMP_ID,FULLNAME,EMAIL,PHONE) values("+EMP_ID.Text+"','"+FULLNAME+"','"+EMAIL+"','"+PHONE+"')";
            string mycon = "Data Source=JALINDARDHAWALE\\SQLEXPRESS; Initial Catalog=Employeedb; Integrated Security=True";
            SqlConnection con = new SqlConnection(mycon);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            Label8.Text = "Row data has been successfully Inserted";
            GridView1.EditIndex = -1;
            SqlDataSource1.DataBind();
            GridView1.DataSource = SqlDataSource1;
            GridView1.DataBind();

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label EMP_ID = GridView1.Rows[e.RowIndex].FindControl("Label3") as Label;
            string mycon = "Data Source=JALINDARDHAWALE\\SQLEXPRESS; Initial Catalog=Employeedb; Integrated Security=True";
            string updatedata = "delete from Employeedb where EMP_ID=" + EMP_ID.Text;
            SqlConnection con = new SqlConnection(mycon);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = updatedata;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            Label8.Text = "Row data has been successfully ";
            GridView1.EditIndex = -1;
            SqlDataSource1.DataBind();
            GridView1.DataSource = SqlDataSource1;
            GridView1.DataBind();
        }
    }
}