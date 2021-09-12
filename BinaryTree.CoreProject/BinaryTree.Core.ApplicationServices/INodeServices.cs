
using BinaryTree.EntitiesProject.Entities;

namespace BinaryTree.CoreProject.BinaryTree.Core.ApplicationServices
{
    public interface INodeServices
    {
        Tree InsertValueIntoBinarySearchTree(Tree node, int value);
    }
}
