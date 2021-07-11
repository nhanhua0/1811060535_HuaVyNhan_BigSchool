﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _1811060535_HuaVyNhan_BigSchool.Models
{
    public class Course
    {
        public int Id { get; set; }

        public bool IsCanceled { get; set; }
        public ApplicationUser Lecturer { get; set; }
        [Required]
        public string LecturerId { get; set; }
        [Required]
        [StringLength(255)]
        public string Place { get; set; }


        public DateTime DataTime { get; set; }




        public Category Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }
    }
}