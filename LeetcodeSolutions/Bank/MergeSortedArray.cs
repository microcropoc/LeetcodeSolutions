namespace LeetCodeTests.Bank;

public class MergeSortedArray
{
    [Fact]
    public void Test1()
    {
        //Arrange

        var nums1 = new int[] { 1, 2, 3, 4, 5, 6};
        var m = 3;
        var nums2 = new int[] { 2, 2, 2 };
        var n = 3;


        //Act

        var result = MergeSortedArrayTP(nums1, nums2);

        //Assert

        Assert.Equal([1, 2, 3, 4, 5, 6], result.ToArray());
    }

    //O(m + n)
    public IEnumerable<int> MergeSortedArrayTP(int[] nums1, int[] nums2)
    {
        var p1 = 0;
        var p2 = 0;
        var max = (int?)null;

        while (p1 < nums1.Length && p2 < nums2.Length)
        {
            if (nums1[p1] < nums2[p2])
            {
                if (max != nums1[p1])
                {
                    yield return nums1[p1];
                    max = nums1[p1];
                }

                p1++;
            }
            else if (nums1[p1] > nums2[p2])
            {
                if (max != nums2[p2])
                {
                    yield return nums2[p2];
                    max = nums2[p2];
                }

                p2++;
            }
            else
            {
                if (max != nums1[p1])
                {
                    yield return nums1[p1];
                    max = nums1[p1];
                }

                p1++;
                p2++;
            }
        }

        while (p1 < nums1.Length)
        {
            if (max != nums1[p1])
            {
                yield return nums1[p1];
                max = nums1[p1];
            }

            p1++;
        }

        while (p2 < nums2.Length)
        {

            if (max != nums2[p2])
            {
                yield return nums2[p2];
                max = nums2[p2];
            }

            p2++;
        }
    }
}
