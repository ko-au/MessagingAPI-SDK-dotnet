namespace com.telstra.messaging.Models.Messages
{
    public static class MessageStatus
    {
        public const string QUEUED = "queue";
        public const string DELIVERED = "delivered";
        public const string EXPIRED = "expired";
        public const string UNDELIVERED = "undeliverable";
    }
}