using BinaryTree.CoreProject.DomainServices;
using BinaryTree.EntitiesProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfastructureProject.Repositories
{
    public class BSTRepository : IBSTRepository
    {
        private readonly BinarySearchTreeContext _ctx;

        public BSTRepository(BinarySearchTreeContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Tree> GetAllBinarySearchTrees()
        {


            return _ctx.Tree;
        }

        public Tree InsertValueIntoBinarySearchTree(Tree treeNode)
        {
            _ctx.Attach(treeNode).State = EntityState.Added;
            _ctx.SaveChanges();
            return treeNode;
        }
    }
}
