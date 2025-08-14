using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace work.Utilities.Extensions
{
    internal static class Helper
    {
        public static bool IsOdd(this int num)
        {
            if (num == 0) return false;
            if (num % 2 == 0) return true;
            return false;
        }
        public static bool IsEven(this int num)
        {
            if (num == 0) return false;
            if (num % 2 == 1 || num%2==-1) return true;
            return false;
        }
        public static bool HasDigit(this string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    return true;
                }

            }
            return false;
        }
        public static bool CheckPassword(this string str)
        {
            bool IsDig=false;
            bool IsUp=false;
            bool IsDown = false;
            if (str.Length > 8)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsDigit(str[i]))
                    {
                        IsDig = true;
                    }
                    if (char.IsUpper(str[i]))
                    {
                        IsUp = true;
                    }
                    if (char.IsLower(str[i]))
                    {
                        IsDown = true;
                    }

                }
                if(IsDig && IsUp && IsDown){
                    return true;
                }

            }
            return false;
        }
        public static string Capitalize(this string str)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(str.Substring(0, 1).ToUpper() + str.Substring(1).ToLower());
            return sb.ToString();
        }
    }
}

