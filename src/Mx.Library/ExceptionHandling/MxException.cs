using System;

namespace Mx.Library.ExceptionHandling
{

	[Serializable]
	public abstract class MxException : ApplicationException
	{
		protected MxException() : base() { }

		protected MxException(string message) : base(message) { }

		protected MxException(string message, System.Exception innerException) : base(message, innerException) { }

		protected MxException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
		
		public abstract int Status { get; }
	}
}
