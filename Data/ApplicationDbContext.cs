#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UongHoangAnh2022033.Models;
namespace UongHoangAnh2022033.Data{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<UongHoangAnh2022033.Models.PersonUHA2022033> PersonUHA2022033 { get; set; }
    }
}
    
