using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Nhom_02.Models;

namespace Nhom_02.Data
{
    public class Nhom2Context : DbContext
    {
        public DbSet<Account>Accounts { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Image> Images { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }

    }
}
