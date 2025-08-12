//not solved

TreeNode root = new TreeNode(1);
TreeNode left = new TreeNode(2);
TreeNode right = new TreeNode(3);
TreeNode leftleft = new TreeNode(4);
TreeNode leftRight = new TreeNode(5);
left.left = leftleft;
left.right = leftRight;
root.left = left;
root.right = right;

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

public class Solution
{
    public TreeNode LcaDeepestLeaves(TreeNode root)
    {

    }

    public TreeNode DeepestParent(TreeNode root, TreeNode deepNode, int depth, int deepDepth)
    {
        
    }
}