using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exam.Models
{
    public class examdbcontext:DbContext
    {
        public examdbcontext(DbContextOptions options):base(options)
        {

        }

        public DbSet<exammodel> examdb { get; set; }
    }
}
