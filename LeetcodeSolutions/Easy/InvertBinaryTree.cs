using LeetCodeTests.Common;

namespace LeetCodeTests.Easy;

public class InvertBinaryTree
{
    [Fact]
    public void Test1()
    {
    }


    public TreeNode InvertTree(TreeNode root)
    {
        if (root is null)
            return root!;

        var l = root.left;

        root.left = root.right;
        root.right = l;

        InvertTree(root.left);
        InvertTree(root.right);

        return root;
    }
}
