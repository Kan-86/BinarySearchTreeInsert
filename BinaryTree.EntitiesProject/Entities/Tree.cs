using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BinaryTree.EntitiesProject.Entities
{
    public class Tree
    {
        public int TreeId { get; set; }
        [ForeignKey("RightId")]
        public Tree Right { get; set; }
        [ForeignKey("LeftId")]
        public Tree Left { get; set; }
        public int Value { get; set; }
    }

}