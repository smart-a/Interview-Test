namespace Amazon.Practice;

public class TreeNode
{
    public int Data { set; get; }
    public TreeNode? RightNode { get; set; }
    public TreeNode? LeftNode { get; set; }

    public TreeNode(int value)
    {
        Data = value;
    }

    public void Insert(int value)
    {
        if (value >= Data)
        {
            if (RightNode == null)
            {
                RightNode = new TreeNode(value);
            }
            else
            {
                RightNode.Insert(value);
            }
        }
        else
        {
            if (LeftNode == null)
            {
                LeftNode = new TreeNode(value);
            }
            else
            {
                LeftNode.Insert(value);
            }
        }
    }

    // Left->Root->Right
    public void InOrderTraversal()
    {
        LeftNode?.InOrderTraversal();
        Console.Write($"{Data} ");
        RightNode?.InOrderTraversal();
    }

    // Root->Left->Right
    public void PreOrderTraversal()
    {
        Console.Write($"{Data} ");
        LeftNode?.InOrderTraversal();
        RightNode?.InOrderTraversal();
    }

    // Left->Right->Root
    public void PostOrderTraversal()
    {
        LeftNode?.InOrderTraversal();
        RightNode?.InOrderTraversal();
        Console.Write($"{Data} ");
    }

    // Node of current Level
    public void LevelOrderTraversal(int? level)
    {
        if (level == 1)
        {
            Console.Write($"{Data} ");
        }
        else
        {
            LeftNode?.LevelOrderTraversal(level - 1);
            RightNode?.LevelOrderTraversal(level - 1);
        }
    }
    
    public TreeNode? Find(int value)
    {
        var currentNode = this;

        while (currentNode != null)
        {
            if (value == currentNode.Data)
            {
                return currentNode;
            }

            currentNode = value > currentNode.Data ? currentNode.RightNode : currentNode.LeftNode;
        }

        return null;
    }

    public TreeNode? FindRecursive(int value)
    {
        if (value == Data)
        {
            return this;
        }

        if (value > Data && RightNode != null)
        {
            return RightNode.FindRecursive(value);
        }

        if (value < Data && LeftNode != null)
        {
            return LeftNode.FindRecursive(value);
        }

        return null;
    }

    public int SmallestValue()
    {
        return LeftNode?.SmallestValue() ?? Data;
    }

    public int LargestValue()
    {
        return RightNode?.LargestValue() ?? Data;
    }

    public int NumberOfLeaveNode()
    {
        if (RightNode == null && LeftNode == null)
        {
            return 1;
        }

        var leftCount = 0;
        var rightCount = 0;
        
        if (LeftNode != null)
        {
            leftCount = LeftNode.NumberOfLeaveNode();
        }
        
        if (RightNode != null)
        {
            rightCount = RightNode.NumberOfLeaveNode();
        }

        return leftCount + rightCount;
    }

    public int TotalNode()
    {
        if (RightNode == null && LeftNode == null)
        {
            return 1;
        }

        var left = 0;
        var right = 0;
        if (RightNode != null)
        {
            right = RightNode.TotalNode();
        }
        
        if (LeftNode != null)
        {
            left = LeftNode.TotalNode();
        }

        return left + right + 1;
    }

    public int Height()
    {
        if (LeftNode == null && RightNode == null)
        {
            return 0;
        }

        var lHeight = 0;
        var rHeight = 0;

        if (LeftNode != null)
        {
            lHeight = LeftNode.Height();
        }

        if (RightNode != null)
        {
            rHeight = RightNode.Height();
        }

        return (lHeight > rHeight ? lHeight : rHeight) + 1;
    }
}