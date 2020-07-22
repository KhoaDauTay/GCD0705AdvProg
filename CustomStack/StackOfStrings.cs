using System.Collections.Generic;

namespace CustomStack
{
	internal class StackOfStrings : Stack<string>
	{
		public bool IsEmpty()
		{
			return Count == 0;
		}

		public Stack<string> AddRange()
		{
			// Not enough information to implement
			return null;
		}
	}
}