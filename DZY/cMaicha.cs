using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DZY;

namespace DZY
{
    public partial class cMaicha : Form
    {
        public cMaicha()
        {
            InitializeComponent();
        }

        wMaihuo Sellh = new wMaihuo();
        getMaihuo SellGoods = new getMaihuo();
        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "")
            {
                MessageBox.Show("请选择查询条件！");
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入查询信息");
                return;
            }
            switch (comboBox1.Text)
            {
                case "商品名称":
                    SellGoods.getGoodsName = textBox1.Text;
                    Sellh.SellGoodsFind(dataGridView1, 1, SellGoods);
                    break;
                case "销售人员":
                    SellGoods.getEmpId = textBox1.Text;
                    Sellh.SellGoodsFind(dataGridView1, 2, SellGoods);
                    break;
            }
        }
    }
}
