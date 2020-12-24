namespace Test1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBconnect : DbContext
    {
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DBconnect()
            : base("name=DBconnect")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
