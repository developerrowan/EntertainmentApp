using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using EntertainmentApp.Models;
namespace EntertainmentApp.Helpers;
public class DataContext : DbContext
{
    private readonly IConfiguration _configuration;
    public DataContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite(_configuration.GetConnectionString("EntertainmentDatabase"));
    }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<TvShow> TvShows { get; set; }
}
