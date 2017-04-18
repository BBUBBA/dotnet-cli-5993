using System;

namespace ConsoleApp5
{
	using System.Threading.Tasks;

	class Program
	{
		static void Main() => F().Wait();
		static async Task F() => await TaskEx.Delay(10000);
	}
}