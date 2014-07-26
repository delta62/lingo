using System;

namespace Lingo
{
	public class ObjectExpectation
	{
		public ObjectPredicate To
		{
			get;
			private set;
		}

		internal ObjectExpectation(object expected)
		{
			To = new ObjectPredicate(expected);
		}
	}
}

