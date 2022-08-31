namespace Amazon.Practice;

public class BinaryTree
{
    private TreeNode? _root;

    public TreeNode? Root
    {
        get => _root;
        set => _root = value;
    }

    public void Insert(int[] data)
    {
        foreach (var node in data)
        {
            if (_root != null)
            {
                _root.Insert(node);
            }
            else
            {
                _root = new TreeNode(node);
            }
        }
    }
    
    public void Insert(int data)
    {
        if (_root != null)
        {
            _root.Insert(data);
        }
        else
        {
            _root = new TreeNode(data);
        }
    }

    // Left->Root->Right
    public void InOrderTraversal()
    {
        _root?.InOrderTraversal();
    }
    
    // Root->Left->Right
    public void PreOrderTraversal()
    {
        _root?.PreOrderTraversal();
    }
    
    // Left->Right->Root
    public void PostOrderTraversal()
    {
        _root?.PostOrderTraversal();
    }
    
    // Node of current Level
    // Level Order Traversal aka Breadth First Traversal
    public void LevelOrderTraversal()
    {
        var level = _root?.Height();
        if (level == null)
        {
            return;
        }
        for (var i = 1; i <= level+1; i++)
        {
            _root?.LevelOrderTraversal(i);
        }
    }

    public int Height()
    {
        return _root?.Height() ?? 0;
    }

    public TreeNode? Find(int data)
    {
        return _root?.Find(data);
    }
    
    public TreeNode? FindRecursive(int data)
    {
        return _root?.FindRecursive(data);
    }
    
    public void Remove(int data)
    {
        var current = _root;
        var parent = _root;
        var isLeftChild = false;

        if (current == null)
        {
            return;
        }

        while (current != null && current.Data != data)
        {
            parent = current;

            if (data > current.Data)
            {
                current = current.RightNode;
                isLeftChild = false;
            }
            else
            {
                current = current.LeftNode;
                isLeftChild = true;
            }
        }
        
        // still null and value not found return null
        if (current == null)
        {
            return;
        }
        
        // Is it a leave node
        if (current.RightNode == null && current.LeftNode == null)
        {
            if (current == _root)
            {
                _root = null;
            }
            else
            {
                if (isLeftChild)
                {
                    parent!.LeftNode = null;
                }
                else
                {
                    parent!.RightNode = null;
                }
            }
        }
        else if (current.RightNode == null)
        {
            if (current == _root)
            {
                _root = current.LeftNode;
            }
            else
            {
                if (isLeftChild)
                {
                    parent!.LeftNode = current.LeftNode;
                }
                else
                {
                    parent!.RightNode = current.LeftNode;
                }
            }
        }
        else if (current.LeftNode == null)
        {
            if (current == _root)
            {
                _root = current.RightNode;
            }
            else
            {
                if (isLeftChild)
                {
                    parent!.LeftNode = current.RightNode;
                }
                else
                {
                    parent!.RightNode = current.RightNode;
                }
            }
        }
        else
        {
            var successor = GetSuccessor(current);

            if (current == _root)
            {
                _root = successor;
            }
            else if (isLeftChild)
            {
                parent!.LeftNode = successor;
            }
            else
            {
                parent!.RightNode = successor;
            }
        }
        
        
    }

    public int? SmallestValue()
    {
        return _root?.SmallestValue();
    }

    public int? LargestValue()
    {
        return _root?.LargestValue();
    }

    public int NumberOfLeaveNode()
    {
        return _root?.NumberOfLeaveNode() ?? 0;
    }
    
    public int NumberOfRightLeaveNode()
    {
        if (_root == null)
        {
            return 0;
        }
        return _root.RightNode?.NumberOfLeaveNode() ?? 0;
    }
    
    public int NumberOfLeftLeaveNode()
    {
        if (_root == null)
        {
            return 0;
        }
        return _root.LeftNode?.NumberOfLeaveNode() ?? 0;
    }

    public int TotalNode()
    {
        return _root?.TotalNode() ?? 0;
    }
    
    private TreeNode GetSuccessor(TreeNode node)
    {
        var parentOfSuccessor = node;
        var successor = node;
        var current = node.RightNode;

        while (current != null)
        {
            parentOfSuccessor = successor;
            successor = current;
            current = current.LeftNode;
        }

        if (successor != node.RightNode)
        {
            parentOfSuccessor.LeftNode = successor.RightNode;
            successor.RightNode = node.RightNode;
        }

        successor.LeftNode = node.LeftNode;
        return successor;
    }
}