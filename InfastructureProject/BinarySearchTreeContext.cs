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

        }
        public DbSet<Tree> Tree { get; set; }
    }
}
