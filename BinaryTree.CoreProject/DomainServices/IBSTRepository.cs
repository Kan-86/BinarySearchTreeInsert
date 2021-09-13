using BinaryTree.EntitiesProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.CoreProject.DomainServices
{
    public interface IBSTRepository
    {
        Tree InsertValueIntoBinarySearchTree(Tree node, int value);
        IEnumerable<Tree> GetAllBinarySearchTrees();
    }
}
