using System;

namespace ZadanieGUI
{
    public class WorkTask
    {
        public long Id { get; set; }
        public string Header { get; set; }
        public int Priority { get; set; }
        public string Description { get; set; }
        public DateTime? CreationDate { get; set; }
        public Employee AssignedEmployee { get; set; }
    }
}
