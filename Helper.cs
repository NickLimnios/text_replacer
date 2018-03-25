using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextReplacer
{
    public static class Helper
    {
        public static string StringValueParser(object obj)
        {
            return obj == null ? String.Empty : obj.ToString();
        }
    }
}
