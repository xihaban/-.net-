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
    public partial class cIndex : Form
    {
        public cIndex()
        {
            InitializeComponent();
        }
        public cIndex(string strName)
        {
            InitializeComponent();
            SendNameValue = strName;
        }
        public string SendNameValue;
        private void menuGoodsIn_Click(object sender, EventArgs e)
        {
            //进货信息
            cJinhuo jh = new cJinhuo();
            jh.Owner = this;
            jh.ShowDialog();
        }

        private void menuEmployee_Click(object sender, EventArgs e)
        {
            //员工信息
            cZhigong emp = new cZhigong();
             emp.Owner = this;
             emp.ShowDialog();
        }

        private void menuCompany_Click(object sender, EventArgs e)
        {
            //供应商信息
             cGongying com = new cGongying();
             com.Owner = this;
             com.ShowDialog();
        }

        private void menuFind_Click(object sender, EventArgs e)
        {
            //商品信息查查询
             cChajin ch = new cChajin();
             ch.Owner = this;
             ch.ShowDialog();
        }

        private void menuDepotFind_Click(object sender, EventArgs e)
        {
            //库存查询
             cChaku ckc = new cChaku();
             ckc.Owner = this;
             ckc.ShowDialog();
        }

        private void menuSellGoods_Click(object sender, EventArgs e)
        {
            //商品销售信息
            cMaihuo mh = new cMaihuo();
            mh.Owner = this;
            mh.ShowDialog();
        }

        private void menuSellFind_Click(object sender, EventArgs e)
        {
            //出售商品查询信息
             cMaicha cmh = new cMaicha();
             cmh.Owner = this;
             cmh.ShowDialog();
        }
        private void menuDepotAlarm_Click(object sender, EventArgs e)
        {
            //库存管理信息
            cKucun cmh = new cKucun();
            cmh.Owner = this;
            cmh.ShowDialog();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {

            this.statusTime.Text = "当前时间：" + DateTime.Now.ToString();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void 重新登陆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cDenglu frm = new cDenglu();
            frm.Show();
            this.Hide();
        }

        private void 直接退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
 
 