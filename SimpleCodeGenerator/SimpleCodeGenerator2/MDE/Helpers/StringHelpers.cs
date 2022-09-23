namespace SimpleCodeGenerator;

public static class StringHelpers
{
	public static string RemoveCarriageReturns(this string sample)
	{
		return sample.Replace("\r\n", "\n");
	}
}