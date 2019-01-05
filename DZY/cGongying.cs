using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DZY;
using System.Data.SqlClient;
namespace DZY
{
    public partial class cGongying : Form
    {
        public cGongying()
        {
            InitializeComponent();
        }
        public cGongying(int intResult)
        {
            InitializeComponent();
            intReturn = intResult;
        }
        public static int intReturn = 0;
        getGongsi Company = new getGongsi();
        wGongsi Companyy = new wGongsi();
        wJinhuo jhgood = new wJinhuo();
        public static int intFalg =0;

        /// <summary>
        /// 将控件恢复到原始状态
        /// </summary>
        private void ClearControls()
        {

            txtCompanyDirector.Text = "";
            txtCompanyAddress.Text = "";
            txtCompanyName.Text = "";
            txtCompanyPhone.Text = "";
           
        }

        /// 控制控件状态
        /// </summary>

        public int GetCount()
        {
            int intReslult = 0;
            if (intFalg == 1 || intFalg == 2)
            {
                if (txtCompanyName.Text == "")
                {
                    MessageBox.Show("供应商名称不能为空！", "提示");
                    return intReslult;
                }
                if (txtCompanyPhone.Text == "")
                {
                    MessageBox.Show("联系电话不能为空！", "提示");
                    return intReslult;
                }
                if (txtCompanyDirector.Text == "")
                {
                    MessageBox.Show("地址不能为空！", "提示");
                    return intReslult;
                }
                if (intFalg != 2)
                {
                    Company.getCompanyID = Companyy.CustomerID();
                }
                else
                {
                    Company.getCompanyID = this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString();
                }
                Company.getEmpFalg = 0;
                Company.getCompanyAddress = txtCompanyAddress.Text;
                Company.getCompanyDirector = txtCompanyDirector.Text;
                Company.getCompanyName = txtCompanyName.Text;
                Company.getCompanyPhone = txtCompanyPhone.Text;
            }
            if (intFalg == 3)
            {
                if (txtCompanyName.Text == "")
                {
                    MessageBox.Show("供应商名称不能为空！请选择要删除的的记录", "提示");
                    return intReslult;
                }
                Company.getEmpFalg = 1;
                Company.getCompanyID = this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString();
            
            }
     
            intReslult=1;
            return intReslult;
        
        }

        private void frmCompanyInfo_Load(object sender, EventArgs e)
        {
            Companyy.CompanyFind("", 3, dataGridView1);
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            if (GetCount() == 1)
            {
                if (intFalg == 1)
                {
                    if (Companyy.CompanyAdd(Company) == 1)
                    {
                        if (intReturn == 1)
                        {
                            ClearControls();
                            intFalg = 0;
                            this.Close();
                            
                        
                        }
                        MessageBox.Show("添加成功");
                        intFalg = 0;
                        Companyy.CompanyFind("", 3, dataGridView1);
                        ClearControls();
                        
                    }
                    else
                    {
                        MessageBox.Show("添加失败");
                        intFalg = 0;
                        Companyy.CompanyFind("", 3, dataGridView1);
                        ClearControls();
                    }

                }
                if (intFalg == 2)
                {
                    if (Companyy.CompanyUpDate(Company) == 1)
                    {
                        MessageBox.Show("修改成功");
                        intFalg = 0;
                        Companyy.CompanyFind("", 3, dataGridView1);
                        ClearControls();
                    }
                    else
                    {
                        MessageBox.Show("修改失败");
                        intFalg = 0;
                        Companyy.CompanyFind("", 3, dataGridView1);
                        ClearControls();

                    }

                }
                if (intFalg ==3)
                {
                    if (Companyy.CompanyDelete(Company) == 1)
                    {
                        MessageBox.Show("删除成功");
                        intFalg = 0;
                        Companyy.CompanyFind("", 3, dataGridView1);
                        ClearControls();

                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                        intFalg = 0;
                        Companyy.CompanyFind("", 3, dataGridView1);
                        ClearControls();

                    }

                }


            }//
        }
        private void FillControls()
        {
            try
            {
                SqlDataReader sqldr = Companyy.CompanyFind(this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString());

                sqldr.Read();
                if (sqldr.HasRows)
                {
                    txtCompanyName.Text = sqldr[1].ToString();
                    txtCompanyDirector.Text = sqldr[2].ToString();
                    txtCompanyPhone.Text = sqldr[3].ToString();
                    txtCompanyAddress.Text = sqldr[4].ToString();

                }


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());

            }
   
        }

        private void toolCancel_Click(object sender, EventArgs e)
        {
           ClearControls();

            intFalg = 0;
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {

            ClearControls();
            intFalg = 1;
        }

        private void toolAmend_Click(object sender, EventArgs e)
        {

            ClearControls();
            intFalg = 2;
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {

        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (intFalg == 2 || intFalg == 3)
            {
                FillControls();
            }
        }

        private void toolrefesh_Click(object sender, EventArgs e)
        {

            intFalg = 3;
        }
    }
}