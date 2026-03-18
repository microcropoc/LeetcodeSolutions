namespace LeetCodeTests.Easy;

public class ContainsDuplicates
{
    [Fact]
    public void Test1()
    {
        //Arrange

        var nums = new int[] { 1, 2, 3, 1 };


        //Act

        var result = ContainsDuplicateHash(nums);

        //Assert

        Assert.Equal(true, result);
    }

    //O(n) space O(n)
    public bool ContainsDuplicateHash(int[] nums)
    {
        var hash = new HashSet<int>();

        foreach (var i in nums) 
        { 
            if(hash.Contains(i))
                return true;
            hash.Add(i);
        }

        return false;
    }

    //O(n log n)
    static bool CheckDuplicate(int[] arr)
    {
        Array.Sort(arr);

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == arr[i - 1])
                return true;
        }

        return false;
    }
}
