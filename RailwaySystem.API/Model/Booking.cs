﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RailwaySystem.API.Model
{
    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookingId { get; set; }

        [ForeignKey("TrainId")]
        public int? TrainId { get; set; }


        [ForeignKey("QuotaId")]
        public int? QuotaId { get; set; }


        public string Classes { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "MM/DD/YYYY Format")]
        public DateTime Date { get; set; }


        public string Status { get; set; }
        public int SeatNum { get; set; }
        [Column(TypeName = "varchar(25)")]
        [MinLength(5, ErrorMessage = "Name can not be less than 5")]
        public string PName { get; set; }
        [Required(ErrorMessage = "Age can not be empty")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Gender can not be empty")]
        public string Gender { get; set; }
        public bool isActive { get; set; }
        public ICollection<Transaction> transactions { get; set; }
    }
}