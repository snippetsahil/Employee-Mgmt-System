using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models.Domain
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public string Position { get; set; }
    }
}