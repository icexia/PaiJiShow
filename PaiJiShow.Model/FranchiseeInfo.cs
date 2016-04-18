using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaiJiShow.Model
{
    public class FranchiseeInfo
    {
        /// <summary>
        /// 加盟商ID
        /// </summary>
        private int franid;
        public int Franid
        {
            get { return franid; }
            set { franid = value; }
        }

        /// <summary>
        /// 加盟商名称
        /// </summary>
        private string fran_Name;
        public string Fran_name
        {
            get { return fran_Name; }
            set { fran_Name = value; }
        }

        /// <summary>
        /// 电话号码
        /// </summary>
        private string call_Number;
        public string Call_Number
        {
            get { return call_Number; }
            set { call_Number = value; }
        }

        /// <summary>
        /// 推广链接
        /// </summary>
        private string promote_Url;
        public string Promote_Url
        {
            get { return promote_Url; }
            set { promote_Url = value; }
        }

        /// <summary>
        /// 加盟商状态
        /// </summary>
        private bool status;
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
