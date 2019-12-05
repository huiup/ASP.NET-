using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;    //为了连接SQL Server数据库
using System.Configuration;
using System.Data;

public partial class regist : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    
    protected void regist_Click(object sender, EventArgs e)
    {
        Response.Redirect("regist.aspx");
    }
    protected void login_Click(object sender, EventArgs e)
    {
        string name = username.Text;	//用户名
        string psw = password.Text;	//密码

        Session.Add("user_name", name);//用session保存用户名称

        string sql = "select count(0) from [user] where userName=@a and pwd=@b";
        SqlParameter p1 = new SqlParameter("@a", name);
        SqlParameter p2 = new SqlParameter("@b", psw);
        string connectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString1"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();
        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.Parameters.Add(p1);
        cmd.Parameters.Add(p2);
        object obj = cmd.ExecuteScalar();
        conn.Close();
        int num = (int)obj;
        

        if (num > 0)
        {
            Response.Write("<script>confirm('登录成功！')</script>");
            Response.Redirect("main.aspx");
        }
        else
        {
            Response.Write("<script>alert('登录失败！')</script>");
        }
    }
}