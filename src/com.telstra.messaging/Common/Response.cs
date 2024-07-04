namespace com.telstra.messaging.Common
{
    public class Response
    {
        public Response(string content, bool isSuccessStatusCode)
        {
            Content = content;
            IsSuccessStatusCode = isSuccessStatusCode;
        }

        public string Content { get; }
        public bool IsSuccessStatusCode { get; }
    }
}
