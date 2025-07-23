﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Models
{
    public class User
    {
        public string? UserID { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? FullName { get; set; }
        public string? RoleID { get; set; }
        public bool IsActive { get; set; }
    }
}
