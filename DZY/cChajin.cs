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
    public partial class cChajin : Form
    {
        public cChajin()
        {
            InitializeComponent();
        }


        wJinhuo jh = new wJinhuo();

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("请选择查询条件！");
                return;
            }
            if (comboBox1.Text != "" && comboBox1.Text != "查询所有信息" && textBox1.Text == "")
            {
                MessageBox.Show("请输入查查信息");
                return;
            }
            switch (comboBox1.Text)
            {
                case "商品编号":
                    jh.JhGoodsFind(textBox1.Text, 1, dataGridView1);
                    break;
                case "商品名称":
                    jh.JhGoodsFind(textBox1.Text, 2, dataGridView1);
                    break;
                case "查询所有信息":
                    jh.JhGoodsFind(textBox1.Text, 5, dataGridView1);
                    break;
            }
        }

    }
}