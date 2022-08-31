namespace Amazon.Practice;

public class Height
{
    public static int Solution(TreeNode node)
    {
        return Count(node);
    }

    private static int Count(TreeNode node)
    {
        if (node.LeftNode == null && node.RightNode == null)
        {
            return 0;
        }

        var lCount = 0;
        var rCount = 0;
        if (node.LeftNode != null)
        {
            lCount = Count(node.LeftNode);
        }
        
        if (node.RightNode != null)
        {
            rCount = Count(node.RightNode);
        }

        return (lCount > rCount ? lCount : rCount) + 1;
    }
}