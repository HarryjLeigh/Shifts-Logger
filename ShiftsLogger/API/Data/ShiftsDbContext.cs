using Microsoft.EntityFrameworkCore;
using ShiftsLogger.API.Models;

namespace ShiftsLogger.API.Data;

public class ShiftsDbContext(DbContextOptions<ShiftsDbContext> options) : DbContext(options)
{
    public DbSet<Shift> Shifts { get; set; }
}