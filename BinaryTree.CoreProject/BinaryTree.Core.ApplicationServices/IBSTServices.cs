
using BinaryTree.EntitiesProject.Entities;
using System.Collections.Generic;

namespace BinaryTree.CoreProject.BinaryTree.Core.ApplicationServices
{
    public interface IBSTServices
    {
        Tree InsertValueIntoBinarySearchTree(Tree node, int value);
        IEnumerable<Tree> GetAllBinarySearchTrees();
    }
}
