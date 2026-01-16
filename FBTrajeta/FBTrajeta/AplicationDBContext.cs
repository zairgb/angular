using FBTrajeta.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FBTrajeta
{
    public class AplicationDBContext : DbContext
    {
        public DbSet<TrajetaCredito> TrajetaCredito { get; set; }

        public AplicationDBContext(DbContextOptions<AplicationDBContext> options): base(options)  
        {
        }
    }
}
