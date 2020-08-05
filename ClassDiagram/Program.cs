namespace ClassDiagram
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Engine engine = new Engine();

			Car car = new Car(engine);

			Book book = new Book(100);
		}
	}
}