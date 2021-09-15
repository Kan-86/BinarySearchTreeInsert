using BinaryTree.EntitiesProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.CoreProject.DomainServices
{
    public interface IBSTRepository
    {
        IEnumerable<Tree> GetAllBinarySearchTrees();
        Tree InsertValueIntoBinarySearchTree(Tree treeNode);
    }
}
