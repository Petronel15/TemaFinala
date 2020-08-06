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
        //string result = string.Empty;
        //public string Convert(int number)
        //{
        //    if (number >= 1000)
        //    {
        //        return "M" + Convert(number - 1000);
        //    }
        //    if (number >= 900)
        //    {
        //        return "CM" + Convert(number - 900);
        //    }
        //    if (number >= 500)
        //    {
        //        return "D" + Convert(number - 500);
        //    }
        //    if (number >= 400)
        //    {
        //        return "CD" + Convert(number - 400);
        //    }
        //    if (number >= 100)
        //    {
        //        return "C" + Convert(number - 100);
        //    }
        //    if (number >= 90)
        //    {
        //        return "XC" + Convert(number - 90);
        //    }
        //    if (number >= 50)
        //    {
        //        return "L" + Convert(number - 50);
        //    }
        //    if (number >= 40)
        //    {
        //        return "XL" + Convert(number - 40);
        //    }
        //    if (number >= 10)
        //    {
        //        return "X" + Convert(number - 10);
        //    }
        //    if (number >= 9)
        //    {
        //        return "IX" + Convert(number - 9);
        //    }
        //    if (number >= 5)
        //    {
        //        return "V" + Convert(number - 5);
        //    }
        //    if (number >= 4)
        //    {
        //        return "IV" + Convert(number - 4);
        //    }
        //    if (number >= 1)
        //    {
        //        return "I" + Convert(number - 1);
        //    }
        //    return result;
        //}
    }
}
