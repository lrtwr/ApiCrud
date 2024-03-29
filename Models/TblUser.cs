﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiCrud.Models
{
    public partial class TblUser
    {
        [Key]
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
        public byte[] Salt { get; set; }
    }
}
