using Microsoft.EntityFrameworkCore;

public class AdventureWorksDbContext(DbContextOptions<AdventureWorksDbContext> options) : DbContext(options)
{

    // Add DbSets for your tables
    public required DbSet<Product> Products { get; set; }
}

public class Product
{
    public int ProductID { get; set; }
    public string? Name { get; set; }
    public decimal ListPrice { get; set; }

    
}
