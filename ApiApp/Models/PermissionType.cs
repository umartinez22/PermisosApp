using System.ComponentModel.DataAnnotations.Schema;

namespace ApiApp.Models
{

    public class PermissionType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Description { get; set; }
    }
}