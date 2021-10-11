using System;
using Toptal.Test;

namespace Toptal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(CountBoundedSlices.solution(2, new [] {3, 5, 7, 6, 3}));
            // var a = new int[] {−1, −3};
            // Console.WriteLine(SmallestPositive.solution(a));
            
            // Console.WriteLine(BinaryGap.solution(32));
            
            // Console.WriteLine(BinaryTree.solution(tree));
            
            // Console.WriteLine(LargestWord.solution("We test coders. Give us a try? . ? x . "));
            // Console.WriteLine(EndOfYearTransaction.solution(new int[]{1,-1,0,-105,1}, 
            //         new string[]{"2020-12-31","2020-04-04","2020-04-04","2020-04-14","2020-07-12"}));

            string s = "ass.jpg, Kaduna, 2020-05-01 23:45:44\n" +
                       "the.png, Oyo, 2020-04-05 12:05:14\n" +
                       "go.png, Oyo, 2020-01-04 01:50:02\n" +
                       "go.png, Kaduna, 2020-01-04 18:19:44\n" +
                       "go.png, Oyo, 2020-01-04 01:52:02\n" +
                       "go.png, Kaduna, 2020-01-04 18:19:44\n" +
                       "go.png, Oyo, 2020-01-04 01:52:02\n" +
                       "go.png, Kaduna, 2020-01-04 18:19:44\n" +
                       "go.png, Oyo, 2021-9-04 01:52:02\n" +
                       "go.png, Kaduna, 2021-01-04 18:19:44\n" +
                       "go.png, Oyo, 2021-02-04 01:52:02\n" +
                       "go.png, Kaduna, 2021-01-04 18:19:44\n" +
                       "go.png, Oyo, 2020-10-04 01:52:02\n" +
                       "go.png, Kaduna, 2020-12-04 18:19:44\n" +
                       "go.png, Oyo, 2020-01-4 01:52:02\n" +
                       "go.png, Kaduna, 2020-11-04 18:19:44\n" +
                       "go.png, Oyo, 2020-01-04 01:52:02\n" +
                       "go.png, Kaduna, 2020-11-04 18:19:44\n" +
                       "go.png, Kaduna, 2020-11-04 18:19:44\n" +
                       "go.png, Kaduna, 2020-11-04 18:19:44\n" +
                       "do.gif, Kaduna, 2020-04-20 10:35:44";
            
            // Console.WriteLine(PhotoRename.solution(s));

            var badge = "Martha exit\n" +
                        "Paul enter\n" +
                        "Martha enter\n" +
                        "Martha exit\n" +
                        "Jennifer enter\n" +
                        "Paul enter\n" +
                        "Curtis enter\n" +
                        "Paul exit\n" +
                        "Martha enter\n" +
                        "Martha exit\n" +
                        "Jennifer exit";
            
            // Console.Write(CountMissingBadge.solution(badge));

            // var pref = new string[] {"Jade", "Ruby", "Opal"};
            // var pref1 = new string[] {"Ruby", "Opal", "Jade"};
            // var offers = new GemModel[]
            // {
            //     new GemModel() {Store = "Shiny", Gem = "Jade", Count = 5},
            //     new GemModel() {Store = "Shiny", Gem = "Opal", Count = 6},
            //     new GemModel() {Store = "Domino", Gem = "Ruby", Count = 4},
            //     new GemModel() {Store = "Domino", Gem = "Jade", Count = 8}
            // };
            // foreach (var c in GemStone.Solution(offers, pref1))
            // {
            //     Console.WriteLine(c);
            // }
            //

            foreach (var v in OnlineCode.GetChange(5, 2.4))
            {
                Console.WriteLine(v);
            }
        }
        
    }
}
