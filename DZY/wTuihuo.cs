using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DZY;
using System.Windows.Forms;
namespace DZY
{
    class wTuihuo
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader hs = null;
        #region 添加
        public int ThGoodsAdd(getTuihuo tbChGood)
        {
            int intFalg = 0;
            try
            {
                string str_Add = "insert into tb_ThGoodsInfo values( ";
               str_Add+="'"+tbChGood.strThGoodsID+"','"+tbChGood.strKcID+"','"+tbChGood.strGoodsID+"',";
                str_Add+="'"+tbChGood.strSellID+"','"+tbChGood.intEmpId+"','"+tbChGood.strThGoodsName+"',";
                str_Add+=""+tbChGood.intThGoodsNum+",'"+tbChGood.daThGoodsTime+"',"+tbChGood.deThGoodsPrice+",";
                str_Add+=""+tbChGood.deThHasPay+","+tbChGood.deThNeedPay+",'"+tbChGood.deThGoodsResult+"')";
                getSqlConnection getConnection = new getSqlConnection();
                conn = getConnection.GetCon();
                cmd = new SqlCommand(str_Add, conn);
                intFalg = cmd.ExecuteNonQuery();
                conn.Dispose();
                return intFalg;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                return intFalg;
            }
        }
        #endregion
        #region 修改
        public int ThGoodsUpdate(getTuihuo tbChGood)
        {
            int intFalg = 0;
            try
            {
                string str_Update = "update tb_ThGoodsInfo set ";
                str_Update += "KcID='" + tbChGood.strKcID + "',GoodsID='" + tbChGood.strGoodsID + "',";
                str_Update += "SellID='" + tbChGood.strSellID + "',EmpId='" + tbChGood.intEmpId + "',ThGoodsName='" + tbChGood.strThGoodsName + "',";
                str_Update += "ThGoodsNum=" + tbChGood.intThGoodsNum + ",ThGoodsTime='" + tbChGood.daThGoodsTime + "',ThGoodsPrice=" + tbChGood.deThGoodsPrice + ",";
                str_Update += "ThHasPay=" + tbChGood.deThHasPay + ",ThNeedPay=" + tbChGood.deThNeedPay + ",ThGoodsResult='" + tbChGood.deThGoodsResult + "' where  ThGoodsID='" + tbChGood.strThGoodsID + "'";
                
               
                getSqlConnection getConnection = new getSqlConnection();
                conn = getConnection.GetCon();
                cmd = new SqlCommand(str_Update, conn);
                intFalg = cmd.ExecuteNonQuery();
                conn.Dispose();
                return intFalg;



            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                return intFalg;

            }

        }
                #endregion     
    #region 生成商品编号
       public string ThGoodsID()
       {
            string strName = "TH";
            Random ran = new Random();
            int j = ran.Next(0, 1000);
            string i = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + j;
            return strName + i;



       }// end if 
        #endregion
        #region 删除
        public int ThGoodsDelete(string striThid)
        {
            int intFalg = 0;
            try
            {
                string str_Del = "delete from tb_thgoodsinfo  where ThGoodsID='" + striThid + "'";
                getSqlConnection getConnection = new getSqlConnection();
                conn = getConnection.GetCon();
                cmd = new SqlCommand(str_Del, conn);
                intFalg = cmd.ExecuteNonQuery();
                conn.Dispose();
                return intFalg;



            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                return intFalg;

            }

        }
        #endregion
        #region 查询
        public void ThGoodsFind(Object DataObject)
{
    int intCount = 0;
    string strSecar = null;
    try
    {
        strSecar = "select * from tb_ThGoodsInfo ";
        getSqlConnection getConnection = new getSqlConnection();
        conn = getConnection.GetCon();
        cmd = new SqlCommand(strSecar, conn);
        int ii = 0;
        hs = cmd.ExecuteReader();
        while (hs.Read())
        {
            ii++;
        }
        hs.Close();
        System.Windows.Forms.DataGridView dv = (DataGridView)DataObject;
        if (ii != 0)
        {
            int i = 0;
            dv.RowCount = ii;
            hs = cmd.ExecuteReader();
            while (hs.Read())
            {
                dv[0, i].Value = hs[0].ToString();
                dv[1, i].Value = hs[3].ToString();
                dv[2, i].Value = hs[5].ToString();
                dv[3, i].Value = hs[8].ToString();
                dv[4, i].Value = hs[6].ToString();
                i++;
            }
            hs.Close();
        }
        else
        {
            if (dv.RowCount != 0)
            {
                int i = 0;
                do
                {
                    dv[0, i].Value = "";
                    dv[1, i].Value = "";
                    dv[2, i].Value = "";
                    dv[3, i].Value = "";
                    i++;
                } while (i < dv.RowCount);
            }
        }
    }
    catch (Exception ee)
    {
        MessageBox.Show(ee.ToString());
    }
}
               #endregion

       #region 查询
       public SqlDataReader JhGoodsInfoFind(string strObject)
       {
           int intCount = 0;
           string strSecar = null;

           try
           {

               strSecar = "select * from tb_thgoodsinfo  where thGoodsid= '" + strObject + "'";
            
  
               getSqlConnection getConnection = new getSqlConnection();
               conn = getConnection.GetCon();
               cmd = new SqlCommand(strSecar, conn);
               hs = cmd.ExecuteReader();
               return hs;

           }
           catch (Exception ee)
           {
               MessageBox.Show(ee.ToString());
               return hs;

           }

       }
       #endregion
       #region 填冲商品类别信息 
       public void filltProd(object objTreeView, object obimage)
       {
           try
           {
               getSqlConnection getConnection = new getSqlConnection();
               conn = getConnection.GetCon();
               string strSecar = "select * from tb_SellGoods ";
               cmd = new SqlCommand(strSecar, conn);
               hs = cmd.ExecuteReader();

               if (objTreeView.GetType().ToString() == "System.Windows.Forms.TreeView")
               {
                   System.Windows.Forms.ImageList imlist = (System.Windows.Forms.ImageList)obimage;

                   System.Windows.Forms.TreeView TV = (System.Windows.Forms.TreeView)objTreeView;
                   TV.Nodes.Clear();

                   TV.ImageList = imlist;
                   System.Windows.Forms.TreeNode TN = TV.Nodes.Add("A", "商品销售信息", 0, 1);

                   while (hs.Read())
                   {
                       TreeNode newNode12 = new TreeNode(hs[0].ToString(), 0, 1);
                       newNode12.Nodes.Add("A", hs[4].ToString(), 0, 1);
                       TN.Nodes.Add(newNode12);
                   }
                   hs.Close();
                   TV.ExpandAll();
               }
           }
           catch (Exception ee)
           {
               MessageBox.Show(ee.ToString());
           }

       }
           #endregion 
       #region 生成客户编号
       public string EmpInfoID()
       {
            string strName = "KH";
            Random ran = new Random();
            int j = ran.Next(0, 1000);
            string i = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + j;
            return strName + i;

        }// end if 
       #endregion
       

    }
}
