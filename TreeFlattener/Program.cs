using System;
using System.Collections.Generic;

class TreeNode
{
    public string Value;
    public List<TreeNode> Children = new List<TreeNode>();

    public TreeNode(string value)
    {
        Value = value;
    }
}

static class TreeHelper
{
    public static List<string> FlattenTree(params TreeNode[] roots)
    {
        List<string> result = new List<string>();

        foreach (TreeNode root in roots)
        {
            int depth = 0;

            void Traverse(TreeNode node, ref int currentDepth)
            {
                Console.WriteLine($"{node.Value} : Depth {currentDepth}");
                result.Add(node.Value);

                currentDepth++;

                foreach (TreeNode child in node.Children)
                {
                    Traverse(child, ref currentDepth);
                }

                currentDepth--;
            }

            Traverse(root, ref depth);
        }

        return result;
    }
}

class Program
{
    static void Main()
    {
        TreeNode A = new TreeNode("A");
        A.Children.Add(new TreeNode("A1"));
        A.Children.Add(new TreeNode("A2"));

        TreeNode B = new TreeNode("B");
        TreeNode B1 = new TreeNode("B1");
        B1.Children.Add(new TreeNode("B1a"));
        B1.Children.Add(new TreeNode("B1b"));
        B.Children.Add(B1);

        TreeNode C = new TreeNode("C");

        List<string> list = TreeHelper.FlattenTree(A, B, C);

        Console.WriteLine("Flattened Tree:");

        foreach (string item in list)
        {
            Console.WriteLine(item);
        }
    }
}