using System.ComponentModel.DataAnnotations;

namespace PolcarZadanie.Models
{
    public class Manager: Employee
    {
        [MaxLength(999)]
        public List<Employee> Team { get; set; }
    }
}
