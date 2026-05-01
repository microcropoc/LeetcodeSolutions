using LeetCodeTests.Common;

namespace LeetCodeTests.Medium;

public class BinaryTreeLevelOrderTraversal
{
    [Fact]
    public void Test1()
    {

    }

    //O(n)	O(n)
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        if (root == null) return [];

        var result = new List<IList<int>>();
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;
            var currentLevel = new List<int>();

            for (int i = 0; i < levelSize; i++)
            {
                var node = queue.Dequeue();
                currentLevel.Add(node.val);

                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }

            result.Add(currentLevel);
        }

        return result;
    }

    public IList<IList<int>> LevelOrderLQ(TreeNode root)
    {
        if (root == null)
            return [];

        void Enrich(Queue<TreeNode> q, IList<IList<int>> result)
        {
            var l = new List<int>();
            var q1 = new Queue<TreeNode>();

            while (q.Count > 0)
            {
                var n = q.Dequeue();
                l.Add(n.val);
                if (n.left != null) q1.Enqueue(n.left);
                if (n.right != null) q1.Enqueue(n.right);
            }

            result.Add(l);

            if (q1.Count > 0)
                Enrich(q1, result);
        }

        var result = new List<IList<int>>();
        Enrich(new Queue<TreeNode>([root]), result);
        return result;
    }
}
