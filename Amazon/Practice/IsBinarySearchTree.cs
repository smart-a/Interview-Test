namespace Amazon.Practice;

public class IsBinarySearchTree
{
    public static bool Solution(TreeNode node)
    {
        return CheckBinarySearchTree(node);
    }
    
    private static bool CheckBinarySearchTree(TreeNode node)
    {
        if (node.RightNode == null && node.LeftNode == null)
        {
            return true;
        }

        var lCheck = true;
        var rCheck = true;
        
        if (node.LeftNode != null)
        {
            if (node.Data < node.LeftNode.Data)
            {
                return false;
            }

            lCheck = CheckBinarySearchTree(node.LeftNode);
        }
        
        if (node.RightNode != null)
        {
            if (node.Data > node.RightNode.Data)
            {
                return false;
            }

            rCheck = CheckBinarySearchTree(node.RightNode);
        }

        return rCheck && lCheck;
    }
}