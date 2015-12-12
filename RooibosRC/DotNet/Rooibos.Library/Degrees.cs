using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooibos.Library
{
    public class Degrees
    {
        public static int Scale(decimal percent, int min, int max)
        {
            decimal variance = max - min;

            return Convert.ToInt32(Math.Round(variance * (percent / 100)));
        }

        public static int Scale(decimal percent, int min, int max, int level)
        {
            decimal variance = 0;
            int degrees = 0;
            int result = 0;

            if (percent < 0)
            {
                variance = level - min;
                degrees = Convert.ToInt32(Math.Round((variance * (percent / 100)), 0));
                result = level + degrees;

                if (result < min)
                {
                    result = min;
                }

                return result;
            }

            if (percent == 0)
            {
                return level;
            }

            variance = max - level;
            degrees = Convert.ToInt32(Math.Round(variance * (percent / 100), 0));
            result = level + degrees;

            if (result > max)
            {
                result = max;
            }

            return result;
        }

        public static int Scale(float controllerInput, int min, int max, int level)
        {
            decimal percent = (Convert.ToDecimal(controllerInput) * 100);

            return Scale(percent, min, max, level);
        }
    }
}
