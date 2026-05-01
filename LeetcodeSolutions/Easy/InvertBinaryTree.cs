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

        (root.left, root.right) = (root.right, root.left);

        InvertTree(root.left);
        InvertTree(root.right);

        return root;
    }
}
