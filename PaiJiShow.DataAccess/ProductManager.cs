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
    public class ProductManager
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add(ProductInfo model)
        {
            bool result = false;
            if (model != null)
            {
                string sql = string.Format("insert into productInfo (product_name,product_desc,price,image_url,status) values ('{0}','{1}',{2},'{3}',{4})",
                                            model.Product_name,model.Product_desc,model.Price,model.Image_url,model.Status);

                try
                {
                    if (DBHelperSQL.ExecuteSql(sql) > 0) result = true;
                }
                catch (Exception ex)
                { 
                    //日志
                }
            }
            return result;
        }

        /// <summary>
        /// 更新或删除
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public bool UpdateOrDelete(string sql)
        {
            bool result = false;

            if (!string.IsNullOrEmpty(sql))
            {
                if (DBHelperSQL.ExecuteSql(sql) > 0) result = true;
            }

            return result;
        }

        public ProductInfo GetProductById(int id)
        {
            ProductInfo product = new ProductInfo();
            try
            {
                string sql = string.Format("select productId,product_name,product_desc,price,image_url,status from productInfo where id = {0}", id);
                SqlDataReader dr = DBHelperSQL.ExecuteReader(sql);

                if (dr != null)
                {
                    while (dr.Read())
                    {
                        product.ProductId = Convert.ToInt32(dr["productId"]);
                        product.Product_name = dr["product_name"].ToString();
                        product.Product_desc = dr["product_desc"].ToString();
                        product.Price = Convert.ToDecimal(dr["price"].ToString());
                        product.Image_url = dr["image_url"].ToString();
                        product.Status = Convert.ToInt16(dr["status"]) == 1 ? true : false;
                    }
                }
            }
            catch (Exception ex)
            { 
                //日志
            }

            return product;
        }
    }
}
