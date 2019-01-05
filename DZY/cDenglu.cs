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
    public partial class cDenglu : Form
    {
        public cDenglu() 
        {
            InitializeComponent();
            Cursor.Current = Cursors.Default;
            Cursor.Show();
            txtPwd.PasswordChar = '*';
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)

        {
            wZhigong tbEmp = new wZhigong();
            if (txtID.Text == "")
            {
                MessageBox.Show("用户名不能为空！");
                return;
            }
            if (txtPwd.Text == "")
            {
                MessageBox.Show("密码不能为空！");
                return;
            }
            if (tbEmp.EmpInfoFind(txtID.Text, txtPwd.Text, 2) == 1)
            {
                cIndex frm = new cIndex(txtID.Text);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("登录失败！");
            }
        }

    }
}