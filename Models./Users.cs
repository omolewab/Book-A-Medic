using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneBvia.Models
{
    [Table("users")]
    public class Users
    {
        [Key]
        [Required]
        [Column("user_id")]
        public int UserId { get; set; }
        [Required]
        [Column("last_name")]
        public string LastName { get; set; }
        [Required]
        [Column("first_name")]
        public string FirstName { get; set; }
        [Required]
        [Column("email_address")]
        public string EmailId { get; set; }
        [Required]
        [Column("password")]
        public string Password { get; set; }
        [Required]
        [Column("phone_number")]
        public string PhoneNumber { get; set; }

        [Required]
        [Column("is_deleted")]
        public bool IsDeleted { get; set; }

        [Required]
        [Column("is_blacklisted")]
        public bool IsBlacklisted { get; set; }

        [Required]
        [Column("is_active")]
        public bool IsActive { get; set; }

        [Required]
        [Column("created_date")]
        public DateTime CreatedDate { get; set; }
    }
}
