using System;
using System.Collections.Generic;
using System.Text;
using DZY;

namespace DZY
{
    public class getJinhuo
    {
        private string GoodsID;
        public string getGoodsID
        {
            get { return GoodsID; }
            set { GoodsID = value; }
        }
        private string EmpId;
        public string getEmpId
        {
            get { return EmpId; }
            set { EmpId = value; }
        }
        private string JhCompName;
        public string getJhCompName
        {
            get { return JhCompName; }
            set { JhCompName = value; }
        }
        private string DepotName;
        public string getDepotName
        {
            get { return DepotName; }
            set { DepotName = value; }
        }
        private string GoodsName;
        public string getGoodsName
        {
            get { return GoodsName; }
            set { GoodsName = value; }
        }
        private int GoodsNum;
        public int getGoodsNum
        {
            get { return GoodsNum; }
            set { GoodsNum = value; }
        }
        private string GoodsJhPrice;
        public string getGoodsJhPrice
        {
            get { return GoodsJhPrice; }
            set { GoodsJhPrice = value; }
        }
        private int EmpFalg;
        public int getFalg
        {
            get { return EmpFalg; }
            set { EmpFalg = value; }
        }
        private DateTime GoodTime;
        public DateTime getGoodTime
        {
            get { return GoodTime; }
            set { GoodTime = value; }
        }
    }
}