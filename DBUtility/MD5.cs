using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DBUtility
{
    public static class MD5
    {
        public static string GetMd5Hash(string input)
        {
            byte[] data = Encrypt(input);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }
            return sb.ToString();
        }

        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] Encrypt(string data)
        {
            byte[] binOut = null;
            System.Security.Cryptography.MD5 crySP = null;
            try
            {
                crySP = new MD5CryptoServiceProvider();
                binOut = crySP.ComputeHash(Encoding.Default.GetBytes(data));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (crySP != null)
                {
                    crySP.Clear();
                }
            }
            return binOut;
        }
    }
}
