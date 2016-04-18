using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaiJiShow.Model
{
    public class CommentInfo
    {
        /// <summary>
        /// 评论ID
        /// </summary>
        private int commentID;
        public int CommentID
        {
            get { return commentID; }
            set { commentID = value; }
        }

        /// <summary>
        /// 所属用户ID
        /// </summary>
        private int userID;
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        /// <summary>
        /// 评论,心得内容
        /// </summary>
        private string contents;
        public string Contents
        {
            get { return contents; }
            set { contents = value; }
        }

        /// <summary>
        /// 评论发布时间
        /// </summary>
        private DateTime release_Time;
        public DateTime Release_Time
        {
            get { return release_Time; }
            set { release_Time = value; }
        }

        /// <summary>
        /// 状态
        /// </summary>
        private bool status;
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
