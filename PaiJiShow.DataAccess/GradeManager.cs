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
    public class GradeManager
    {
        public bool Add(GradeInfo model)
        {
            bool result=false;
            if (model != null)
            {
                string sql = string.Format("insert into gradeInfo (grade,grade_desc,status) values ('{0}','{1}',{2})", model.Grade, model.Grade_Desc, 1);
                if (DBHelperSQL.ExecuteSql(sql) > 0)
                {
                    result = true;
                }
            }

            return result;
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public bool UpdateOrDelete(string sql)
        {
            bool result = false;

            if (!string.IsNullOrEmpty(sql))
            {
                if (DBHelperSQL.ExecuteSql(sql)>0) result = true;
            }

            return result;
        }

        public bool GetGradeById(int id,out GradeInfo model)
        {
            bool result = false;
            model = new GradeInfo();
            if (id > 0)
            {
                string sql = string.Format("select gradeid,grade,grade_Desc,status from gradeInfo where gradeid={0}", model.Gradeid);
                try
                {
                    SqlDataReader dr = DBHelperSQL.ExecuteReader(sql);
                    if (dr != null)
                    {
                        while (dr.Read())
                        {
                            model.Gradeid = Convert.ToInt32(dr["gradeid"]);
                            model.Grade = dr["grade"].ToString();
                            model.Grade_Desc = dr["grade_Desc"].ToString();
                            model.Status = Convert.ToInt32(dr["status"].ToString())==1?true:false;

                            result = true;
                        }
                    }
                }
                catch (Exception ex)
                { 
                    //日志
                }
                
            }

            return result;
        }
        
    }
}
