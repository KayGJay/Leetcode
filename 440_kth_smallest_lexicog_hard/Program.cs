//Keep working on it lol

Trie trie = new Trie();

trie.Insert("1");

public class Node()
{
    public Dictionary<char, Node> Children = new Dictionary<char, Node>();

    public bool IsEnd = true;

}

public class Trie()
{
    public Node Root = new Node();

    public void Insert(string key)
    {
        Node curr = Root;
        foreach (char c in key)
        {
            curr.IsEnd = false;
            if (curr.Children.ContainsKey(c))
            {
                curr = curr.Children[c];
            }
            else
            {
                curr.Children[c] = new Node();
            }
        }
    }

    public void Print(Node node)
    {
        if (node.Children.Count == 0)
        {
            foreach (char)
        }
    }
}