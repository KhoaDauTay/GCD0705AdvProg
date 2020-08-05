using System.Collections.Generic;

namespace ClassDiagram
{
	internal class Book
	{
		private List<Page> Pages;

		public Book(int page)
		{
			Pages = new List<Page>();

			for (int i = 0; i < page; i++)
			{
				Pages.Add(new Page());
			}
		}
	}
}