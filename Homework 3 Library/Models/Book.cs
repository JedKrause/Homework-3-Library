﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Homework_3_Library.Models
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookID { get; set; }
        [StringLength(50)]
        [Required]
        public string Title { get; set; }
        [StringLength(50)]
        [Required]
        public string Genre { get; set; }

        public ICollection<Rental> Rentals { get; set; }
    }
}
