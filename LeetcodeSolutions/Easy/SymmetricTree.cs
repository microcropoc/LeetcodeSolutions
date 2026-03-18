using LeetCodeTests.Common;

namespace LeetCodeTests.Easy;

public class SymmetricTree
{
    [Fact]
    public void Test1()
    {
    }


    public bool IsSymmetric(TreeNode root)
    {
        bool D(TreeNode n1, TreeNode n2)
        {
            if (n1 is null && n2 is null)
                return true;

            if (n1 is null || n2 is null)
                return false;

            if (n1.val != n2.val)
                return false;

            return D(n1.left, n2.right) && D(n1.right, n2.left);
        }

        return D(root, root);
    }
}
