using BinaryTree.CoreProject.BinaryTree.Core.ApplicationServices;
using BinaryTree.CoreProject.BinaryTree.Core.ApplicationServices.BinaryTree.Core.Services;
using BinaryTree.CoreProject.DomainServices;
using BinaryTree.EntitiesProject.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BinarySearchTreeInsertUnitTest
{
    [TestClass]
    public class InsertValueIntoBinarySearchTree
    {
        private readonly IBSTServices _nodeService;
        private readonly IBSTRepository _bstRepository;
        public InsertValueIntoBinarySearchTree()
        {
            _nodeService = new BSTServices(_bstRepository);
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Create_BinarySearchTree_With_No_Value_And_No_Tree()
        {
            int value = 0;
            var node = new Node()
            {
                Tree =
                {
                }
            };
            Exception ex = Assert.ThrowsException<ArgumentException>(() =>
               _nodeService.InsertValueIntoBinarySearchTree(node.Tree, value));
            Assert.AreEqual("Your JSON payload is expected to at least contain two fields named `tree` and `value`", ex.Message);
        }

        [TestMethod]
        public void Create_BinarySearchTree_With_Duplicated_Value_Inside_The_BST()
        {
            int value = 3;
            var node = new Tree()
            {
                Value = 3
            };
            Exception ex = Assert.ThrowsException<ArgumentException>(() =>
               _nodeService.InsertValueIntoBinarySearchTree(node, value));
            Assert.AreEqual("The inserted value has a duplicate inside the tree, value provided must be unique.", ex.Message);
        }
    }
}
