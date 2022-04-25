// See https://leetcode.com/problems/binary-tree-inorder-traversal/ for more information
Console.WriteLine("Hello, World!");

Console.ReadLine();




IList<int> InorderTraversal(TreeNode root)
{
    IList<int> res = new List<int>();
    Stack<TreeNode> s = new Stack<TreeNode>();

    while (root != null || s.Count > 0)
    {
        while (root != null)
        {
            s.Push(root);
            root = root.left;
        }

        root = s.Pop();

        res.Add(root.val);

        root = root.right;
    }

    return res;
}

IList<int> PostorderTraversal(TreeNode root)
{
    IList<int> res = new List<int>();
    Stack<TreeNode> s = new Stack<TreeNode>();

    while (root != null || s.Count > 0)
    {
        while (root != null)
        {
            s.Push(root);
            root = root.left;
        }

        if (s.Peek().right != null)
            root = s.Peek().right;
        else
        {
            TreeNode cur = s.Pop();

            res.Add(cur.val);

            while (s.Count > 0 && s.Peek().right == cur)
            {
                cur = s.Pop();
                res.Add(cur.val);
            }
        }
    }

    return res;
}

IList<int> PreorderTraversal(TreeNode root)
{
    IList<int> res = new List<int>();
    Stack<TreeNode> s = new Stack<TreeNode>();

    while (root != null || s.Count > 0)
        if (root != null)
        {
            res.Add(root.val);

            s.Push(root);
            root = root.left;
        }
        else if (s.Peek().right != null)
            root = s.Peek().right;
        else
        {
            TreeNode cur = s.Pop();

            while (s.Count > 0 && s.Peek().right == cur)
                cur = s.Pop();
        }

    return res;
}

// Definition for a binary tree node.
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}