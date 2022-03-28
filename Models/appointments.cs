﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookAMedic.Models

{ [Table("appointments")]

    public class appointments
    {
        internal readonly object status;

        [Key]
        [Required]
        [Column("appointments_id")]

        public int Appointments_Id { get; set; }

        [Required]
        [Column("doctors_id")]

        public int Doctor_Id { get; set; }

        [Required]
        [Column("patients_id")]

        public int Patients_Id { get; set; }


        [Required]
        [Column("date")]

        public DateTime Date { get; set; }


        [Required]
        [Column("time")]

        public TimeSpan Time { get; set; }

        [Required]
        [Column("status")]

        public int Status { get; set; }











    }



}
