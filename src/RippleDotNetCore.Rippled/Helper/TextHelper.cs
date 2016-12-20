using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RippleDotNetCore.Rippled.Helper
{
    public static class TextHelper
    {
        private static readonly CultureInfo _cultureInfo = CultureInfo.InvariantCulture;

        public static string ToTitleCase(this string str)
        {
            var tokens = Regex.Split(_cultureInfo.TextInfo.ToLower(str), "([ -])");

            for (var i = 0; i < tokens.Length; i++)
            {
                if (!Regex.IsMatch(tokens[i], "^[ -]$"))
                {
                    tokens[i] = $"{_cultureInfo.TextInfo.ToUpper(tokens[i].Substring(0, 1))}{tokens[i].Substring(1)}";
                }
            }

            return string.Join("", tokens);
        }
    }
}
