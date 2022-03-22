using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CapstoneBvia.Models

{ [Table("history")]

    public class history
    {
        [Key]
        [Required]
        [Column("history_id")]

        public int History_Id { get; set; }

        [Required]
        [Column("prescription")]

        public String Prescription { get; set; }

        [Required]
        [Column("comments")]

        public String Comments { get; set; }


        [Required]
        [Column("next_visit")]

        public DateTime Next_Visit { get; set; }


        [Required]
        [Column("appointments_appointments_id")]

        public int Appointments_Appointments_Id { get; set; }






    }



}
