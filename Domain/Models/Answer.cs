﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models
{
    public class Answer
    {
        public string Id { get; set; }
        [Required]
        public int User_Id { get; set; }
        [Required]
        public int GQ_Id { get; set; }
        [Required]
        public int Choice_Id { get; set; }
        public DateTime Updated_At { get; set; }
        [Required]
        public DateTime Created_At { get; set; }

    }
}
