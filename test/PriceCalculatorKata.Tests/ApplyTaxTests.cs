namespace PriceCalculatorKata.Tests
{
	using NUnit.Framework;

	public class ApplyTaxTests
	{
		[Test]
		public void Tax20ShouldIncreasePriceAfterTax()
		{
			ApplyTaxResult result = new ApplyTaxResult(Product.Sample, new Tax(20));

			string expected = "Product price reported as $20.25 before tax and $24.30 after 20% tax";

			Assert.AreEqual(expected, result.Describe());
		}

		[Test]
		public void Tax21ShouldIncreasePriceAfterTax()
		{
			ApplyTaxResult result = new ApplyTaxResult(Product.Sample, new Tax(21));

			string expected = "Product price reported as $20.25 before tax and $24.50 after 21% tax";

			Assert.AreEqual(expected, result.Describe());
		}

		[Test]
		public void NoneTaxShouldNotAffectPrice()
		{
			ApplyTaxResult result = new ApplyTaxResult(Product.Sample, Tax.None);

			string expected = "Product price reported as $20.25 before tax and $20.25 after 0% tax";

			Assert.AreEqual(expected, result.Describe());
		}
	}
}