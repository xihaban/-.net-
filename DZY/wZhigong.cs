using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using DZY;

namespace DZY
{
    public class wZhigong
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader hs = null;

        public int EmpInfoAdd(getZhigong Empinfo)
        {

            int intFalg = 0;
            try
            {
                string str_Add = "insert into EmpIoy values( ";
                str_Add += " '" + Empinfo.getEmpId + "','" + Empinfo.getEmpName + "','" + Empinfo.getEmpLoginName + "',";
                str_Add += " '" + Empinfo.getEmpLoginPwd + "','" + Empinfo.getEmpSex + "','" + Empinfo.getEmpBirthday + "',";
                str_Add += " '" + Empinfo.getEmpPhone + "',";
                str_Add += Empinfo.getEmpFalg + ")";
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
        public int EmpInfoUpdate(getZhigong Empinfo)
        {
            int intFalg = 0;
            try
            {
                string str_Update = "update EmpIoy set ";
                str_Update += "EmpName='" + Empinfo.getEmpName + "',EmpLoginName='" + Empinfo.getEmpLoginName + "',";
                str_Update += "EmpLoginPwd='" + Empinfo.getEmpLoginPwd + "',EmpSex='" + Empinfo.getEmpSex + "',EmpBirthday='" + Empinfo.getEmpBirthday + "',";
                str_Update += "EmpPhone='" + Empinfo.getEmpPhone + "',";
                str_Update += "EmpFalg=" + Empinfo.getEmpFalg + " where  EmpId='" + Empinfo.getEmpId + "'";
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

        public int EmpInfoDelete(getZhigong Empinfo)
        {
            int intFalg = 0;
            try
            {

                string str_Del = "update EmpIoy set ";
                str_Del += "EmpFalg='" + Empinfo.getEmpFalg + "' where  EmpId='" + Empinfo.getEmpId + "'";
                getSqlConnection getConnection = new getSqlConnection();
                conn = getConnection.GetCon();
                cmd = new SqlCommand(str_Del, conn);
                intFalg = cmd.ExecuteNonQuery();
                conn.Dispose();
                return intFalg;


            }
            catch (Exception ee)
            {
                return intFalg;

            }

        }
        public void EmpInfoFind(string strObject, int intFalg, Object DataObject)
        {
            int intCount = 0;
            string strSecar = null;
            try
            {
                switch (intFalg)
                {
                    case 1:
                        strSecar = "select * from EmpIoy where EmpName like  '%" + strObject + "%' and EmpFalg=0";
                        break;
                    case 2:

                        strSecar = "select  * from  EmpIoy  where  EmpSex  = '" + strObject + "' and EmpFalg=0";
                        break;
                    case 3:
                        strSecar = "select * from EmpIoy where EmpDept like '%" + strObject + "%' and EmpFalg=0";
                        break;
                    case 4:
                        strSecar = "select * from EmpIoy where EmpPost like '%" + strObject + "%' and EmpFalg=0";
                        break;
                    case 5:
                        strSecar = "select * from EmpIoy where EmpFalg=0";
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
                        dv[2, i].Value = hs[4].ToString();
                        dv[3, i].Value = hs[6].ToString();
                        dv[4, i].Value = hs[5].ToString();
                        i++;
                    }
                    hs.Close();
                }
                else
                {
                    for (int i = 0; i < dv.RowCount; i++)
                    {
                        dv[0, i].Value = "";
                        dv[1, i].Value = "";
                        dv[2, i].Value = "";
                        dv[3, i].Value = "";
                        dv[4, i].Value = "";
                    }
                }
            }
            catch (Exception ee)
            {
            }
        }
        public SqlDataReader EmpInfoFind(string strObject, int intFalg)
        {
            int intCount = 0;
            string strSecar = null;

            try
            {
                switch (intFalg)
                {
                    case 1:
                        strSecar = "select * from EmpIoy where EmpId= '" + strObject + "' and EmpFalg=0";
                        break;
                    case 2:
                        strSecar = "select * from EmpIoy where EmpFalg=0";
                        break;
                }
                strSecar = "select * from EmpIoy where EmpId= '" + strObject + "' and EmpFalg=0";

                getSqlConnection getConnection = new getSqlConnection();
                conn = getConnection.GetCon();
                cmd = new SqlCommand(strSecar, conn);

                hs = cmd.ExecuteReader();


                return hs;


            }
            catch (Exception ee)
            {
                return hs;
            }
        }
        public int EmpInfoFind(string strObject, string pwwd, int intFalg)
        {
            int intCount = 0;
            string strSecar = null;
            try
            {
                switch (intFalg)
                {
                    case 1:
                        strSecar = "select * from EmpIoy where EmpLoginName= '" + strObject + "' and EmpFalg=0";
                        break;
                    case 2:
                        strSecar = "select * from EmpIoy where EmpLoginName= '" + strObject + "' and EmpFalg=0 and EmpLoginPwd='" + pwwd + "'";
                        break;
                }

                getSqlConnection getConnection = new getSqlConnection();
                conn = getConnection.GetCon();
                cmd = new SqlCommand(strSecar, conn);
                hs = cmd.ExecuteReader();
                hs.Read();
                if (hs.HasRows)
                {
                    intCount = 1;
                }


                return intCount;


            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message.ToString());
                return intCount = 2;
            }
        }
        public string EmpInfoID()
        {
            string strName = "ZG";
            Random ran = new Random();
            int j = ran.Next(0, 1000);
            string i = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + j;
            return strName + i;
        }
    }
}
