using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using code1;

public partial class show : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        InitData();
    }
    private void InitData() {
        DataSet ds = Message.LoadTop10();
        //逐条显示
        if (ds != null)
        {
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Response.Write("<font color=" + dr["Color"].ToString() + ">");	//颜色
                Response.Write(dr["CreateTime"].ToString());				//发言时间
                Response.Write("【" + dr["UserName"].ToString() + "】");			//发言用户
                Response.Write(dr["Emotion"].ToString());					//表情
                Response.Write("说道：");
                Response.Write(dr["Content"].ToString());					//发言内容
                Response.Write("</font><br>");
            }
        }
    }
}