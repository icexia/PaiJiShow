using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaiJiShow.Model
{
    public class VideoInfo
    {
        /// <summary>
        /// 视频ID
        /// </summary>
        private int videoID;
        public int VideoID
        {
            get { return videoID; }
            set { videoID = value; }
        }

        /// <summary>
        /// 标题
        /// </summary>
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        /// <summary>
        /// 上传者
        /// </summary>
        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        /// <summary>
        /// 发布时间
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
    }
}
