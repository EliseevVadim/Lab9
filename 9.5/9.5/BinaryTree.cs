using System;
using System.Collections.Generic;
using System.Text;

namespace _9._5
{
    public class BinaryTreeNode
    {
        public Game data;
        public BinaryTreeNode left = null;
        public BinaryTreeNode right = null;
    }
    public class BinaryTree
    {
        BinaryTreeNode root = new BinaryTreeNode();
        public BinaryTreeNode AddRoot(Game val)
        {
            root = new BinaryTreeNode { data = val };
            return root;
        }
        public BinaryTreeNode AddLeft(BinaryTreeNode node, Game val)
        {
            var newnode = new BinaryTreeNode { data = val };
            node.left = newnode;
            return newnode;
        }
        public BinaryTreeNode AddRight (BinaryTreeNode node, Game val)
        {
            var newnode = new BinaryTreeNode { data = val };
            node.right = newnode;
            return newnode;
        }
        public void PreOrder(BinaryTreeNode node, int indent=0)
        {
            if (node != null)
            {
                for (int i = 0; i < indent; i++) Console.Write(" ");
                Console.WriteLine($"{node.data.team1} - {node.data.team2} : {node.data.score1} - {node.data.score2}");
                PreOrder(node.left, indent + 1);
                PreOrder(node.right, indent + 1);
            }
        }
        public void PreOrderTraversal()
        {
            PreOrder(root);
        }
        
    }
}
