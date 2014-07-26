using System;
using System.Runtime.Serialization;

namespace Lingo
{
	[Serializable]
	public class ExpectationException : Exception
	{
		public ExpectationException() : base() { }

		public ExpectationException(string message) : base(message) { }

		public ExpectationException(string message, Exception innerException) : base(message, innerException) { }

		protected ExpectationException(SerializationInfo info, StreamingContext context) : base(info, context) { }
	}
}

