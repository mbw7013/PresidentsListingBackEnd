namespace CorcoranPresidentsBackEnd
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PresidentContext : DbContext
    {
        public PresidentContext()
            : base("name=PresidentContext")
        {
        }

        public virtual DbSet<President> Presidents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
