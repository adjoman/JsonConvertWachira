using System;

namespace Wachira.Classes
{
    public class BoardSprint
    {
        //{"maxResults":50,"startAt":0,"isLast":false,"values":
        public int? maxResults { get; set; } = 10;
        public long? startAt { get; set; }
        public bool isLast { get; set; } = false;
        public IList<Values> values { get; set; }
    }
}
