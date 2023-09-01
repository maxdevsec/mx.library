namespace Mx.Library.ExceptionHandling
{
    public class MxReferentialIntegrityException : MxException
    {
        public MxReferentialIntegrityException() : base() { }

        public MxReferentialIntegrityException(string message) : base(message) { }

        public MxReferentialIntegrityException(string message, System.Exception innerException) : base(message, innerException) { }

        protected MxReferentialIntegrityException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

        public override int Status => 400;
    }
}