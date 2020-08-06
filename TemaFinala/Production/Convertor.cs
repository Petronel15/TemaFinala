using System.Collections.Generic;
using System.Text;

namespace TemaFinala.Production
{
    public class Convertor:IConvertor
    {
        public readonly Dictionary<int, string> NumberRomanDictionary;
        public Convertor()
        {
            NumberRomanDictionary = new Dictionary<int, string>
            {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" },
            };
        }
        public string Convert(int number)
        {
            var result = new StringBuilder();
            foreach (var item in NumberRomanDictionary)
            {
                while (number >= item.Key)
                {
                    result.Append(item.Value);
                    number -= item.Key;
                }
            }
            return result.ToString();
        }
    }
}
