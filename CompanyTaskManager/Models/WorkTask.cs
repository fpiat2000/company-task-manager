using System.ComponentModel.DataAnnotations;

namespace PolcarZadanie.Models
{
    public class WorkTask
    {
        [Key]
        public long Id { get; set; }

        [Required, MinLength(3), MaxLength(100)]
        public string Header { get; set; }

        [Required, Range(1, 100)]
        public int Priority { get; set; }

        [Required, MinLength(3), MaxLength(32767)]
        public string Description { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? CreationDate { get; set; }

        public Employee? AssignedEmployee { get; set; }

        public WorkTask()
        {
            Header = "";
            Priority = 100;
            Description = "";
            CreationDate = DateTime.Now;
        }

        public WorkTask(string header, int priority, string description = "", Employee? emp = null)
        {
            Header = header;
            Priority = priority;
            Description = description;
            AssignedEmployee = emp;
            CreationDate = DateTime.Now;
        }

        public override string ToString()
        {
            return Header + ": " + Description;
        }
    }
}
