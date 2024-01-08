using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RedMango_API.Models;

namespace RedMango_API.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<MenuItem> MenuItems{ get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                Id = 1,
                Name = "Spring Roll",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "https://firebasestorage.googleapis.com/v0/b/redmango-d7e87.appspot.com/o/redimage%2Fspring%20roll.jpg?alt=media&token=49c63c84-f6bc-4e2d-8bb8-3531690cd165",
                Price = 7.99,
                Category = "Appetizer",
                SpecialTag = ""
            }, new MenuItem
            {
                Id = 2,
                Name = "Idli",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "https://firebasestorage.googleapis.com/v0/b/redmango-d7e87.appspot.com/o/redimage%2Fidli.jpg?alt=media&token=d439be73-65d9-4e00-b79c-035df0a110c0",
                Price = 8.99,
                Category = "Appetizer",
                SpecialTag = ""
            }, new MenuItem
            {
                Id = 3,
                Name = "Panu Puri",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "https://firebasestorage.googleapis.com/v0/b/redmango-d7e87.appspot.com/o/redimage%2Fpani%20puri.jpg?alt=media&token=88fb5ad6-2c7f-42c6-8119-e7079dda64d5",
                Price = 8.99,
                Category = "Appetizer",
                SpecialTag = "Best Seller"
            }, new MenuItem
            {
                Id = 4,
                Name = "Hakka Noodles",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "https://firebasestorage.googleapis.com/v0/b/redmango-d7e87.appspot.com/o/redimage%2Fhakka%20noodles.jpg?alt=media&token=b8b39723-fe96-4fea-ac14-aa5b295e9bac",
                Price = 10.99,
                Category = "Entrée",
                SpecialTag = ""
            }, new MenuItem
            {
                Id = 5,
                Name = "Malai Kofta",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "https://firebasestorage.googleapis.com/v0/b/redmango-d7e87.appspot.com/o/redimage%2Fmalai%20kofta.jpg?alt=media&token=890079b1-7a71-40fa-8973-6fbf8e33ca79",
                Price = 12.99,
                Category = "Entrée",
                SpecialTag = "Top Rated"
            }, new MenuItem
            {
                Id = 6,
                Name = "Paneer Pizza",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "https://firebasestorage.googleapis.com/v0/b/redmango-d7e87.appspot.com/o/redimage%2Fpaneer%20pizza.jpg?alt=media&token=60c1eaf5-0356-4b83-976e-541d3e2c28a4",
                Price = 11.99,
                Category = "Entrée",
                SpecialTag = ""
            }, new MenuItem
            {
                Id = 7,
                Name = "Paneer Tikka",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "https://firebasestorage.googleapis.com/v0/b/redmango-d7e87.appspot.com/o/redimage%2Fpaneer%20tikka.jpg?alt=media&token=073c0cf0-8ae0-4032-bca0-c99bbc1e52d4",
                Price = 13.99,
                Category = "Entrée",
                SpecialTag = "Chef's Special"
            }, new MenuItem
            {
                Id = 8,
                Name = "Carrot Love",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "https://firebasestorage.googleapis.com/v0/b/redmango-d7e87.appspot.com/o/redimage%2Fcarrot%20love.jpg?alt=media&token=3bef6171-3526-4ba6-92ca-ddf09705f0ab",
                Price = 4.99,
                Category = "Dessert",
                SpecialTag = ""
            }, new MenuItem
            {
                Id = 9,
                Name = "Rasmalai",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "https://firebasestorage.googleapis.com/v0/b/redmango-d7e87.appspot.com/o/redimage%2Frasmalai.jpg?alt=media&token=bf5b954a-faf5-416e-9204-ec14bfabfe33",
                Price = 4.99,
                Category = "Dessert",
                SpecialTag = "Chef's Special"
            }, new MenuItem
            {
                Id = 10,
                Name = "Sweet Rolls",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "https://firebasestorage.googleapis.com/v0/b/redmango-d7e87.appspot.com/o/redimage%2Fsweet%20rolls.jpg?alt=media&token=d4db7b67-ad11-494f-a28c-9028de42a73f",
                Price = 3.99,
                Category = "Dessert",
                SpecialTag = "Top Rated"
            });
        }
    }
}
