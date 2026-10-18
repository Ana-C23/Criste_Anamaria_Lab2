using Microsoft.EntityFrameworkCore;

public class Criste_Anamaria_Lab2Context(DbContextOptions<Criste_Anamaria_Lab2Context> options) : DbContext(options)
{
    public DbSet<Criste_Anamaria_Lab2.Models.Book> Book { get; set; } = default!;
    public DbSet<Criste_Anamaria_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    public DbSet<Criste_Anamaria_Lab2.Models.Author> Author { get; set; } = default!;
}
