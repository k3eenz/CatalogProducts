﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogProd.DataBase
{
    internal class Users
    {
        [Key]
        public int UserID { get; set; }
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
