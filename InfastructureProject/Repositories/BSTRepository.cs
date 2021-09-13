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
            var query = _ctx.Set<Tree>();

            return _ctx.Tree
                .Include(c => c.Left).
                ThenInclude(x => x.Left)
                .Include(c => c.Right)
                .ThenInclude(c => c.Right);
        }

        public Tree InsertValueIntoBinarySearchTree(Tree node, int value)
        {
            throw new NotImplementedException();
        }
    }
}
