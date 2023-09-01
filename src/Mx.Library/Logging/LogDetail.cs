using System;
using System.Collections.Generic;

namespace Mx.Library.Logging
{
    public class LogDetail
    {


        public LogDetail()
        {
            TimeStamp = DateTime.Now;
            AdditionalInfo = new Dictionary<string, object>();
            EventType = "DefaultLogEvent";
        }

        public DateTime TimeStamp { get; private set; }

        public string Message { get; set; }

        public string Layer { get; set; }

        public string Location { get; set; }
        public string Hostname { get; set; }
        public string Application { get; set; }

        public string UserId { get; set; }

        public long? ElapsedMilliseconds { get; set; }

        public Exception Exception { get; set; }

        public string CorrelationId { get; set; }
        public string EventType { get; set; }
        public Dictionary<string, object> AdditionalInfo { get; set; }
    }

}