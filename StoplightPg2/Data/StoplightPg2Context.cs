using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StoplightPg2.Models;

namespace StoplightPg2.Data
{
    public class StoplightPg2Context : DbContext
    {
        public StoplightPg2Context (DbContextOptions<StoplightPg2Context> options)
            : base(options)
        {
        }

        public DbSet<StoplightPg2.Models.User> User { get; set; }
    }
}
