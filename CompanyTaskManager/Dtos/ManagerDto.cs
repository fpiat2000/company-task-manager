using System.ComponentModel.DataAnnotations;

namespace PolcarZadanie.Dtos
{
    public class ManagerDto: EmployeeDto
    {
        [Required, MaxLength(999)]
        public List<EmployeeDto> Team { get; set; }
    }
}
