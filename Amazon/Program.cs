// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using Amazon.Practice;

namespace Amazon;

public static class Program
{
    private static void Main(string[] args)
    {
        var binaryTree = new BinaryTree();
        
        // binaryTree.Insert(75);
        // binaryTree.Insert(57);
        // binaryTree.Insert(90);
        // binaryTree.Insert(32);
        // binaryTree.Insert(7);
        // binaryTree.Insert(44);
        // binaryTree.Insert(60);
        // binaryTree.Insert(86);
        // binaryTree.Insert(93);
        // binaryTree.Insert(99);
        
        // binaryTree.Insert(new []{4, 2, 3, 1, 7, 6});
        
        // binaryTree.Insert(new []{2,1,3,4,5,6});
        
        // binaryTree.Insert(new []{4,2,1,3,6,5,7});
        
        // binaryTree.Insert(new []{3,2,1,5,6,1});

        // binaryTree.Root = new TreeNode(3)
        // {
        //     LeftNode = new TreeNode(2)
        //     {
        //         LeftNode = new TreeNode(1)
        //     },
        //     RightNode = new TreeNode(5)
        //     {
        //         LeftNode = new TreeNode(6),
        //         RightNode = new TreeNode(1)
        //     }
        // };

        // Console.WriteLine("In Order");
        // binaryTree.InOrderTraversal();
        
        
        // Console.WriteLine();
        // Console.WriteLine("Pre Order");
        // binaryTree.PreOrderTraversal();
        //
        // Console.WriteLine();
        // Console.WriteLine("Post Order");
        // binaryTree.PostOrderTraversal();
        
        binaryTree.Root = new TreeNode(1)
        {
            LeftNode = new TreeNode(2)
            {
                LeftNode = new TreeNode(4),
                RightNode = new TreeNode(5)
            },
            RightNode = new TreeNode(3)
            {
                LeftNode = new TreeNode(6),
                RightNode = new TreeNode(7)
            }
        };
        
        // Console.WriteLine();
        // Console.WriteLine("Level Order");
        // binaryTree.LevelOrderTraversal();
        
        //
        // binaryTree.Remove(75);
        //
        // Console.WriteLine();
        // Console.WriteLine("In Order after removing 75");
        // binaryTree.InOrderTraversal();
        
        
        // Console.WriteLine("Largest number");
        // Console.WriteLine($"Largest -> {binaryTree.LargestValue()}");
        //
        // Console.WriteLine("Smallest number");
        // Console.WriteLine($"Smallest -> {binaryTree.SmallestValue()}");
        
        // Console.WriteLine($"Number of Leave Node -> {binaryTree.NumberOfLeaveNode()}");
        //
        // // Console.WriteLine($"Number of Right Leave Node -> {binaryTree.NumberOfRightLeaveNode()}");
        // // Console.WriteLine($"Number of Left Leave Node -> {binaryTree.NumberOfLeftLeaveNode()}");
        // //
        // Console.WriteLine($"Total Number of Node -> {binaryTree.TotalNode()}");
        //
        // Console.WriteLine();
        // // Console.WriteLine(LowestCommonAncestor.Solution(binaryTree.Root!, 1, 7));
        //
        // Console.WriteLine(Height.Solution(binaryTree.Root!));

        // Console.WriteLine(IsBinarySearchTree.Solution(binaryTree.Root!));
        
        // Console.WriteLine(IsBalancedBracket.Solution( "[(<>)](<{}<>>)"));
        
        // Console.WriteLine(PolishNotation.Solution( "5,3,+,2,/,6,+,2,*

        // var res = KClosestPoints.Solution(new[]
        // {
        //     new[] {3, 3},
        //     new[] {5, -1},
        //     new[] {-2, 4}
        // }, 2);
        //
        // foreach (var r in res)
        // {
        //     Console.WriteLine($"[{r[0]}, {r[1]}]");
        // }
        
        // Console.WriteLine(RearrangeString("baaba"));

        var lst = new List<List<string>>
        {
            new() {"add", "dfvddf"},
            new() {"add", "dfvddf"},
            new() {"find", "df"},
            new() {"add", "fvdvdfd"},
            new() {"find", "fd"},
            new() {"add", "fvdvdfd"},
            new() {"find", "fv"}
        };
        
        var result = Contacts.Solution(lst);
        
        // var c = match.Select((val, x) => x == 1).Count();


    }

    // Exp1: "5,3,+,2,/"
    // 5 + 3 = 8;
    // 8 / 2 = 4;
    //
    // Exp2: "5,3,+,2,/,6,+,2,*"
    //   5 + 3 = 8;
    //   8 / 2 = 4;
    //   4 + 6 = 10;
    //   10 * 2 = 20
    //     
    // private static double Polish(string str){
    //
    // }
    
    // 1, 2, 3, 4, 5 -> 0
    // 1, 2, 1, 3, 2, 4, 2 -> 2
    // 1, 1, 2, 2, 3, 3 -> 0
    // 1, 2, 4, 3, 1, 2, 3 -> 3
    // 4, 1, 3, 2, 1, 2, 1 => 1
    
    // Employee Table
    // Id | Name | mId
    // 1 | John | 3
    // 2 | Jean | 4
    // 3 | Toby | Null
    // 4 | Joe | Null
    
    // Write a query to produce the following: The manager name of employee whose name is John

    public static string RearrangeString(string str)
    {
        if (str.Length <= 1)
        {
            return "Not Possible";
        }
        
        var strList = str.ToArray();

        for (var i = 1; i < strList.Length; i++)
        {
            if (strList[i - 1] == strList[i])
            {
                var r = (char) (strList[i] + 'a');
                var swapIndex = Array.FindIndex(strList, i+1,x => x != strList[i]);
                if (swapIndex < 0)
                {
                    if (i == strList.Length - 1 && strList[0] != strList[i])
                    {
                        strList = strList.Prepend(strList[i])
                            .Take(strList.Length)
                            .ToArray();
                    }
                    else
                    {
                        return "Not Possible";
                    }
                }
                else
                {
                    (strList[i], strList[swapIndex]) = (strList[swapIndex], strList[i]);
                }
            }
        }

        return string.Join("", strList);
    }

}
