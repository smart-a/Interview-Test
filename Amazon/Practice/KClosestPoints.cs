namespace Amazon.Practice;

public static class KClosestPoints
{
    // Input: points = [[3,3],[5,-1],[-2,4]], k = 2
    // Output: [[3,3],[-2,4]]
    
    // Input: points = [[1,3],[-2,2]], k = 1
    // Output: [[-2,2]]
    public static int[][] Solution(int[][] points, int k)
    {
        var dist = new List<Model>();

        for (var i = 0; i < points.GetLength(0); i++)
        {
            var x = points[i][0];
            var y = points[i][1];
            
            dist.Add(new Model
            {
                Distance = x*x + y*y,
                Points = new []{x, y}
            });
        }

        return dist.OrderBy(x => x.Distance)
            .Take(k)
            .Select(x => x.Points)
            .ToArray();
    }

    private record Model
    {
        public int Distance { get; init; }
        public int[] Points { get; init; } = null!;
    }
}