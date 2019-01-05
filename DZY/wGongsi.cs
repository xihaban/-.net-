using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DZY;
using System.Windows.Forms;
namespace DZY
{
    public class wGongsi
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader hs = null;

        int i = 0;
        public int CompanyAdd(getGongsi Company)
        {
            int intFalg = 0;
            try
            {
                string str_Add = "insert into Company values( ";
              str_Add+="'"+Company.getCompanyID + "','"+Company.getCompanyName + "','"+Company.getCompanyDirector + "',";
               str_Add+="'"+Company.getCompanyPhone + "','"+Company.getCompanyAddress + "',";
                              str_Add+="'"+Company.getEmpFalg + "')";
              getSqlConnection getConnection = new getSqlConnection();
              conn = getConnection.GetCon();
              cmd = new SqlCommand(str_Add,conn);
              intFalg = cmd.ExecuteNonQuery();
              conn.Dispose();
              return intFalg; 
            }
            catch (Exception ee)
            {
                return intFalg;
                
            }

        }
        public int CompanyUpDate(getGongsi Company)
        {
            int intFalg = 0;
            try
            {
                string str_Update = "update Company  set ";
                str_Update += "CompanyName='" + Company.getCompanyName + "',CompanyDirector='" + Company.getCompanyDirector + "',";
                str_Update += "CompanyPhone='" + Company.getCompanyPhone  + "',CompanyAddress='" + Company.getCompanyAddress + "',";
                str_Update += "Falg='" + Company.getEmpFalg + "' where CompanyID ='" + Company.getCompanyID + "'";
               
              
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
        public int CompanyDelete(getGongsi Company)
        {
            int intFalg = 0;
            try
            {
                string str_Del = "update Company  set ";
                str_Del += "Falg='" + Company.getEmpFalg + "' where CompanyID ='" + Company.getCompanyID + "'";


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
        public void CompanyFind(string strObject, int intFalg, Object DataObject)
        {
            int intCount = 0;
            string strSecar = null;

            try
            {
                switch (intFalg)
                {
                    case 1:
                        strSecar = "select * from Company  where CompanyName like  '%" + strObject + "%' and Falg= 0";
                        break;
                    case 2:

                        strSecar = "select * from Company  where CompanyDirector like '%" + strObject + "%' and Falg= 0";
                        break;
                    case 3:
                        strSecar = "select * from Company  where Falg= 0";
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
                        dv[4, i].Value = hs[4].ToString();
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

                MessageBox.Show(ee.ToString());

            }

        }
        public SqlDataReader CompanyFind(string strObject)
        {
           
            string strSecar = null;

            try
            {

                strSecar = "select * from Company  where CompanyID =  '" + strObject + "' and Falg= 0";
              

                getSqlConnection getConnection = new getSqlConnection();
                conn = getConnection.GetCon();
                cmd = new SqlCommand(strSecar, conn);
                int ii = 0;
                hs = cmd.ExecuteReader();
                return hs;
          



            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());

                return hs;
            }

        }

        public string CustomerID()
        {
            string strName = "GS";
            Random ran = new Random();
            int j = ran.Next(0, 1000);
            string i = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + j;
            return strName + i;


        }



    }
}
