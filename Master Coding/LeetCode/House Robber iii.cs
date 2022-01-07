using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
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
    public class House_Robber_iii
    {
        public static int Rob(TreeNode root)
        {
            List<TreeNode> listRoot = new List<TreeNode>();
            listRoot.Add(root);
            for (var i = 0; i < listRoot.Count; i++)
            {
                if (listRoot[i].left == null && root.right == null)
                {
                    break;
                }
                listRoot.Add(listRoot[i].left);
                listRoot.Add(listRoot[i].right);

                if (listRoot[i].left != null)
                {

                }
                if (listRoot[i].right != null)
                {

                }


            }

            return 0;

        }
    }
}
