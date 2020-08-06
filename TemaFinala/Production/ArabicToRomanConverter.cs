using System;
using System.Text;
using TemaFinala.Production;

namespace SeminarStandard.Production
{
    internal class ArabicToRomanConverter
    {
        private readonly IConvertor convertor;
        public ArabicToRomanConverter(IConvertor convertor)
        {
            this.convertor = convertor;
        }
        internal string CheckNumber(int number)
        {
            if (number <= 0)
            {
                return "Must be greater than 0.";
            }
            if (number>3999)
            {
                return "Must be less than 4000.";
            }
            return convertor.Convert(number);
        }
    }
}