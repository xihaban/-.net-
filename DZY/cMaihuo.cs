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
    public partial class cMaihuo : Form
    {
        public cMaihuo()
        {
            InitializeComponent();
        }

        getMaihuo sellGoods = new getMaihuo();
        wMaihuo Sellh = new wMaihuo();
        public int intCount = 0;
        public string kcId = "";
        public string GoodId = null;
        private void frmSellGoods_Load(object sender, EventArgs e)
        {
            Sellh.SellGoodsFind(dataGridView1);
        }

        public void Clear()
        {
            txtSellID.Text = "";
            txtEmpID.Text = "";
            txtGoodsName.Text = "";
            txtdeSellPrice.Text = "";
            txtSellGoodsNum.Text = "";

        }
        public int fillGetInfo()
        {
            int intResult = 0;
            if (intCount == 1 || intCount == 2)
            {
                if (txtSellID.Text == "")
                {
                    MessageBox.Show("商品销售编号不能为空");
                    return intResult;
                }
                if (txtGoodsName.Text == "")
                {
                    MessageBox.Show("商品名称不能为空");
                    return intResult;
                }
                if (txtSellGoodsNum.Text == "")
                {
                    MessageBox.Show("商品数量不能为空");
                    return intResult;
                }
                if (txtdeSellPrice.Text == "")
                {
                    MessageBox.Show("商品价格不能为空");
                    return intResult;
                }

                sellGoods.getSellID = txtSellID.Text;
                sellGoods.getKcID = kcId.ToString();
                sellGoods.getGoodsID = GoodId;
                sellGoods.getEmpId = txtEmpID.Text;
                sellGoods.getGoodsName = txtGoodsName.Text;
                sellGoods.getSellGoodsNum = Convert.ToInt32(txtSellGoodsNum.Text);
                sellGoods.getSellGoodsTime = DaSellGoodsTime.Value;
                sellGoods.getSellPrice = txtdeSellPrice.Text;

            }
            if (intCount != 3)
            {
                sellGoods.getSellFalg = 0;
            }
            else
            {
                if (txtSellID.Text == "")
                {
                    MessageBox.Show("商品销售编号不能为空！,请选择要删除的商品信息", "信息提示");
                    return intResult;
                }
                sellGoods.getSellID = txtSellID.Text;
                sellGoods.getSellFalg = 1;
            }
            intResult = 1;
            return intResult;
        }
        private void toolSave_Click(object sender, EventArgs e)
        {
            if (fillGetInfo() == 1)
            {
                if (intCount == 1)
                {
                    if (Sellh.SellGoodsAdd(sellGoods) == 1)
                    {
                        MessageBox.Show("添加成功");
                        Clear();

                        intCount = 0;
                        Sellh.SellGoodsFind(dataGridView1);
                    }
                    else
                    {

                        MessageBox.Show("添加失败");
                        Clear();

                        intCount = 0;
                    }

                }
                if (intCount == 2)
                {
                    if (Sellh.SellGoodsUpdate(sellGoods) == 1)
                    {
                        MessageBox.Show("修改成功");
                        Clear();

                        intCount = 0;
                        Sellh.SellGoodsFind(dataGridView1);
                    }
                    else
                    {

                        MessageBox.Show("修改失败");
                        Clear();

                        intCount = 0;
                    }
                }
                if (intCount == 3)
                {
                    if (Sellh.SellGoodsDelete(sellGoods) == 1)
                    {
                        MessageBox.Show("删除成功");
                        Clear();

                        intCount = 0;
                        Sellh.SellGoodsFind(dataGridView1);

                    }
                    else
                    {
                        MessageBox.Show("删除成功");
                        Clear();

                        intCount = 0;
                    }
                }
            }//
        }
        private void toolCancel_Click(object sender, EventArgs e)
        {
            Clear();

            intCount = 0;
        }
        private void toolAdd_Click(object sender, EventArgs e)
        {
            Clear();

            intCount = 1;
            txtSellID.Text = Sellh.getSellID();
        }
        private void toolAmend_Click(object sender, EventArgs e)
        {
            Clear();

            intCount = 2;
        }
        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtdeSellPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("输入数字");
                e.Handled = true;
            }
        }

        private void txtSellGoodsNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("输入数字");
                e.Handled = true;
            }
        }

        private void txtdeSellHasPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("输入数字");
                e.Handled = true;
            }
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (intCount == 2 || intCount == 3)
            {
                FillControls();
            }
        }
        private void FillControls()
        {
            try
            {
                SqlDataReader sqldr = Sellh.SellGoodsFind(this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString());
                sqldr.Read();
                if (sqldr.HasRows)
                {

                    txtSellID.Text = sqldr[0].ToString();
                    txtEmpID.Text = sqldr[3].ToString();
                    txtGoodsName.Text = sqldr[4].ToString();
                    txtSellGoodsNum.Text = sqldr[5].ToString();
                    DaSellGoodsTime.Value = Convert.ToDateTime(sqldr[6].ToString());
                    txtdeSellPrice.Text = sqldr[7].ToString();

                }
                sqldr.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void txtdeSellHasPay_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolDelete_Click(object sender, EventArgs e)
        {

            intCount = 3;
        }

    }
}