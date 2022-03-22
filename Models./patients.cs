using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CapstoneBvia.Models

{ [Table("patients")]

    public class patients
    {
        [Key]
        [Required]
        [Column("patients_id")]

        public int Patients_Id { get; set; }

        [Required]
        [Column("first_name")]

        public String Firstname { get; set; }

        [Required]
        [Column("last_name")]

        public String Lastname { get; set; }


        [Required]
        [Column("email")]

        public String Email { get; set; }


        [Required]
        [Column("username")]

        public string Username { get; set; }

        [Required]
        [Column("password")]

        public String Password { get; set; }

        [Required]
        [Column("address_address_id")]

        public int  Address { get; set; }










    }



}
