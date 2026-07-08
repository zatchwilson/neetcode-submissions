public class Solution {
    public int OrangesRotting(int[][] grid) {
        List<(int,int)> rotted = new();
        int freshCount = 0;

        for(int i = 0; i < grid.Length; i++)
        {
            for(int k = 0; k < grid[0].Length; k++)
            {
                if (grid[i][k] == 1)
                    freshCount++;
                else if (grid[i][k] == 2)
                    rotted.Add((i,k));
            }
        }
        if (freshCount == 0)
            return 0;

        Queue<((int,int),int)> rotting = new();

        foreach((int,int) coord in rotted)
            rotting.Enqueue((coord, 0));

        while (rotting.Count > 0)
        {
            ((int,int), int) coordAndMin = rotting.Dequeue();

            int c1 = coordAndMin.Item1.Item1;
            int c2 = coordAndMin.Item1.Item2;

            int currMin = coordAndMin.Item2;

            // Check up, down, left, and right

            if (c1 > 0 && grid[c1-1][c2] == 1)
            {
                grid[c1-1][c2] = 2;
                rotting.Enqueue(((c1-1, c2), currMin + 1));
                freshCount--;
            }

            if (c1 < grid.Length - 1 && grid[c1+1][c2] == 1)
            {
                grid[c1+1][c2] = 2;
                rotting.Enqueue(((c1+1, c2), currMin + 1));
                freshCount--;
            }

            if (c2 > 0 && grid[c1][c2-1] == 1)
            {
                grid[c1][c2-1] = 2;
                rotting.Enqueue(((c1, c2-1), currMin + 1));
                freshCount--;
            }

            if (c2 < grid[0].Length-1 && grid[c1][c2+1] == 1)
            {
                grid[c1][c2+1] = 2;
                rotting.Enqueue(((c1, c2+1), currMin + 1));
                freshCount--;
            }


            if (freshCount == 0)
                return currMin + 1;
        
        }

        return -1;
    }
}
