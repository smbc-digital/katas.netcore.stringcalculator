namespace Katas.NetCore.StringCalculator
{
	public class StringCalculator
	{
		public int Calculate(string input, char delimiter = ',')
		{
			if (string.IsNullOrEmpty(input))
			{
				return 0;
			}

			string[] numbers = input.Split(delimiter);

			int result = 0;

			foreach (var number in numbers)
			{
				try
				{
					if (int.Parse(number) < 100)
					{
						result = result + int.Parse(number);
					}
				}
				catch (System.Exception)
				{
					return 0;
				}
			}

			return result;
		}
	}
}
