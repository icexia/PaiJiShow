using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaiJiShow.Model
{
    public class ProductInfo
    {
        private int productId;
        /// <summary>
        /// 产品ID
        /// </summary>
        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        private string product_name;
        /// <summary>
        /// 产品名称
        /// </summary>
        public string Product_name
        {
            get { return product_name; }
            set { product_name = value; }
        }

        private string product_desc;
        /// <summary>
        /// 产品描述
        /// </summary>
        public string Product_desc
        {
            get { return product_desc; }
            set { product_desc = value; }
        }

        private decimal price;
        /// <summary>
        /// 产品价格
        /// </summary>
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private string image_url;
       /// <summary>
       /// 图片地址
       /// </summary>
        public string Image_url
        {
            get { return image_url; }
            set { image_url = value; }
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
    }
}
