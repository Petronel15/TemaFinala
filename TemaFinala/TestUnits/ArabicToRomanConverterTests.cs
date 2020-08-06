using NUnit.Framework;
using NUnit.Framework.Internal;
using SeminarStandard.Production;
using System;
using TemaFinala.Production;

namespace SeminarStandard.TestUnits
{
	[TestFixture]
	public class ArabicToRomanConverterTests
	{
		[TestCase(1, "I")]
		[TestCase(2, "II")]
		[TestCase(3, "III")]
		[TestCase(4, "IV")]
		[TestCase(5, "V")]
		[TestCase(6, "VI")]
		[TestCase(9, "IX")]
		[TestCase(10, "X")]
		[TestCase(40, "XL")]
		[TestCase(50, "L")]
		[TestCase(90, "XC")]
		[TestCase(100, "C")]
		[TestCase(400, "CD")]
		[TestCase(500, "D")]
		[TestCase(900, "CM")]
		[TestCase(1000, "M")]
		[TestCase(9000, "Must be less than 4000.")]
		[TestCase(-10, "Must be greater than 0.")]
		public void Arabic_To_Roman_Tests(int n, string expected)
		{
			Convertor con = new Convertor();
			ArabicToRomanConverter sut = new ArabicToRomanConverter(con);
			Assert.AreEqual(expected, sut.CheckNumber(n));
		}
	}
}