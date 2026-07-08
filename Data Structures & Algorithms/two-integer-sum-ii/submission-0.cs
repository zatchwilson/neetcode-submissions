public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int p1 = 0; 
        int p2 = numbers.Length - 1;

        while (true)
        {
            int sum = numbers[p1] + numbers[p2];

            if (sum > target)
                p2--;
            else if (sum < target)
                p1++;
            else
                return new int[] {p1+1, p2+1};
        }


    }
}
