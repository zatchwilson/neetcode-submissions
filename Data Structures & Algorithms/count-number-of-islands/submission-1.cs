public class Solution {
    public int NumIslands(char[][] grid) {
        // Iterate through array, perform BFS when coming to a '1' node
        //  - Each '1' found for a given BFS gets changed to '0'
        //  - Increment counter after original BFS completes, then continue interating thru

        int counter = 0;

        Queue<(int, int)> island = new();

        for (int outer = 0; outer < grid.Length; outer++)
        {
            for (int inner = 0; inner < grid[0].Length; inner++)
            {
                char curr = grid[outer][inner];

                if (curr == '1')
                {
                    island.Enqueue((outer, inner));

                    while (island.Count() > 0)
                    {
                        (int, int) currNode = island.Dequeue();

                        int currOuter = currNode.Item1;
                        int currInner = currNode.Item2;

                        grid[currOuter][currInner] = '0';

                        //Enqueue <, ^, >, v

                        // Check Above
                        if (currOuter > 0 && grid[currOuter-1][currInner] == '1')
                        {
                            island.Enqueue((currOuter-1, currInner));
                        }

                        // Check below
                        if (currOuter < grid.Length-1 && grid[currOuter+1][currInner] == '1')
                        {
                            island.Enqueue((currOuter+1, currInner));
                        }
                        
                        // Check Left
                        if (currInner > 0 && grid[currOuter][currInner-1] == '1')
                        {
                            island.Enqueue((currOuter, currInner-1));
                        }

                        if (currInner < grid[0].Length - 1 && grid[currOuter][currInner+1] == '1')
                        {
                            island.Enqueue((currOuter, currInner+1));
                        }

                    }
                    counter++;
                }

            }
        }

        return counter;

    }
}
