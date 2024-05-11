using EasyTool.ConvertCategory;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace EasyTool
{
    /// <summary>
    /// MD5加密工具类
    /// </summary>
    public class MD5Utils
    {
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="source">加密字符串</param>
        /// <param name="lowerCase">是否小写</param>
        /// <returns></returns>
        public static string Encrypt(string source, bool lowerCase = false)
        {
            if (string.IsNullOrWhiteSpace(source))
                return string.Empty;

            return Encrypt(Encoding.UTF8.GetBytes(source), lowerCase);
        }

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="source">加密字节流</param>
        /// <param name="lowerCase">是否小写</param>
        /// <returns></returns>
        public static string Encrypt(byte[] source, bool lowerCase = false)
        {
            if (source == null)
                return string.Empty;

            using var md5Hash = MD5.Create();
            return md5Hash.ComputeHash(source).ToHex(lowerCase);
        }

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="inputStream">流</param>
        /// <param name="lowerCase">是否小写</param>
        /// <returns></returns>
        public static string Encrypt(Stream inputStream, bool lowerCase = false)
        {
            if (inputStream == null) return string.Empty;

            using var md5Hash = MD5.Create();
            return md5Hash.ComputeHash(inputStream).ToHex(lowerCase);
        }
    }
}
