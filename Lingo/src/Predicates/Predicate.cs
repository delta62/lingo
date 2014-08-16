using System;

namespace Lingo
{
	public class Predicate
	{
		internal bool Inverted { get; set; }

		protected void Test(bool result, string failureMessage, object expected, object actual)
		{
            var expectedFmt = FormatArgument(expected);
            var actualFmt = FormatArgument(actual);

			if (!Inverted && !result)
			{
				var msg = ExpectingExceptionMessage(expectedFmt, actualFmt, failureMessage);
				throw new ExpectationException(msg);
			}
			if (Inverted && result)
			{
				var msg = NotExpectingExceptionMessage(expectedFmt, actualFmt, failureMessage);
				throw new ExpectationException(msg);
			}
		}

		private string ExpectingExceptionMessage(string expected, string actual, string msg)
		{
            return string.Format("Expected {0} to {1} {2}.", expected, msg, actual);
		}

		private string NotExpectingExceptionMessage(string expected, string actual, string msg)
		{
			return string.Format("Did not expect {0} to {1} {2}", expected, msg, actual);
		}

        private string FormatArgument(object arg)
        {
            if (arg == null)
            {
                return "null";
            }
            if (arg is string)
            {
                return string.Format(@"""{0}""", arg);
            }

            return arg.ToString();
        }
	}
}

