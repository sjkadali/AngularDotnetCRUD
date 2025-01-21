using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmployeeAPI.Models
{
    public class EmployeeDetail
    {
        [Key]
        public int EmployeeDetailId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string EmployeeName { get; set; } = "";

        [Column(TypeName = "nvarchar(25)")]
        public string EmployeeEmail { get; set; } = "";

        [Column(TypeName = "nvarchar(16)")]
        public string Department { get; set; } = "";

        [Column(TypeName = "nvarchar(16)")]
        public string EmployeeRole { get; set; } = "";

        //mm/yy
        [Column(TypeName = "nvarchar(5)")]
        public string JoiningDate { get; set; } = "";
    }
}
