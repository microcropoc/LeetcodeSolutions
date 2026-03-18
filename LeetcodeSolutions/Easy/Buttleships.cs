namespace LeetCodeTests.Easy;

public class Buttleships
{
    [Fact]
    public void Test1()
    {
        //Arrange

        var twoBoard = new char[][] { ['X', '.', '.', 'X'], ['.', '.', '.', 'X'], ['.', '.', '.', 'X'] };

        //Act

        var result = CountBattleships(twoBoard);

        //Assert

        Assert.Equal(2, result);
    }

    [Fact]
    public void Test2()
    {
        //Arrange

        var twoBoard = new char[][] { ['X', '.', 'X'], ['X', '.', 'X'] };

        //Act

        var result = CountBattleships(twoBoard);

        //Assert

        Assert.Equal(2, result);
    }

    [Fact]
    public void Test3()
    {
        //Arrange

        var twoBoard = new char[][] { ['X', '.'], ['.', 'X'] };

        //Act

        var result = CountBattleships(twoBoard);

        //Assert

        Assert.Equal(2, result);
    }

    [Fact]
    public void Test4()
    {
        //Arrange

        var board = new char[][] { ['.'] };

        //Act

        var result = CountBattleships(board);

        //Assert

        Assert.Equal(0, result);
    }

    public int CountBattleships(char[][] board)
    {
        var result = 0;
        for (int i = 0; i < board.Length; i++)
        for (int j = 0; j < board[0].Length; j++)
        {
            if(board[i][j] == '.')
                continue;
            if(i > 0 && board[i - 1][j] == 'X')
                continue;
            if(j > 0 && board[i][j - 1] == 'X')
                continue;
            result++;
        }

        return result;
    }

    public int CountBattleshipsMain(char[][] board)
    {
        var b = 'X';
        char f = '.';

        var rows = board.Length;
        var cols = board[0].Length;


        var countBoards = 0;
        var countB = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (board[i][j] == b)
                    countB++;
                if (board[i][j] == f)
                {
                    if(countB > 1)
                    {
                        countB = 0;
                        countBoards++;
                    }
                    else if(countB == 1)
                    {
                        if(i == 0)
                        {
                            countB = 0;
                            countBoards++;
                        }
                        else
                        {
                            if(board[i - 1][j - 1] == b)
                            {
                                countB = 0;
                            }
                            else
                            {
                                countB = 0;
                                countBoards++;
                            }
                        }
                    }
                }
            }

            if (countB > 1)
            {
                countB = 0;
                countBoards++;
            }
            else if (countB == 1)
            {
                if (i == 0)
                {
                    countB = 0;
                    countBoards++;
                }
                else
                {
                    if (board[i - 1][cols - 1] == b)
                    {
                        countB = 0;
                    }
                    else
                    {
                        countB = 0;
                        countBoards++;
                    }
                }
            }
        }

        return countBoards;
    }
}
