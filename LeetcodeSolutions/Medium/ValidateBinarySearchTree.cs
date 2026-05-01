using LeetCodeTests.Common;

namespace LeetCodeTests.Medium;

public class ValidateBinarySearchTree
{
    [Fact]
    public void Test1()
    {

    }

    //O(n) O(h) 
    public bool IsValidBST(TreeNode root)
    {

        bool Validate(TreeNode root, long min, long max)
        {
            if (root == null)
                return true;

            if (root.val <= min || root.val >= max)
                return false;

            return Validate(root.left, min, root.val) && Validate(root.right, root.val, max);
        }

        return Validate(root.left, long.MinValue, root.val) && Validate(root.right, root.val, long.MaxValue);
    }
}
