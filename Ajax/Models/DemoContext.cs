﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ajax.Models
{
    public class DemoContext : DbContext
    {
        public DbSet<Demo> Demos { get; set; }
    }
}