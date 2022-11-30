using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Nhom_02.Models;

namespace Nhom_02.Data
{
    public class Nhom2Context : DbContext
    {
        public DbSet<Accounts>Accounts { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Colors> Colors { get; set; }
        public DbSet<Images> Images { get; set; }

        public DbSet<Invoices> Invoices { get; set; }

        public DbSet<InvoiceDetail> invoiceDetails { get; set; }

        public DbSet<Products> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }

    }
}
