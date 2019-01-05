using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DZY
{
   public class getSqlConnection
    {
       string G_Str_ConnectionString = "Data Source=CAPTAIN;Initial Catalog=xsgl;Integrated Security=True";
        SqlConnection Con;  //声明链接对象


        /// <summary>
        /// 构造函数
        /// </summary>
       public getSqlConnection()
        {

        }

        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetCon()
        {
            Con = new SqlConnection(G_Str_ConnectionString);
            Con.Open();
            return Con;
        }
    }
}
