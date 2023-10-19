using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dornea_Sergiu_Lab2.Models;

namespace Dornea_Sergiu_Lab2.Data
{
    public class Dornea_Sergiu_Lab2Context : DbContext
    {
        public Dornea_Sergiu_Lab2Context (DbContextOptions<Dornea_Sergiu_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Dornea_Sergiu_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Dornea_Sergiu_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Dornea_Sergiu_Lab2.Models.Author>? Author { get; set; }
    }
}
