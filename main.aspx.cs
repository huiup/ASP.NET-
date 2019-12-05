using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Web.SessionState;
using System.Data.SqlClient;    //为了连接SQL Server数据库
using System.Configuration;

public partial class main : System.Web.UI.Page
{
    public int num;
    string connectionString =  ConfigurationManager.ConnectionStrings["SQLConnectionString1"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        FillData();
        DisplayDate();
        if (Session["user_name"] == null)
        {
            Label1.Text = "暂无用户登录";
        }
        else {
            Label1.Text = Session["user_name"].ToString();
        }

        
    }
    
    private void DisplayDate()
    {

        string sql = "select count(0) from [user]";
        //string connectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString1"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();
        SqlCommand cmd = new SqlCommand(sql, conn);
        object obj = cmd.ExecuteScalar();
        conn.Close();
        num = (int)obj;

        
    }
    private void FillData() {

        SqlConnection conn = new SqlConnection(connectionString);
        string cmdText = "SELECT userName FROM [user]";
        SqlCommand command = new SqlCommand(cmdText, conn);
        conn.Open();
        SqlDataReader dr = command.ExecuteReader();
        while (dr.Read())
        {
            DropDownList1.Items.Add(new ListItem(dr["userName"].ToString()));
        }
        dr.Close();
        conn.Close();
        
    }
}