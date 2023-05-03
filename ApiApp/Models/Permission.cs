using System.ComponentModel.DataAnnotations.Schema;

namespace ApiApp.Models
{
    public class Permission
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public PermissionType UserPermission { get; set; }
    }
}

