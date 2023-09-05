


namespace VueAPI.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)  :base(options)               
        {
         
    } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=VueAppDb;Trusted_Connection=True;TrustServerCertificate=True;");
            //Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
