using DBUtility;
using PaiJiShow.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaiJiShow.DataAccess
{
    public class UserManager
    {
        public bool Add(UserInfo model)
        {
            bool result=false;

            if (model != null)
            {
                string sql = string.Format(@"insert into userInfo (username,password,chinese_name,email,call_number,gradeid,franid,balance,is_Admin) 
                                            values('{0}','{1}','{2}','{3}','{4}',{5},{6},{7},{8})",
                                        model.UserName, model.Password, model.Chinese_Name, model.Email, model.Call_number, model.Gradeid, model.Franid, model.Balance, model.Is_Admin);
                if (DBHelperSQL.ExecuteSql(sql) > 0)
                {
                    result = true;
                }
            }

            return result;
        }

        public bool Update(string sql)
        {
            bool result = false;

            if (!string.IsNullOrEmpty(sql))
            {
                if (DBHelperSQL.ExecuteSql(sql) > 0) result = true;
            }

            return result;
        }

        /// <summary>
        /// 重置密码
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="oldPwd"></param>
        /// <param name="newPwd"></param>
        /// <returns></returns>
        public bool ReSetPassword(string userName,string oldPwd, string newPwd)
        {
            bool result = false;
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(oldPwd))
            {
                if (Authentication(userName, oldPwd))//先校验账户
                {
                    string sql = string.Format("update userInfo set password='{0}'", newPwd);
                    if (DBHelperSQL.ExecuteSql(sql)>0)
                    {
                        result = true;                    
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            bool result = false;

            if (id > 0)
            {
                string sql = string.Format("delete userInfo where userid={0}", id);
                try
                {
                    if (DBHelperSQL.ExecuteSql(sql) > 0) result = true;
                }
                catch(Exception ex)
                {
                    //写日志
                }

            }  
            return result;
        }

        public bool GetUserById(int id,out UserInfo model)
        {
            bool result = false;
            model = new UserInfo();

            return result;
        }

        /// <summary>
        /// 根据账号、密码获取用户
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public bool GetUserByUserNmae(string userName,string pwd)
        {
            bool result = false;
            
            if (!string.IsNullOrEmpty(userName))
            {
                string sql =string.Empty;
                if (string.IsNullOrEmpty(pwd))
                {
                   sql = string.Format("select count(userid) from userInfo where userName ='{0}'", userName);
                }
                else
                {
                    sql = string.Format("select count(userid) from userInfo where userName ='{0}' and password='{1}'", userName, pwd);
                }
                
                try
                {
                    int count = (int)DBHelperSQL.ExecuteScalar(sql);
                    if (count == 1) result = true;
                }
                catch (Exception ex)
                { 
                    //写日志
                }
            }

            return result;
        }

        public bool GetUserPageList(int page, int pageIndex, int row, string sort, string order, string userName, out List<UserInfo> list)
        {
            bool result = false;
            list=null;

            return result;
        }

        //public bool GetPageListBy

        /// <summary>
        /// 账号密码验证
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public bool Authentication(string userName, string pwd)
        {
            bool result = false;

            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(pwd))
            {
                if (GetUserByUserNmae(userName, pwd))
                {
                    result = true;    
                }
            }

            return result;
        }
    }
}
