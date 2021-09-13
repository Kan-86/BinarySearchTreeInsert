using System.Collections.Generic;

namespace BinaryTree.EntitiesProject.Entities
{
    public class Tree
    {
        public int TreeId { get; set; }
        public Tree Right { get; set; }
        public Tree Left { get; set; }
        public int Value { get; set; }
    }
}