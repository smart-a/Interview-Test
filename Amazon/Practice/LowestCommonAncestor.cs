namespace Amazon.Practice;

public class LowestCommonAncestor
{
    public static int Solution(TreeNode node, int v1, int v2)
    {
        var parent = node;
        var successor = node;
        var max = v1 > v2 ? v1 : v2;
        while (successor != null)
        {
            if (successor.Data >= v1 || successor.Data >= v2)
            {
                break;
            }
            
            if (successor.Data < max)
            {
                parent = successor;
                successor = successor.RightNode;
            }
            else
            {
                parent = successor;
                successor = successor.LeftNode;
            }
        }

        return parent?.Data ?? -1;
    }
}