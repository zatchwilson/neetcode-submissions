public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {

        int columns = matrix[0].Length;
        int rows = matrix.Length;

        int total = columns * rows;

        int rp = total - 1;
        int lp = 0;

        while (lp <= rp)
        {
            int mid = (lp + rp) / 2;

            int currRow = mid  / columns;

            int currColumn = mid % columns;

            int curr = matrix[currRow][currColumn];

            if (curr < target)
                lp = mid + 1;
            else if (curr > target)
                rp = mid - 1;
            else
                return true;
        }

        return false;
    }
}
