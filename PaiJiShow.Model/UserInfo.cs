using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaiJiShow.Model
{
    public class UserInfo
    {
        private int userID;
        private string userName;
        private string password;
        private string chinese_Name;
        private string email;
        private int gradeid;
        private int franid;
        private float balance;
        private bool is_Admin;
        private bool status;

        /// <summary>
        /// 用户ID(主键)
        /// </summary>
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        
        /// <summary>
        /// 密码
        /// </summary>
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        
        /// <summary>
        /// 中文名
        /// </summary>
        public string Chinese_Name
        {
            get { return chinese_Name; }
            set { chinese_Name = value; }
        }
        
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        
        /// <summary>
        /// 会员等级ID
        /// </summary>
        public int Gradeid
        {
            get { return gradeid; }
            set { gradeid = value; }
        }

        /// <summary>
        /// 加盟商ID
        /// </summary>
        public int Franid
        {
            get { return franid; }
            set { franid = value; }
        }

        /// <summary>
        /// 账户余额
        /// </summary>
        public float Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        /// <summary>
        /// 是否管理员
        /// </summary>
        public bool Is_Admin
        {
            get { return is_Admin; }
            set { is_Admin = value; }
        }

        /// <summary>
        /// 用户状态
        /// </summary>
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        /// <summary>
        /// 等级
        /// </summary>
        private GradeInfo gradeInfo;
        public GradeInfo GradeInfo
        {
            get { return gradeInfo; }
            set { gradeInfo = value; }
        }

        /// <summary>
        /// 加盟商
        /// </summary>
        private FranchiseeInfo franchiseeInfo;
        public FranchiseeInfo FranchiseeInfo
        {
            get { return franchiseeInfo; }
            set { franchiseeInfo = value; }
        }
    }
}
