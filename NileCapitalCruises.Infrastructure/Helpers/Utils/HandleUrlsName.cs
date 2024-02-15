using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NileCapitalCruises.Infrastructure.Helpers.Utils
{
    public class HandleUrlsName
    {
        public static string CreateUrlByName(string name)
        {
            string cleaned = Regex.Replace(name, "[^a-zA-Z0-9]+", "-");
            cleaned = cleaned.Trim('-');
            return cleaned;
        }
    }
}
