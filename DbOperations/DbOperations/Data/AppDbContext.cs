﻿using Microsoft.EntityFrameworkCore;

namespace DbOperations.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)  : base(options) 
        {
        }   
        public DbSet<Book> Books { get; set; }
        public DbSet<Language> Languages { get; set; }
    }
}
