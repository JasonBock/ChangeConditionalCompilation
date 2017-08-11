using System;

namespace DataProducer.ClientWithoutConditional
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(new ProduceValue().Produce());
		}
	}
}