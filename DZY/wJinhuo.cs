using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DZY;
using System.Windows.Forms;
namespace DZY
{
    public class wJinhuo
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader hs = null;
        static int i = 0;
        public int JhGoodsAdd(getJinhuo tbGood)
        {
            int intFalg = 0;
            try
            {
                string str_Add = "insert into test values( ";
                str_Add += "'" + tbGood.getGoodsID + "','" + tbGood.getEmpId + "','" + tbGood.getJhCompName + "',";
                str_Add += "'" + tbGood.getDepotName + "','" + tbGood.getGoodsName + "','" + tbGood.getGoodsNum + "',";
                str_Add += "'" + tbGood.getGoodsJhPrice + "',";
                str_Add += "'" + tbGood.getGoodTime + "','" + tbGood.getFalg + "')";

                str_Add += "insert into KcGoods(KcID,KcGoodsName,KcNum,KcDeptName) values( ";
                str_Add += "'" + tbGood.getGoodsID + "','" + tbGood.getGoodsName + "',";
                str_Add += tbGood.getGoodsNum + ",'" + tbGood.getDepotName + "')";
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
        public int JhGoodsUpdate(getJinhuo tbGood)
        {
            int intFalg = 0;
            try
            {
                string str_Update = "update test set ";
                str_Update += "EmpId='" + tbGood.getEmpId + "',JhCompName='" + tbGood.getJhCompName + "',";
                str_Update += "DepotName='" + tbGood.getDepotName + "',GoodsName='" + tbGood.getGoodsName + "',GoodsNum='" + tbGood.getGoodsNum + "',";
                str_Update += "GoodsJhPrice=" + tbGood.getGoodsJhPrice + ",";
                str_Update += "GoodTime='" + tbGood.getGoodTime + "',Falg='" + tbGood.getFalg + "' where GoodsID ='" + tbGood.getGoodsID + "'";
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
        public int JhGoodsDelete(getJinhuo tbGood)
        {
            int intFalg = 0;
            try
            {
                string str_Del = "delete from test where GoodsID ='" + tbGood.getGoodsID + "'";
                str_Del += "delete from KcGoods where KcGoodsName = '"+tbGood.getGoodsName+"'";
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
        public void JhGoodsFind(string strObject, int intFalg, Object DataObject)
        {
            int intCount = 0;
            string strSecar = null;

            try
            {
                switch (intFalg)
                {
                    case 1:
                        strSecar = "select * from test where GoodsID like  '%" + strObject + "%' ";
                        break;
                    case 2:
                        strSecar = "select  * from  test  where GoodsName like '%" + strObject + "%'";
                        break;
                    case 5:
                        strSecar = "select * from test";
                        break;
                }
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
                        dv[1, i].Value = hs[4].ToString();
                        dv[2, i].Value = hs[2].ToString();
                        dv[3, i].Value = hs[3].ToString();
                        dv[4, i].Value = hs[5].ToString();
                        dv[5, i].Value = hs[6].ToString();
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
                            dv[4, i].Value = "";
                            dv[5, i].Value = "";
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
        public SqlDataReader JhGoodsFind(string strObject, int intFalg)
        {
            int intCount = 0;
            string strSecar = null;

            try
            {
                switch (intFalg)
                {
                    case 1:
                        strSecar = "select * from test where GoodsID = '" + strObject + "'";
                        break;
                    case 2:
                        strSecar = "select  * from  test";
                        break;
                }
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
        public string JhGoodsID()
        {
            string strName = "JH";
            Random ran = new Random();
            int j = ran.Next(0, 1000);
            string i = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + j;
            return strName + i;
        }
    }
}
