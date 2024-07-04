using com.telstra.messaging.Models.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace com.telstra.messaging.Models.VirtualNumbers
{
    public class VirtualNumbersList
    {
        [JsonProperty("virtualNumbers")]
        public List<VirtualNumber> Numbers { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }

        public VirtualNumbersList()
        {
            Numbers = new List<VirtualNumber>();
            Paging = new Paging();
        }
    }
}