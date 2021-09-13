using BinaryTree.EntitiesProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfastructureProject
{
    public class DbInitializer
    {
        public DbInitializer()
        {

        }

        public static void SeedDb(BinarySearchTreeContext ctx)
        {


            List<Tree> tree = new List<Tree>
            {

                new  Tree{
                    Value = 10,
                    Left = new Tree
                    {
                        Value = 8
                    },
                    Right = new Tree
                    {
                        Value = 12
                    }
                },
                new Tree {
                    Value = 6,
                    Left = new Tree
                    {
                        Value = 4
                    },
                    Right = new Tree
                    {
                        Value = 8
                    }
                }
            };


            ctx.Tree.AddRange(tree);
            ctx.SaveChanges();
        }
    }
}
