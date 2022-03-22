using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CapstoneBvia.Models

{ [Table("address")]

    public class address
    {
        [Key]
        [Required]
        [Column("address_id")]

        public int Address_Id { get; set; }

        [Required]
        [Column("address_line1")]

        public String Address_Line1 { get; set; }

        [Required]
        [Column("address_line2")]

        public String Address_Line2 { get; set; }


        [Required]
        [Column("province")]

        public String Province { get; set; }


        [Required]
        [Column("city")]

        public String City { get; set; }


        [Required]
        [Column("zip")]

        public String Zip { get; set; }


        [Required]
        [Column("phone_number")]

        public String Phone_Number { get; set; }


        [Required]
        [Column("is_doctor")]

        public int Is_Doctor { get; set; }


    }



}
