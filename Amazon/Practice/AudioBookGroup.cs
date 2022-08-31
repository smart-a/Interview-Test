namespace Amazon.Practice;

public static class AudioBookGroup
{
    // ["110", "110", "011", "001"] -> 2
    public static int Solution(List<string> repeated)
    {
        var aud = new List<Model>();
        for (var j=0; j < repeated.Count; j++)
        {
            var index = j;
            var arr = repeated[j].ToCharArray();
            var g = arr.Select((val, i) =>
                (i != index && val=='1') ? i : '-');
            
            var g2 = g.Where(w => w != '-');
                
            var models = g2.Select(s => 
                new Model{ Giver = index, Taker = int.Parse(s.ToString())}); 
            
            Add(aud, models);
        }

        return aud.Count;
    }

    static void Add(List<Model> aud, IEnumerable<Model> models)
    {
        if (aud.Any(a =>
                models.Any(m => m.Taker == a.Giver)))
        {
            return;
        }
        
        aud.AddRange(models);
    }

    record Model
    {
        public int Giver { get; set; }
        public int Taker { get; set; }
    }
}