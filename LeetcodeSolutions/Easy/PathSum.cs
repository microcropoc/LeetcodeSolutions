using LeetCodeTests.Common;

namespace LeetCodeTests.Easy;

public class PathSum
{
    [Fact]
    public void Test1()
    {
    }

    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root is null)
            return false;

        if (root.left is null && root.right is null)
            return root.val == targetSum;

        var r = targetSum - root.val;

        return HasPathSum(root.left, r) || HasPathSum(root.right, r);
    }
}
