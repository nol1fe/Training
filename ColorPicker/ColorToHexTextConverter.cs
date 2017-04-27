using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorPicker
{
    public static class ColorToHexTextConverter
    {
        public static string GetHexText(this System.Drawing.Color c)
        {
            var result = string.Empty;

            try
            {
                result = "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
    }
}
