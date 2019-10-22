using System.Security.Cryptography;
using System.Text;

public class UnityUtil
{
    /// <summary>
    /// MD5Encrypt
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string MD5Encrypt(string str)
    {
        MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
        byte[] hashedDataBytes;
        hashedDataBytes = md5Hasher.ComputeHash(Encoding.GetEncoding("gb2312").GetBytes(str));
        StringBuilder tmp = new StringBuilder();
        foreach (byte i in hashedDataBytes)
        {
            tmp.Append(i.ToString("x2"));
        }
        return tmp.ToString();
    }
}

