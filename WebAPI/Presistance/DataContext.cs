using Microsoft.EntityFrameworkCore;

namespace Presistance;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
}