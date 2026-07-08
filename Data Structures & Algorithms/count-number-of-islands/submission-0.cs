public class Solution {
    HashSet<(int, int)> coords;
    public int NumIslands(char[][] grid) {
        coords = new();
        int count = 0;
        for(int i = 0; i < grid.Length; i++)
        {
            for(int k = 0; k < grid[0].Length; k++)
            {
                if (grid[i][k] == '1' && !coords.Contains((i,k)))
                {
                    //Run BFS on all surrounding nodes to find/add all 1's to island
                    TraverseIsland(grid, i, k);
                    count++;
                }
            }
        }

        return count;

    }

    private void TraverseIsland(char[][] grid, int firstY, int firstX){
        //Check up, down, left and right

        Queue<(int, int)> traverse = new();

        traverse.Enqueue((firstY, firstX));

        while(traverse.Count > 0)
        {
            (int, int) tup = traverse.Dequeue();

            int y = tup.Item1;
            int x = tup.Item2;

            if (x > 0 && grid[y][x-1] == '1' && !coords.Contains((y, x-1)))
            {
                coords.Add((y, x-1));
                traverse.Enqueue((y, x-1));
            }

            //Check right
            if (x < grid[0].Length-1 && grid[y][x+1] == '1' && !coords.Contains((y,x+1)))
            {
                coords.Add((y, x+1));
                traverse.Enqueue((y, x+1));
            }

            //Check above
            if(y > 0 && grid[y-1][x] == '1' && !coords.Contains((y-1,x)))
            {
                coords.Add((y-1, x));
                traverse.Enqueue((y-1, x));
            }

            if (y < grid.Length-1 && grid[y+1][x] == '1' && !coords.Contains((y+1,x)))
            {
                coords.Add((y+1, x));
                traverse.Enqueue((y+1, x));
            }
        }

        //Check left
        
    }
}
