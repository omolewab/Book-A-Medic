using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookAMedic.Models

{ [Table("availabilities")]

    public class availabilities
    {
        [Key]
        [Required]
        [Column("availabilities_id")]

        public int Availabilities_Id { get; set; }

        [Required]
        [Column("start_time")]

        public DateTime Start_Time { get; set; }

        [Required]
        [Column("end_time")]

        public DateTime End_Time { get; set; }

        [Required]
        [Column("date")]

        public DateTime Date { get; set; }










    }



}
