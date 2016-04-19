using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaiJiShow.Model
{
    public class CommentInfo
    {

        private int commentID;
        /// <summary>
        /// 评论ID
        /// </summary>
        public int CommentID
        {
            get { return commentID; }
            set { commentID = value; }
        }

        private int userID;
        /// <summary>
        /// 所属用户ID
        /// </summary>
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }


        private int masterID;
        /// <summary>
        /// 视频或者产品ID
        /// </summary>
        public int MasterID
        {
            get { return masterID; }
            set { masterID = value; }
        }


        private string contents;
        /// <summary>
        /// 评论,心得内容
        /// </summary>
        public string Contents
        {
            get { return contents; }
            set { contents = value; }
        }


        private DateTime release_Time;
        /// <summary>
        /// 评论发布时间
        /// </summary>
        public DateTime Release_Time
        {
            get { return release_Time; }
            set { release_Time = value; }
        }


        private int classify;
        /// <summary>
        /// 评论分类(1:视频评论 2:产品评论)
        /// </summary>
        public int Classify
        {
            get { return classify; }
            set { classify = value; }
        }


        private bool status;
        /// <summary>
        /// 状态
        /// </summary>
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        private UserInfo userInfo;
        public UserInfo UserInfo
        {
            get { return userInfo; }
            set { userInfo = value; }
        }

    }
}
