namespace VideoStore
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Customer customer = new Customer();
			RentalInvoice invoice = new RentalInvoice(customer);

			CheckoutScreen screen = new CheckoutScreen();

			screen.ShowRentalInvoice(invoice);
		}
	}
}