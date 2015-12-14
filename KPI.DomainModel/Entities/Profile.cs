using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPI.DomainModel.Entities
{
    [Table("Profile")]
    public class Profile
    {
        public Profile()
        {
            Users = new HashSet<User>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int ProfileId { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        [Required]
        public string Name { get; set; }
        public bool IsActived { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
