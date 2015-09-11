using System;
namespace UserDefinedExceptionApplication
{
	public class TempIsZeroException : ApplicationException
	{
		public TempIsZeroException(string message)
			: base(message)
		{
		}
	}
}
