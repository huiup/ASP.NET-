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

public partial class speak : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonSpeak_Click(object sender, EventArgs e)
    {
        String userName = Session["user_name"].ToString();
        String createTime = System.DateTime.Now.ToLongTimeString();
        String content = TextBoxContent.Text;
        String color = DropDownListColor.SelectedItem.Value;
        String emotion = DropDownListEmotion.SelectedItem.Value;
        Message message = new Message();
        message.Add(userName, createTime, content, color, emotion);
        TextBoxContent.Text = "";
    }
    protected void ButtonExit_Click(object sender, EventArgs e)
    {
        Session["user_name"] = null;
        Response.Write("<Script Language=JavaScript>window.top.location=\"login.aspx\";</Script>");
    }
    
}