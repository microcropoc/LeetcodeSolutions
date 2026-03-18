namespace LeetCodeTests.Easy;

public class IntersectTwoArray
{
    [Fact]
    public void Test1()
    {
        //Arrange

        var nums1 = new int[] {1, 2, 2, 1};
        var nums2 = new int[] {2, 2};

        //Act

        var result = IntersectionHash(nums1, nums2);

        //Assert

        Assert.Equal([2], result);
    }


    public int[] Intersection(int[] nums1, int[] nums2)
    {
        return nums1.Intersect(nums2).ToArray();
    }

    //O(n+m) space O(n)
    public int[] IntersectionHash(int[] nums1, int[] nums2)
    {
        var result = new List<int>();

        if(nums1.Length >= nums2.Length)
        {
            var hash = new HashSet<int>(nums2);

            for (int i = 0; i < nums1.Length; i++)
            {
                if (hash.Contains(nums1[i]))
                {
                    result.Add(nums1[i]);
                    hash.Remove(nums1[i]);
                }
            }
        }
        else
        {
            var hash = new HashSet<int>(nums1);

            for (int i = 0; i < nums2.Length; i++)
            {
                if (hash.Contains(nums2[i]))
                {
                    result.Add(nums2[i]);
                    hash.Remove(nums2[i]);
                }
            }
        }

        return result.ToArray();
    }
}