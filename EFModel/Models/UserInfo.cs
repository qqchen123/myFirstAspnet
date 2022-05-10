using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EFModel
{
    public partial class UserInfo : DbContext
    {
        public UserInfo()
            : base("name=UserInfo")
        {
        }

        public virtual DbSet<student> student { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<student>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.address)
                .IsUnicode(false);
        }
    }
}
