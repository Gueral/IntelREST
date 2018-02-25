using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IntelREST.Models
{
    public class SQLiteContext : DbContext
    {
        public SQLiteContext (DbContextOptions<SQLiteContext> options)
            : base(options)
        {
        }

        public DbSet<IntelREST.Models.User> Users { get; set; }
    }
}
