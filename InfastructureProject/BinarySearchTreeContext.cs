using BinaryTree.EntitiesProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace InfastructureProject
{
    public class BinarySearchTreeContext : DbContext
    {
        public BinarySearchTreeContext(DbContextOptions<BinarySearchTreeContext> opt) : base(opt)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Overrides the modelbuilder
            base.OnModelCreating(modelBuilder);

            //Many to many Menu-Ingredients
            modelBuilder.Entity<Tree>()
                .HasKey(a => new {
                    a.TreeId
                });
            modelBuilder.Entity<Tree>()
                .HasOne(a => a.Left);
            modelBuilder.Entity<Tree>()
                .HasOne(a => a.Left);
        }
        public DbSet<Tree> Tree { get; set; }
    }
}
