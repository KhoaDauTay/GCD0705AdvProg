using System.Collections.Generic;

namespace VideoStore
{
	internal class Customer
	{
	}

	internal class RentalInvoice
	{
		private Customer Customer;
		private List<RentalItem> RentalItems;

		public RentalInvoice(Customer customer)
		{
			Customer = customer;
			RentalItems = new List<RentalItem>();
		}

		public void AddRentalItem(RentalItem item)
		{
			RentalItems.Add(item);
		}
	}

	class CheckoutScreen
	{
		void ShowRentalInvoice(RentalInvoice invoice)
		{

		}
	}

	internal abstract class RentalItem
	{
	}

	internal class DVD : RentalItem
	{
	}

	internal class VHS : RentalItem
	{
	}

	internal class Game : RentalItem
	{
	}
}