using System;
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

		internal void ShowInfo()
		{
			throw new NotImplementedException();
		}
	}

	internal class CheckoutScreen
	{
		private void ShowRentalInvoice(RentalInvoice invoice)
		{
			if (invoice is null)
			{
				throw new System.ArgumentNullException(nameof(invoice));
			}

			invoice.ShowInfo();
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