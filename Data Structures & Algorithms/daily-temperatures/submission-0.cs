public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int[]> tempStack = new Stack<int[]>();
        int currHigh = temperatures[0];

        

        int[] result = new int[temperatures.Length];

        for (int i = 0; i < temperatures.Length; i++)
        {
            int currTemp = temperatures[i];

            while (tempStack.Count > 0 && currTemp > tempStack.Peek()[0])
            {
                int[] pair = tempStack.Pop();

                result[pair[1]] = i - pair[1];
            }
            tempStack.Push(new int[] {currTemp, i});            
        }

        return result;
    }
}
