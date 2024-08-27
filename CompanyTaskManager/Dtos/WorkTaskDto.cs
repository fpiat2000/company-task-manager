using System.ComponentModel.DataAnnotations;

namespace PolcarZadanie.Dtos
{
    public class WorkTaskDto
    {
        [Required, MinLength(3), MaxLength(100)]
        public string Header { get; set; }

        [Required, Range(1, 100)]
        public int Priority { get; set; }

        [Required, MinLength(3), MaxLength(32767)]
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public EmployeeDto? AssignedEmployee { get; set; }
    }
}
