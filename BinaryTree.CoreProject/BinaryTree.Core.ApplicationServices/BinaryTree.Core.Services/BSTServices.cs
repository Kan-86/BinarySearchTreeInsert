using BinaryTree.CoreProject.DomainServices;
using BinaryTree.EntitiesProject;
using BinaryTree.EntitiesProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.CoreProject.BinaryTree.Core.ApplicationServices.BinaryTree.Core.Services
{
    public class BSTServices : IBSTServices
    {

        private readonly IBSTRepository _bstRepo;
        public BSTServices(IBSTRepository bstRepo)
        {
            _bstRepo = bstRepo;
        }

        // A utility function to create a new BST Node.  When we have found the tree node to insert the value.
        private Tree NewNode(int item)
        {
            Tree temp = new Tree();
            temp.Value = item;
            temp.Left = null;
            temp.Right = null;
            return temp;
        }

        public Tree InsertValueIntoBinarySearchTree(Tree node, int value)
        {
            if (value != 0)
            {
                var treeNode = BinarySearchTreeInOrder(node, value);
                return treeNode;
            }
            else
            {
                throw new ArgumentException("Your JSON payload is expected to at least contain two fields named `tree` and `value`");
            }
        }

        private Tree BinarySearchTreeInOrder(Tree node, int value)
        {
            // Boolean to make help to check if the node has a duplicate.
            var notNewNode = false;

            // If the node is empty we return a new one
            // This happens when we are at the bottom of the tree
            if (node == null)
            {
                node = NewNode(value);
                notNewNode = true;  // When a node has a newNode, the value and the node Value are same, here we make sure to check that's not the case
            }

            // Check if the value is smaller than parent node, 
            // we recur down the tree if it is.
            if (node.Value > value)
            {
                Tree leftChild = BinarySearchTreeInOrder(node.Left, value);
                node.Left = leftChild;
            }
            else if (node.Value < value)
            {
                Tree rightChild = BinarySearchTreeInOrder(node.Right, value);
                node.Right = rightChild;
            }
            else if (node.Value == value && !notNewNode)
            {
                throw new ArgumentException("The inserted value has a duplicate inside the tree, value provided must be unique.");
            }
            return node;
        }

        public IEnumerable<Tree> GetAllBinarySearchTrees()
        {
            return _bstRepo.GetAllBinarySearchTrees();
        }
    }
}
