//You are given two binary trees root1 and root2.
//Imagine that when you put one of them to cover the other, 
//some nodes of the two trees are overlapped while the others are not. 
//You need to merge the two trees into a new binary tree.

//The merge rule is that if two nodes overlap, then sum node values up as the new value of the merged node.
//Otherwise, the NOT null node will be used as the node of the new tree.
//Return the merged tree.
//Note: The merging process must start from the root nodes of both trees.


//Definition for a binary tree node.

// there are two way for it. one is using recursion another is using iterative method

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
    {
        var mergeTrees = MergeTrees(root1, root2);
        if (root1 == null)
        {
            return root2;
        }
        if (root2 == null)
        {
            return root1;
        }
        root1.val += root2.val;
        root1.left = MergeTrees(root1.left, root2.left);
        root1.right = MergeTrees(root1, root2);
        
        return root1;

    }
}



class Program
{
    static void Main(string[] args)
    {

    }
}