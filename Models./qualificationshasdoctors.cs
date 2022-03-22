using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookAMedic.Models

{ [Table("qualifications_has_doctors")]

    public class qualifications_has_doctors
    {
        [Key]
        [Required]
        [Column("doctor_qualifications_id")]

        public int doctor_qualifications_Id { get; set; }

        [Key]
        [Required]
        [Column("qualifications_qualifications_id")]

        public int qualifications_qualifications_Id { get; set; }

        [Required]
        [Column("doctors_doctors_id")]

        public int Doctors_Doctors_Id { get; set; }

    









    }



}
