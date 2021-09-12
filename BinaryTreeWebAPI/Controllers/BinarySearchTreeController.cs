using BinaryTree.CoreProject.BinaryTree.Core.ApplicationServices;
using BinaryTree.EntitiesProject;
using BinaryTree.EntitiesProject.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinaryTreeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BinarySearchTreeController : ControllerBase
    {
        private readonly ILogger<BinarySearchTreeController> _logger;
        private readonly INodeServices _nodeServices;
        public BinarySearchTreeController(ILogger<BinarySearchTreeController> logger,
            INodeServices nodeServices)
        {
            _logger = logger;
            _nodeServices = nodeServices;
        }

        [HttpPost]
        public ActionResult<Tree> Get(Node node)
        {
            try
            {
                var bst = _nodeServices.InsertValueIntoBinarySearchTree(node.Tree, node.Value);
                return bst;
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
