namespace Amazon.Practice;

public static class Contacts
{
    public static List<int> Solution(List<List<string>> queries)
    {
        var arr = queries.ToArray();
        var dic = new List<string>();
        var match = new List<int>();
        for(var i=0; i< arr.GetLength(0); i++){
            // var action = queries[i][0];
            // var word = queries[i][1];

            if (queries[i][0] != "find")
            {
                var range = Array.FindIndex(arr, i , x => x[0] == "find") - i;
                dic.AddRange(arr[new Range(i, (i+range))].Select(x => x[1])); // i..(range)+1
                i += range;
            }
            match.Add(dic.Count(d => d.StartsWith(queries[i][1])));
        }

        return match;
    }
}