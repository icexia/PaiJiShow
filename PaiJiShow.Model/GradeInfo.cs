using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaiJiShow.Model
{
    public class GradeInfo
    {
        private int gradeid;
        /// <summary>
        /// 会员等级ID
        /// </summary>
        public int Gradeid
        {
            get { return gradeid; }
            set { gradeid = value; }
        }

        private string grade;
        /// <summary>
        /// 会员等级
        /// </summary>
        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        private string grade_Desc;
        /// <summary>
        /// 会员等级描述
        /// </summary>
        public string Grade_Desc
        {
            get { return grade_Desc; }
            set { grade_Desc = value; }
        }

        private bool status;
        /// <summary>
        /// 等级状态
        /// </summary>
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
