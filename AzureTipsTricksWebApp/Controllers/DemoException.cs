using System;
using System.Runtime.Serialization;

namespace AzureTipsTricksWebApp.Controllers
{
	[Serializable]
	internal class DemoException : Exception
	{
		public DemoException()
		{
		}

		public DemoException(string message) : base(message)
		{
		}

		public DemoException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected DemoException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}