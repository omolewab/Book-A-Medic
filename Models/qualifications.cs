using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookAMedic.Models

{ [Table("qualifications")]

    public class qualifications
    {
        [Key]
        [Required]
        [Column("qualifications_id")]

        public int qualifications_Id { get; set; }

        [Required]
        [Column("name")]

        public String Name { get; set; }

    









    }



}
