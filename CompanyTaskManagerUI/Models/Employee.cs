using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ZadanieGUI
{
    public class Employee
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? HireDate { get; set; }
        public string JobTitle { get; set; }
        
        [JsonIgnore]
        public List<WorkTask> TaskList { get; set; } = new List<WorkTask>();

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
