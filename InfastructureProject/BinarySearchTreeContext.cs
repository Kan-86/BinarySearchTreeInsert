using BinaryTree.EntitiesProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public DbSet<Node> Node { get; set; }
        public DbSet<Tree> Tree { get; set; }
    }
}
