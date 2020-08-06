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
		//private void ExecuteTest(int number, string expected)
		//{
		//  //Arrange
	    //  Convertor con = new Convertor();
		//	ArabicToRomanConverter sut = new ArabicToRomanConverter(con);

		//	//Act
		//	string result = sut.Compare(number);

		//	//Assert
		//	Assert.AreEqual(expected, result);
		//}

		[TestCase(1,"I")]
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


		//[Test]
		//public void Should_Return_I_For_1()
		//{
		//	ExecuteTest(1, "I");
		//}

		//[Test]
		//public void Should_Return_II_For_2()
		//{
		//	ExecuteTest(2, "II");
		//}

		//[Test]
		//public void Should_Return_III_For_3()
		//{
		//	ExecuteTest(3, "III");
		//}

		//[Test]
		//public void Should_Return_IV_For_4()
		//{
		//	ExecuteTest(4, "IV");
		//}

		//[Test]
		//public void Should_Return_V_For_5()
		//{
		//	ExecuteTest(5, "V");
		//}

		//[Test]
		//public void Should_Return_VI_For_6()
		//{
		//	ExecuteTest(6, "VI");
		//}

		//[Test]
		//public void Should_Return_IX_For_9()
		//{
		//	ExecuteTest(9, "IX");
		//}

		//[Test]
		//public void Should_Return_X_For_10()
		//{
		//	ExecuteTest(10, "X");
		//}

		//[Test]
		//public void Should_Return_XXXIX_For_39()
		//{
		//	ExecuteTest(39, "XXXIX");
		//}

		//[Test]
		//public void Should_Return_XL_For_40()
		//{
		//	ExecuteTest(40, "XL");
		//}

		//[Test]
		//public void Should_Return_L_For_50()
		//{
		//	ExecuteTest(50, "L");
		//}

		//[Test]
		//public void Should_Return_XC_For_90()
		//{
		//	ExecuteTest(90, "XC");
		//}

		//[Test]
		//public void Should_Return_C_For_100()
		//{
		//	ExecuteTest(100, "C");
		//}

		//[Test]
		//public void Should_Return_CD_For_400()
		//{
		//	ExecuteTest(400, "CD");
		//}

		//[Test]
		//public void Should_Return_D_For_500()
		//{
		//	ExecuteTest(500, "D");
		//}

		//[Test]
		//public void Should_Return_CM_For_900()
		//{
		//	ExecuteTest(900, "CM");
		//}

		//[Test]
		//public void Should_Return_M_For_1000()
		//{
		//	ExecuteTest(1000, "M");
		//}
		//[Test]
		//public void Should_Return_Must_be_less_than_4000_For_4500()
		//{
		//	ExecuteTest(4500, "Must be less than 4000.");
		//}

		//[Test]
		//public void Should_Return_Must_be_greater_than_0_For_0_Or_Negative_Numbers()
		//{
		//	ExecuteTest(-10, "Must be greater than 0.");
		//}
	}
}