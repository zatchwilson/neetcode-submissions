public class Solution {
    public void islandsAndTreasure(int[][] grid) {
        List<(int, int)> treasures = new();
        int inf = 2147483647;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int k = 0; k < grid[0].Length; k++)
            {
                if (grid[i][k] == 0)
                {
                    treasures.Add((i,k));
                }
            }
        }

        Queue<((int,int), int)> distances = new();

        foreach((int,int) cord in treasures)
        {
            distances.Enqueue((cord, 0));
        }

        while (distances.Count > 0)
        {
            ((int,int),int) curr = distances.Dequeue();

            int n1 = curr.Item1.Item1;
            int n2 = curr.Item1.Item2;

            int dist = curr.Item2;

            //Check left,right,up,down

            if (n1 > 0 && grid[n1-1][n2] == inf)
            {
                distances.Enqueue(((n1-1, n2), dist+1));
                grid[n1-1][n2] = dist+1;
            }
            if (n1 < grid.Length-1 && grid[n1+1][n2] == inf)
            {
                distances.Enqueue(((n1+1, n2), dist+1));
                grid[n1+1][n2] = dist+1;
            }
            if (n2 > 0 && grid[n1][n2-1] == inf)
            {
                distances.Enqueue(((n1, n2-1), dist+1));
                grid[n1][n2-1] = dist+1;
            }
            if (n2 < grid[n1].Length-1 && grid[n1][n2+1] == inf)
            {
                distances.Enqueue(((n1, n2+1), dist+1));
                grid[n1][n2+1] = dist+1;
            }
        }
    }
}
