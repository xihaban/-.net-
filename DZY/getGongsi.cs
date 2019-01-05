using System;
using System.Collections.Generic;
using System.Text;
using DZY;

namespace DZY
{
    public class getGongsi
    {
        private string CompanyID;
        public string getCompanyID
        {
            get { return CompanyID; }
            set { CompanyID = value; }
        }
        private string CompanyName;
        public string getCompanyName
        {
            get { return CompanyName; }
            set { CompanyName = value; }
        }
        private string CompanyDirector;
        public string getCompanyDirector
        {
            get { return CompanyDirector; }
            set { CompanyDirector = value; }
        }
        private string CompanyPhone;
        public string getCompanyPhone
        {
            get { return CompanyPhone; }
            set { CompanyPhone = value; }
        }

        private string CompanyAddress;
        public string getCompanyAddress
        {
            get { return CompanyAddress; }
            set { CompanyAddress = value; }
        }
        private int EmpFalg;
        public int getEmpFalg
        {
            get { return EmpFalg; }
            set { EmpFalg = value; }
        }
    }
}