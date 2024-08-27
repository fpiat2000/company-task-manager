using System.ComponentModel.DataAnnotations;

namespace PolcarZadanie.Dtos
{
    public class EmployeeDto
    {
        [MaxLength(29)]
        public string FirstName { get; set; }

        [MaxLength(29)]
        public string LastName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }
    }
}
