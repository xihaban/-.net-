using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using DZY;

namespace DZY
{
    public class wMaihuo
    {


        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader hs = null;

        public int SellGoodsAdd(getMaihuo tbChGood)
        {
            int intFalg = 0;
            try
            {
                string str_Add = "insert into SellGoods values( ";
                str_Add += "'" + tbChGood.getSellID + "','" + tbChGood.getKcID + "','" + tbChGood.getGoodsID + "',";
                str_Add += "'" + tbChGood.getEmpId + "','" + tbChGood.getGoodsName + "'," + tbChGood.getSellGoodsNum + ",";
                str_Add += "'" + tbChGood.getSellGoodsTime + "'," + tbChGood.getSellPrice + ",";
                str_Add += tbChGood.getSellFalg + ")";
                str_Add += "update  KcGoods set KcNum=KcNum-" + tbChGood.getSellGoodsNum+"where KcGoodsName='"+tbChGood.getGoodsName+"'";
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
        public int SellGoodsUpdate(getMaihuo tbChGood)
        {
            int intFalg = 0;
            try
            {
                string str_Update = "update SellGoods set ";
                str_Update += "KcID='" + tbChGood.getKcID + "',GoodsID='" + tbChGood.getGoodsID + "',";
                str_Update += "EmpId='" + tbChGood.getEmpId + "',GoodsName='" + tbChGood.getGoodsName + "',SellGoodsNum=" + tbChGood.getSellGoodsNum + ",";
                str_Update += "SellGoodsTime='" + tbChGood.getSellGoodsTime + "',SellPrice=" + tbChGood.getSellPrice + ",";
                str_Update += "SellFalg=" + tbChGood.getSellFalg + "";
                str_Update += " where  SellID= '" + tbChGood.getSellID + "'";

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
        public int SellGoodsDelete(getMaihuo tbChGood)
        {
            int intFalg = 0;
            try
            {
                string str_Del = "update SellGoods set ";

                str_Del += "SellFalg=" + tbChGood.getSellFalg + "";
                str_Del += " where  SellID= '" + tbChGood.getSellID + "'";

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
        public void SellGoodsFind(Object DataObject)
        {
            int intCount = 0;
            string strSecar = null;

            try
            {

                strSecar = "select * from SellGoods  where SellFalg=0";

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
                        dv[2, i].Value = hs[7].ToString();
                        dv[3, i].Value = hs[5].ToString();
                        dv[4, i].Value = hs[3].ToString();
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

        public SqlDataReader SellGoodsFind(string DataObject)
        {

            string strSecar = null;

            try
            {

                strSecar = "select * from SellGoods where SellID='" + DataObject + "'";

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

        public void SellGoodsFind(object DataObject, int intFalg, getMaihuo SellGoods)
        {

            string strSecar = null;
            try
            {
                switch (intFalg)
                {
                    case 1:
                        strSecar = "select * from SellGoods where GoodsName like  '%" + SellGoods.getGoodsName + "%'";
                        break;
                    case 2:
                        strSecar = "select * from SellGoods where GoodsName like '%" + SellGoods.getEmpId + "%'";
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
                        dv[0, i].Value = hs[4].ToString();
                        dv[1, i].Value = hs[7].ToString();
                        dv[2, i].Value = hs[5].ToString();
                        dv[3, i].Value = hs[3].ToString();
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
        public string getSellID()
        {
            string strName = "XS";
            Random ran = new Random();
            int j = ran.Next(0, 1000);
            string i = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + j;
            return strName + i;

        }
    }
}
