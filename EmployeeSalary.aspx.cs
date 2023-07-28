using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employee_Master
{
    public partial class EmployeeSalary : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=JALINDARDHAWALE\\SQLEXPRESS; Initial Catalog=Employeedb; Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack==false)
            {
                Load_Data();
            }
        }
        void Load_Data()
        {
            string str = "select * from EMP_SALARY_DTLS";
            SqlDataAdapter adp = new SqlDataAdapter(str, con);
            DataTable dt= new DataTable();
            adp.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName.Equals("ADD"))
            {
                TextBox TextBox1=(TextBox)GridView1.FooterRow.FindControl("txtaddempid");
                TextBox TextBox2 = (TextBox)GridView1.FooterRow.FindControl("txtaddbasic");
                TextBox TextBox3 = (TextBox)GridView1.FooterRow.FindControl("txtaddda");
                TextBox TextBox4 = (TextBox)GridView1.FooterRow.FindControl("txtaddhra");
                TextBox TextBox5 = (TextBox)GridView1.FooterRow.FindControl("txtadddeduction");
                TextBox TextBox6 = (TextBox)GridView1.FooterRow.FindControl("txtaddtotal");
                con.Open();
                string cmstr="insert into Employeedb(EMP_ID,BASIC,DA,HRA,DEDUCTION,TOTAL) values('"+TextBox1.Text+"','"+TextBox2.Text+"','"+TextBox3.Text+"','"+TextBox4.Text+"','"+TextBox5.Text+"','"+TextBox6.Text+"')";
                SqlCommand cmd=new SqlCommand(cmstr,con);
                cmd.ExecuteNonQuery();
                con.Close();
                Load_Data();
            }

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label Label1 = (Label)GridView1.Rows[e.RowIndex].FindControl("Label1");
            con.Open();
            string cmdstr = "delete from Employee where EMP_ID='" + Label1.Text + "'";
            SqlCommand cmd = new SqlCommand(cmdstr,con);
            cmd.ExecuteNonQuery();
            con.Close();

            Load_Data();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex= e.NewEditIndex;
            Load_Data();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            Load_Data();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label Label1 = (Label)GridView1.Rows[e.RowIndex].FindControl("Label2");
            TextBox textBox2 = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txteditbasic");
            TextBox textBox3 = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txteditda");

            TextBox textBox4 = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtedithra");

            TextBox textBox5 = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txteditdeduction");

            TextBox textBox6 = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtedittotal");
            con.Open();
            string cmdstr = "update Employeedb set BASIC='" + textBox2.Text + "',DA='" + textBox3.Text + "',HRA='" + textBox4.Text + "',DEDUCTION='" + textBox5.Text + "',TOTAL='" + textBox6.Text + "'";
            SqlCommand cmd= new SqlCommand(cmdstr, con);
            con.Close();

            GridView1.EditIndex=-1;
            Load_Data();


        }
    }
}