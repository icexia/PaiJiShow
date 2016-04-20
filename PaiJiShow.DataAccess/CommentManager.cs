using DBUtility;
using PaiJiShow.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaiJiShow.DataAccess
{
    public class CommentManager
    {
        public bool Add(CommentInfo model)
        {
            bool result = false;

            if (model != null)
            {
                string sql = string.Format("insert into commentInfo (userid,contents,release_time,status,masterid,classify) values ({0},'{1}','{2}',{3},{4},{5})",
                                        model.UserID, model.Contents, model.Release_Time, model.Status, model.MasterID, model.Classify);

                try
                {
                    if (DBHelperSQL.ExecuteSql(sql)>0) result = true;
                }
                catch (Exception ex)
                { 
                    //日志
                }
            }

            return result;
        }

        public bool UpdateOrDelete(string sql)
        {
            bool result =false;
            if (!string.IsNullOrEmpty(sql))
            {
                if (DBHelperSQL.ExecuteSql(sql) > 0) result = true;
            }

            return result;
        }

        public CommentInfo GetCommentByMasterId(int masterid,int classify)
        {
            CommentInfo model = new CommentInfo();
            string sql = string.Format("select commentid,userid,contents,release_time from commentInfo where masterid={0} and classify ={1}", masterid, classify);
            try
            {
                //list
            }
            catch (Exception ex)
            { 
                //日志
            }

            return model;
        }

        public List<CommentInfo> GetCommentPageList(int page, int pageIndex, int row, string sort, string order, string userName)
        {
            List<CommentInfo> list = new List<CommentInfo>();

            return list;
        }
    }
}
