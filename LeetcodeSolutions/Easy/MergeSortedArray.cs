namespace LeetCodeTests.Easy;

public class MergeSortedArray
{
    [Fact]
    public void Test1()
    {
        //Arrange

        var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
        var m = 3;
        var nums2 = new int[] { 2, 5, 6 };
        var n = 3;


        //Act

        MergeSortedArrayTP(nums1, m, nums2, n);

        //Assert

        Assert.Equal([1,2,2,3,5,6], nums1);
    }

    //O(m + n)
    public void MergeSortedArrayTP(int[] nums1, int m, int[] nums2, int n)
    {
        var p1 = m - 1;
        var p2 = n - 1;
        var p = m + n - 1;

        while(p1 >= 0 && p2 >= 0)
        {
            if (nums1[p1] > nums2[p2])
            {
                nums1[p] = nums1[p1];
                p1--;
            }
            else
            {
                nums1[p] = nums2[p2];
                p2--;
            }

            p--;
        }

        while (p2 >= 0)
        {
            nums1[p] = nums2[p2];
            p2--;
            p--;
        }
    }
}
