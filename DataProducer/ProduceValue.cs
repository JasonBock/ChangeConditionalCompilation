namespace DataProducer
{
	public sealed class ProduceValue
	{
		public string Produce()
		{
#if WAS_SET
			return "WAS SET";
#else
			return "NOTHING WAS SET";
#endif
		}
	}
}
