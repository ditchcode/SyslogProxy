namespace SyslogProxy.Messages
{
    public class SeqEventMessage
    {
        public string Timestamp { get; set; }

        public string Level { get; set; }

        public object Properties { get; set; }

        public string MessageTemplate { get; set; }
    }
}