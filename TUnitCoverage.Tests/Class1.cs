namespace TUnitCoverage.Tests;

public class Test1
{
	[Test]
	public async Task TestMethod1()
	{
		var result = AdditionFunctions.Add(1, 1);
		await Assert.That(result).IsEqualTo(2);
	}
}