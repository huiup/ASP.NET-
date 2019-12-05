using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;    //为了连接SQL Server数据库
using System.Configuration;

public partial class regist : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void regist_Click(object sender, EventArgs e)
    {
        string name = username.Text;	//用户名
        string psw = password.Text;	//密码
        string connectionString =  ConfigurationManager.ConnectionStrings["SQLConnectionString1"].ConnectionString;
            //创建数据库连接对象
        SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();
        string sql= "insert into [user] values('"+name+"','"+psw+"')";
        SqlCommand cmd = new SqlCommand(sql,conn);
        
             
        int num = cmd.ExecuteNonQuery();
        conn.Close();
        if (num == 1)
        {
            Response.Write("<script>alert('注册成功！')</script>");
        }
        else {
            Response.Write("<script>alert('注册失败！')</script>");
        }
        
    }
    protected void login_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }
}