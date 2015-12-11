using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooibos.Library
{
    public static class ConvertNice
    {
        public static bool ToBoolean(object value)
        {
            return true;
        }

        public static int ToInt32(object value)
        {
            if (value == null)
            {
                return 0;
            }

            string str = value.ToString();

            int result;

            if (!int.TryParse(str, out result))
            {
                return 0;
            }

            return result;
        }
    }
}
