﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2Crud.Models
{
    public class CategoryDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set;}

    }
}