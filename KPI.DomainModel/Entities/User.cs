using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPI.DomainModel.Entities
{
    [Table("User")]
    public class User
    {
        public User()
        {
            this.IsActived = true;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int UserId { get; set; }

        [Column(TypeName="nvarchar")]
        [StringLength(100)]
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        public bool IsActived { get; set; }

        [Required]
        public int ProfileId { get; set; }

        [ForeignKey("ProfileId")]
        public Profile Profile { get; set; }
    }
}
