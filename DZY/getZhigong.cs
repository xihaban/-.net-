using System;
using System.Collections.Generic;
using System.Text;
using DZY;

namespace DZY
{
    public class getZhigong
    {
        private string EmpId;
        public string getEmpId
        {
            get { return EmpId; }
            set { EmpId = value; }
        }
        private string EmpName;
        public string getEmpName
        {
            get { return EmpName; }
            set { EmpName = value; }
        }
        private string EmpLoginName;
        public string getEmpLoginName
        {
            get { return EmpLoginName; }
            set { EmpLoginName = value; }
        }
        private string EmpLoginPwd;
        public string getEmpLoginPwd
        {
            get { return EmpLoginPwd; }
            set { EmpLoginPwd = value; }
        }
        private string EmpSex;
        public string getEmpSex
        {
            get { return EmpSex; }
            set { EmpSex = value; }
        }
        private DateTime EmpBirthday;
        public DateTime getEmpBirthday
        {
            get { return EmpBirthday; }
            set { EmpBirthday = value; }
        }
        private string EmpPhone;
        public string getEmpPhone
        {
            get { return EmpPhone; }
            set { EmpPhone = value; }
        }

        private int EmpFalg;
        public int getEmpFalg
        {
            get { return EmpFalg; }
            set { EmpFalg = value; }
        }
    }
}