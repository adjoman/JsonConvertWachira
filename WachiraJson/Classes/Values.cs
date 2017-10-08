using System;
using Newtonsoft.Json;

namespace Wachira.Classes
{
    public class Values
    {
        [JsonProperty]
        public int ID { get; set; }

        [JsonProperty]
        public string Self { get; set; }

        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        public string State { get; set; }

        [JsonProperty]
        public DateTime StartDate { get; set; }

        [JsonProperty]
        public DateTime EndDate { get; set; }

        [JsonProperty]
        public DateTime CompleteDate { get; set; }

        [JsonProperty]
        public int OriginBoardId { get; set; }
    }
}