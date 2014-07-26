using System;

namespace Lingo
{
	public class Predicate
	{
		internal bool Inverted { get; set; }

		protected void Test(bool result, string failureMessage, object expected, object actual)
		{
			if (!Inverted && !result)
			{
				var msg = ExpectingExceptionMessage(expected, actual, failureMessage);
				throw new ExpectationException(msg);
			}
			if (Inverted && result)
			{
				var msg = NotExpectingExceptionMessage(expected, actual, failureMessage);
				throw new ExpectationException(msg);
			}
		}

		private string ExpectingExceptionMessage(object expected, object actual, string msg)
		{
			return string.Format("Expected {0} to {1} {2}.", expected, msg, actual);
		}

		private string NotExpectingExceptionMessage(object expected, object actual, string msg)
		{
			return string.Format("Did not expect {0} to {1} {2}", expected, msg, actual);
		}
	}
}

