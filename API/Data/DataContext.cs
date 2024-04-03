using Microsoft.EntityFrameworkCore;
using API.Entities;
using System.ComponentModel.DataAnnotations.Schema;
namespace API.Data
{
    [Table("Photos")]
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<AppUser> Users { get; set; }
    }
} 