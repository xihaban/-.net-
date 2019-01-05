namespace DZY
{
    partial class cIndex
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cIndex));
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.statuslabMenuInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStockManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGoodsIn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFind = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBaseManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSellManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSellGoods = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSellFind = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDepotManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDepotAlarm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDepotFind = new System.Windows.Forms.ToolStripMenuItem();
            this.退出TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新登陆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.直接退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // statusTime
            // 
            this.statusTime.Name = "statusTime";
            this.statusTime.Size = new System.Drawing.Size(298, 17);
            this.statusTime.Spring = true;
            // 
            // statuslabMenuInfo
            // 
            this.statuslabMenuInfo.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.statuslabMenuInfo.Name = "statuslabMenuInfo";
            this.statuslabMenuInfo.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.statuslabMenuInfo.Size = new System.Drawing.Size(298, 17);
            this.statuslabMenuInfo.Spring = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslabMenuInfo,
            this.toolStripStatusLabel1,
            this.statusTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 284);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(623, 22);
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStockManage
            // 
            this.menuStockManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGoodsIn,
            this.menuFind});
            this.menuStockManage.Name = "menuStockManage";
            this.menuStockManage.Size = new System.Drawing.Size(68, 21);
            this.menuStockManage.Text = "进货管理";
            // 
            // menuGoodsIn
            // 
            this.menuGoodsIn.Name = "menuGoodsIn";
            this.menuGoodsIn.Size = new System.Drawing.Size(124, 22);
            this.menuGoodsIn.Tag = "5";
            this.menuGoodsIn.Text = "商品进货";
            this.menuGoodsIn.Click += new System.EventHandler(this.menuGoodsIn_Click);
            // 
            // menuFind
            // 
            this.menuFind.Name = "menuFind";
            this.menuFind.Size = new System.Drawing.Size(124, 22);
            this.menuFind.Tag = "7";
            this.menuFind.Text = "商品查询";
            this.menuFind.Click += new System.EventHandler(this.menuFind_Click);
            // 
            // menuBaseManage
            // 
            this.menuBaseManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEmployee,
            this.menuCompany});
            this.menuBaseManage.Name = "menuBaseManage";
            this.menuBaseManage.Size = new System.Drawing.Size(68, 21);
            this.menuBaseManage.Text = "基本档案";
            // 
            // menuEmployee
            // 
            this.menuEmployee.Name = "menuEmployee";
            this.menuEmployee.Size = new System.Drawing.Size(136, 22);
            this.menuEmployee.Tag = "1";
            this.menuEmployee.Text = "员工信息";
            this.menuEmployee.Click += new System.EventHandler(this.menuEmployee_Click);
            // 
            // menuCompany
            // 
            this.menuCompany.Name = "menuCompany";
            this.menuCompany.Size = new System.Drawing.Size(136, 22);
            this.menuCompany.Tag = "2";
            this.menuCompany.Text = "供应商信息";
            this.menuCompany.Click += new System.EventHandler(this.menuCompany_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBaseManage,
            this.menuStockManage,
            this.menuSellManage,
            this.menuDepotManage,
            this.退出TToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuSellManage
            // 
            this.menuSellManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSellGoods,
            this.menuSellFind});
            this.menuSellManage.Name = "menuSellManage";
            this.menuSellManage.Size = new System.Drawing.Size(68, 21);
            this.menuSellManage.Text = "销售管理";
            // 
            // menuSellGoods
            // 
            this.menuSellGoods.Name = "menuSellGoods";
            this.menuSellGoods.Size = new System.Drawing.Size(124, 22);
            this.menuSellGoods.Tag = "8";
            this.menuSellGoods.Text = "商品销售";
            this.menuSellGoods.Click += new System.EventHandler(this.menuSellGoods_Click);
            // 
            // menuSellFind
            // 
            this.menuSellFind.Name = "menuSellFind";
            this.menuSellFind.Size = new System.Drawing.Size(124, 22);
            this.menuSellFind.Tag = "10";
            this.menuSellFind.Text = "销售查询";
            this.menuSellFind.Click += new System.EventHandler(this.menuSellFind_Click);
            // 
            // menuDepotManage
            // 
            this.menuDepotManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDepotAlarm,
            this.menuDepotFind});
            this.menuDepotManage.Name = "menuDepotManage";
            this.menuDepotManage.Size = new System.Drawing.Size(68, 21);
            this.menuDepotManage.Text = "库存管理";
            // 
            // menuDepotAlarm
            // 
            this.menuDepotAlarm.Name = "menuDepotAlarm";
            this.menuDepotAlarm.Size = new System.Drawing.Size(124, 22);
            this.menuDepotAlarm.Tag = "12";
            this.menuDepotAlarm.Text = "库存管理";
            this.menuDepotAlarm.Click += new System.EventHandler(this.menuDepotAlarm_Click);
            // 
            // menuDepotFind
            // 
            this.menuDepotFind.Name = "menuDepotFind";
            this.menuDepotFind.Size = new System.Drawing.Size(124, 22);
            this.menuDepotFind.Tag = "13";
            this.menuDepotFind.Text = "库存查询";
            this.menuDepotFind.Click += new System.EventHandler(this.menuDepotFind_Click);
            // 
            // 退出TToolStripMenuItem
            // 
            this.退出TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重新登陆ToolStripMenuItem,
            this.直接退出ToolStripMenuItem});
            this.退出TToolStripMenuItem.Name = "退出TToolStripMenuItem";
            this.退出TToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.退出TToolStripMenuItem.Text = "退出";
            // 
            // 重新登陆ToolStripMenuItem
            // 
            this.重新登陆ToolStripMenuItem.Name = "重新登陆ToolStripMenuItem";
            this.重新登陆ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.重新登陆ToolStripMenuItem.Text = "重新登陆";
            this.重新登陆ToolStripMenuItem.Click += new System.EventHandler(this.重新登陆ToolStripMenuItem_Click);
            // 
            // 直接退出ToolStripMenuItem
            // 
            this.直接退出ToolStripMenuItem.Name = "直接退出ToolStripMenuItem";
            this.直接退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.直接退出ToolStripMenuItem.Text = "直接退出";
            this.直接退出ToolStripMenuItem.Click += new System.EventHandler(this.直接退出ToolStripMenuItem_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // cIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(623, 306);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "cIndex";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "超市进销存";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusTime;
        private System.Windows.Forms.ToolStripStatusLabel statuslabMenuInfo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStockManage;
        private System.Windows.Forms.ToolStripMenuItem menuGoodsIn;
        private System.Windows.Forms.ToolStripMenuItem menuFind;
        private System.Windows.Forms.ToolStripMenuItem menuBaseManage;
        private System.Windows.Forms.ToolStripMenuItem menuEmployee;
        private System.Windows.Forms.ToolStripMenuItem menuCompany;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSellManage;
        private System.Windows.Forms.ToolStripMenuItem menuSellGoods;
        private System.Windows.Forms.ToolStripMenuItem menuDepotManage;
        private System.Windows.Forms.ToolStripMenuItem menuDepotAlarm;
        private System.Windows.Forms.ToolStripMenuItem menuDepotFind;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem 退出TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新登陆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 直接退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSellFind;
    }
}