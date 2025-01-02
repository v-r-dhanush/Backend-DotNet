﻿using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MyDemoApp.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options) { }
        public DbSet<Information> Information { get; set; }
    }
}