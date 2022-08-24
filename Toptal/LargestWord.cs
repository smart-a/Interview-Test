using System.Linq;

namespace Toptal
{
    public static class LargestWord
    {
        public static int solution(string S)
        {
            var largeWord = 0;
            foreach (var sent in S.Split('.', '?', '!'))
            {
                var words = sent.Split(' ').Where(w => w.Length > 0).ToArray();
                if (largeWord < words.Length)
                {
                    largeWord = words.Length;
                }
            }

            return largeWord;
        }
    }
}