using System.ComponentModel.DataAnnotations;

namespace MVCFirstApp.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public String City { get; set; }
        public String Email { get; set; }  
    }
}
