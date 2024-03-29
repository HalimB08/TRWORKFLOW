﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRWORKFLOW.Entities.Concrete
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Mail { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Gender { get; set; }
        public int Authority { get; set; }
        public bool IsActive { get; set; }
    }
}
