using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookAMedic.Models

{ [Table("privacy_policy")]

    public class privacy_policy
    {
        [Key]
        [Required]
        [Column("policy_id")]

        public int Policy_Id { get; set; }

        [Required]
        [Column("policies")]

        public String Policies { get; set; }

    









    }



}
