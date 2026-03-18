using LeetCodeTests.Common;

namespace LeetCodeTests.Easy;

public class MaximumDepthOfBinaryTree
{
    [Fact]
    public void Test1()
    {
        var treeNode1 = new TreeNode(3);
        var treeNode2 = new TreeNode(9);
        var treeNode3 = new TreeNode(20);
        var treeNode4 = new TreeNode(15);
        var treeNode5 = new TreeNode(7);

        treeNode1.left = treeNode2;
        treeNode1.right = treeNode3;

        treeNode3.left = treeNode4;
        treeNode3.right = treeNode5;


        Assert.Equal(3, MaxDepth(treeNode1));
    }


    public int MaxDepth(TreeNode root)
    {
        if(root is null)
            return 0;

        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
}
