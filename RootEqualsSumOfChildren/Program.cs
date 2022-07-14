using System;

namespace RootEqualsSumOfChildren
{
    class Program
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");
        //}
        public class Solution
        {

            static public TreeNode Addnode(int data)
            {
                TreeNode tmp = new TreeNode();
                tmp.val = data;
                tmp.left = null;
                tmp.right = null;
                return tmp;
            }


            static public bool CheckTree(TreeNode root)
            {

                if (root.val == Count(root.right , root.left))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            static public int Count(TreeNode left, TreeNode right)
            {
                //if (root == null)
                //{
                //    return 0;
                //}

                //return Count(root.left) + Count(root.right);
                //return root.left.val + root.right.val;
                return left.val + right.val;
            }

            static public void Main()
            {
                TreeNode root = null;

                root = Addnode(10);
                root.left = Addnode(4);
                root.right = Addnode(6);

                Console.WriteLine(CheckTree(root));


            }

        }
    }
}