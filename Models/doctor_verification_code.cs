using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CapstoneBvia.Models

{ [Table("doctor_verification_code")]

    public class doctor_verification_code
    {
        [Key]
        [Required]
        [Column("verification_id")]

        public int Verification_Id { get; set; }

        [Required]
        [Column("verification_code")]

        public String Verification_Code { get; set; }

    }



}
