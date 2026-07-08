public class Solution {

    private Dictionary<int, List<int>> preReqs = new Dictionary<int, List<int>>();

    private HashSet<int> visiting = new HashSet<int>();

    public bool CanFinish(int numCourses, int[][] prerequisites) {


       for (int i = 0; i < numCourses; i++)
       {
            preReqs[i] = new List<int>();
       } 

        for (int i = 0; i < prerequisites.Length; i++)
        {
            preReqs[prerequisites[i][0]].Add(prerequisites[i][1]);
        }

        for (int i = 0; i < numCourses; i++)
            if (!Dfs(i))
                return false;

        return true;
    }

    private bool Dfs(int course) {
        if (visiting.Contains(course))
            return false;

        if (preReqs[course].Count == 0)
            return true;


        visiting.Add(course);
        foreach (int pre in preReqs[course]) {
            if (!Dfs(pre))
            {
                return false;
            }
        }
        visiting.Remove(course);
        preReqs[course].Clear();
        return true;
    }
}
