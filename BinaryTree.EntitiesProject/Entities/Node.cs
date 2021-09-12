using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.EntitiesProject.Entities
{
    public class Node
    {
        [Required]
        public int Value { get; set; }
        [Required]
        public Tree Tree { get; set; }

    }
}
