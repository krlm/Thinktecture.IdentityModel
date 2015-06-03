using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Thinktecture.IdentityModel.Client
{
    internal static class WebUtility
    {
        public static string UrlEncode(string value)
        {
            return Uri.EscapeDataString(value).Replace("%20", "+");
        }
    }
}
