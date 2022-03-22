using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CapstoneBvia.Models

{ [Table("departments")]

    public class departments
    {
        [Key]
        [Required]
        [Column("departments_id")]

        public int Departments_Id { get; set; }

        [Required]
        [Column("name")]

        public String Name { get; set; }

    









    }



}
