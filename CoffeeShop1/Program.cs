using CoffeeShop1;
using Microsoft.EntityFrameworkCore;

var options = new DbContextOptionsBuilder<CoffeeShopDbContext>()
    .UseSqlServer("Server=localhost;Database=CoffeeShop;Trusted_Connection=True;TrustServerCertificate=True;")
    .Options;

using var context = new CoffeeShopDbContext(options);
