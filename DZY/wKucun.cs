using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using DZY;
namespace DZY
{
    public class wKucun
    {

        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader hs = null;
        public int KcGoodsAdd(getKucun kcGood)
        {
            int intFalg = 0;
            try
            {
                string str_Add = "insert into KcGoods(KcID,KcGoodsName,KcNum,KcDeptName) values( ";
                str_Add += "'" + kcGood.getKcID + "','" + kcGood.getKcGoodsName + "',";
                str_Add += "'" + kcGood.getKcNum + "','" + kcGood.getKcDeptName + "')";
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
        public int KcGoodsDelete(getKucun KcGoods)
        {

            int intFalg = 0;
            try
            {
                string str_Del = "delete from KcGoods  where KcID='" + KcGoods.getKcID + "'";
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
        public int KcGoodsUpdate(getKucun kcGood)
        {
            int intFalg = 0;
            try
            {
                string str_Update = "update KcGoods set ";
                str_Update += "KcID='" + kcGood.getKcID + "',KcGoodsName='" + kcGood.getKcGoodsName + "',";
                str_Update += "KcNum='" + kcGood.getKcNum + "',KcDeptName='" + kcGood.getKcDeptName + "' where KcID='" + kcGood.getKcID + "'";
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
        public int KcGoodsUpdate(string kcGood, int striID)
        {
            int intFalg = 0;
            try
            {
                string str_Update = "update KcGoods set  ";
                str_Update += "KcAlarmNum=" + striID + " ";
                str_Update += " where GoodsID ='" + kcGood + "'";
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
        public void KcGoodsFind(object DataObject, int intFalg, getKucun kcGood)
        {
            string strSecar = null;

            try
            {
                switch (intFalg)
                {
                    case 1:
                        strSecar = "select * from KcGoods where KcID  like '%" + kcGood.getGoodsID + "%'";
                        break;
                    case 2:
                        strSecar = "select * from KcGoods  where KcGoodsName like '%" + kcGood.getKcGoodsName + "%'";
                        break;

                    case 4:
                        strSecar = "select * from KcGoods ";
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
                        dv[1, i].Value = hs[1].ToString();
                        dv[2, i].Value = hs[2].ToString();
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
        public void KcGoodsFind(object DataObject)
        {
            int intCount = 0;
            string strSecar = null;
            try
            {
                strSecar = "select * from KcGoods";
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
                        dv[1, i].Value = hs[1].ToString();
                        dv[2, i].Value = hs[2].ToString();
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
        public SqlDataReader KcGoodsFind(string DataObject)
        {

            string strSecar = null;

            try
            {

                strSecar = "select * from KcGoods  where KcID ='" + DataObject + "'";


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
        public string getKcID()
        {
            string strName = "KC";
            Random ran = new Random();
            int j = ran.Next(0, 1000);
            string i = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + j;
            return strName + i;

        }
    }

}

