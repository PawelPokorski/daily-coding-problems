using System.Collections.Generic;

public class Node
{
    private string val;
    private Node? left, right;

    public string Val => val;
    public Node? Left => left;
    public Node? Right => right;

    public Node() { }

    public Node(string val, Node? left = null, Node? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    public static string? Serialize(Node root)
    {
        return root == null ? "" : root.ToString();
    }

    public static Node? Deserialize(string tree)
    {
        if (tree == null)
            return null;

        List<string> parts = tree.Trim().Split(" ").ToList();

        return BuildTree(parts);
    }

    private static Node? BuildTree(List<string> parts)
    {
        if (parts.Count == 0) return null;

        string part = parts.First();
        parts.Remove(part);

        if (part.Equals("|"))
            return null;

        Node newNode = new(part, BuildTree(parts), BuildTree(parts));

        return newNode;
    }

    public override string ToString()
    {
        string output = val + " ";

        if (left != null)
            output += left.ToString();
        else
            output += "| ";

        if (right != null)
            output += right.ToString();
        else
            output += "| ";

        return output;
    }
}
