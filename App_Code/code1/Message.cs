﻿using System;
using System.Data;

using code2;

namespace code1
{
    /// <summary>
    /// Message 的摘要说明。
    /// </summary>
    public class Message
    {

        /// <summary>
        /// 获取事件最近的10条发言
        /// </summary>
        public static DataSet LoadTop10()
        {
            Database db = new Database();		//实例化一个Database类

            string sql = "Select top 10 * from [message] order by CreateTime desc";
            DataSet ds = db.GetDataSet(sql);//利用Database类的GetDataSet方法查询最近的10条发言

            return ds;
        }

        /// <summary>
        /// 向数据库中添加一条留言信息
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="createTime">留言时间</param>
        /// <param name="content">留言内容</param>
        /// <param name="color">颜色</param>
        /// <param name="emotion">表情</param>
        public void Add(string userName, string createTime, string content, string color, string emotion)
        {
            Database db = new Database();		//实例化一个Database类

            string sql = "Insert Into [message] Values( "
                + "'" + userName + "',"
                + "'" + createTime + "',"
                + "'" + content + "',"
                + "'" + color + "',"
                + "'" + emotion + "')";

            db.ExecuteSQL(sql);	//利用Database类的GetDataRow方法查询用户数据
        }
    }
}
