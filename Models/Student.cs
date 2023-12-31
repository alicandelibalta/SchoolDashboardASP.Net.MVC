﻿using System.ComponentModel.DataAnnotations;

namespace SchoolDashboardMVC.Models
{
    public class Student : BaseModel
    {
        [Required, Range(10,15) ]
        public string StudentNumber { get; set; }

        [Range(11,11)]
        public string TcNumber { get; set; }

        [MaxLength(3)]
        public string Nationality { get; set; }

        [MaxLength(30)]
        public string Address { get; set; }

        [MaxLength(13)]
        public string PhoneNumber { get; set; }

        public StudentClass StudentClass { get; set; }

        //github deneme propu
        public int MyProperty1 { get; set; }

        //blabla yeni commit için deneme
        public int MyProperty2 { get; set; }

        //productentity için branch denemesi
        public int MyProperty3 { get; set; }
    }
}
