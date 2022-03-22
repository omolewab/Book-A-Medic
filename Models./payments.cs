using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookAMedic.Models

{ [Table("payments")]

    public class payments
    {
        [Key]
        [Required]
        [Column("payment_id")]

        public int Payment_Id { get; set; }

        [Required]
        [Column("amount")]

        public Double Amount { get; set; }

        [Required]
        [Column("payment_type")]

        public String Payment_Type { get; set; }

        [Required]
        [Column("payment_status")]

        public String Payment_Status { get; set; }

        [Required]
        [Column("patients_id")]

        public int patients_Id { get; set; }





    }



}
