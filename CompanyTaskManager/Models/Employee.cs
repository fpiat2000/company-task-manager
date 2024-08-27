using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PolcarZadanie.Models
{
    public class Employee
    {
        [Key]
        public long Id { get; set; }

        [Required, MaxLength(29)]
        public string FirstName { get; set; }

        [Required, MaxLength(29)]
        public string LastName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string? PhoneNumber { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? HireDate { get; set; }

        public string? JobTitle { get; set; }

        [JsonIgnore]
        public Manager? Manager { get; set; }

        [JsonIgnore]
        public List<WorkTask> TaskList { get; set; } = new List<WorkTask>();
    }
}
