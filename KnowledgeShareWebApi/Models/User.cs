﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnowledgeShareWebApi.Models
{
    public class User
    {
        public string Zid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}