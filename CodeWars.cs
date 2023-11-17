using System.Security.Cryptography;
using System.Text;
using System;

public class CodeWars
{
    public static string crack(string hash)
    {
        using (MD5 mD = MD5.Create())
        {
            for (int i = 0; i < 100000; i++) 
            {
                var pass = string.Format("{0:00000}", i);
                var hashb = mD.ComputeHash(Encoding.ASCII.GetBytes(pass));
                var sh = BitConverter.ToString(hashb).Replace("-", "");
                if(hash.Equals(sh, StringComparison.OrdinalIgnoreCase))
                        return pass;
            }
        }
        return "";
    }
}
