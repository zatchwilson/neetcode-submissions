public class Solution {
    HashSet<string> traversed = new();
    char[][] pBoard;
    string pWord;

    public bool Exist(char[][] board, string word) {
        int next = 0;
        pBoard = board;
        pWord = word;
        //Check above, to right, to left, and below 

        for(int outer = 0; outer < board.Length; outer++)
        {
            for(int inner = 0; inner < board[0].Length; inner++)
            {
                bool res = CheckSquare(inner, outer, 0);

                if (res)
                    return true;
                
            }
        }

        return false;
    }

    private bool CheckSquare(int x, int y, int idx)
    {
        if (pBoard[y][x] == pWord[idx])
        {
            idx++;
            if (idx == pWord.Length)
                return true;
                
            traversed.Add("" + x + y);
            //check above if possible
            if ((y-1) >= 0)
            {
                if (!traversed.Contains("" + x + (y-1)))
                {
                    bool res = CheckSquare(x,y-1, idx);

                    if (res)
                        return true;
                }
            }
            if ((y+1) < pBoard.Length)
            {
                if (!traversed.Contains("" + x + (y+1)))
                {
                    bool res = CheckSquare(x,y+1, idx);

                    if (res)
                        return true;
                }
            }
            if ((x-1) >= 0)
            {
                if (!traversed.Contains("" + (x-1) + y))
                {
                    bool res = CheckSquare(x-1,y, idx);

                    if (res)
                        return true;
                }
            }
            if ((x+1) < pBoard[0].Length)
            {
                if (!traversed.Contains("" + (x+1) + y))
                {
                    bool res = CheckSquare(x+1,y, idx);

                    if (res)
                        return true;
                }
            }

            traversed.Remove(""+x+y);
        }
        return false;
    }
}
