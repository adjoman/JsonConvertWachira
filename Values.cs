using System;

namespace Wachira.Classes
{
    public class Values
    {
        public int ID { get; set; }
        public string Self { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CompleteDate { get; set; }
        //    public IList<DateTime> DaysWithinSprint { get; }
        public int OriginBoardId { get; set; }
    }
}