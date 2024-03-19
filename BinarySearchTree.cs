using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class BinarySearchTree
    {
        public TreeNode root;

        public void Insert(int value)
        {
            root = InsertRec(root, value);
        }

        private TreeNode InsertRec(TreeNode root, int value)
        {
            if (root == null)
            {
                return new TreeNode(value);
            }

            if (value < root.val)
            {
                root.left = InsertRec(root.left, value);
            }
            else if (value > root.val)
            {
                root.right = InsertRec(root.right, value);
            }

            return root;
        }

        // In-order traversal to get sorted array
        public void InOrderTraversal(TreeNode root, List<int> sortedArray)
        {
            if (root != null)
            {
                InOrderTraversal(root.left, sortedArray);
                sortedArray.Add(root.val);
                InOrderTraversal(root.right, sortedArray);
            }
        }
    }
}

