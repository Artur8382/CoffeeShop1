using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CoffeeShop1
{
    public class CoffeeShopDbContextFactory : IDesignTimeDbContextFactory<CoffeeShopDbContext>
    {
        public CoffeeShopDbContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<CoffeeShopDbContext>()
                .UseSqlServer("Server=localhost;Database=CoffeeShop;Trusted_Connection=True;TrustServerCertificate=True;")
                .Options;

            return new CoffeeShopDbContext(options);
        }
    }
}
