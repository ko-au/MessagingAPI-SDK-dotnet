using System;

namespace com.telstra.messaging.Utils
{
    public static class Helper
    {
        public static bool IsStringDigitsOnly(string stringValue)
        {
            foreach (var c in stringValue)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        public static bool IsValidUUID(string uuid)
        {
            return Guid.TryParse(uuid, out _);
        }
    }
}