﻿using Microsoft.EntityFrameworkCore;
using MVC_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CRUD.DataContext
{
    public class CRUDDBContext : DbContext
    {
        public CRUDDBContext(DbContextOptions options) : base(options)
        { 
        
        }

        public DbSet<User> Users { get; set; }

    }
}
