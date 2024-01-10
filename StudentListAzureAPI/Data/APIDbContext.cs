using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentListAzureAPI.Models;

    public class APIDbContext : DbContext
    {
        public APIDbContext (DbContextOptions<APIDbContext> options)
            : base(options)
        {
        }

        public DbSet<StudentListAzureAPI.Models.Student> Student { get; set; } = default!;
    }
