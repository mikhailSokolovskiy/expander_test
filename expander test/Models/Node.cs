using System.Collections.ObjectModel;

namespace expander_test.Models;

public class Node
{
    public ObservableCollection<Node>? SubNodes { get; }
    public string Title { get; }
  
    public Node(string title)
    {
        Title = title;
    }

    public Node(string title, ObservableCollection<Node> subNodes)
    {
        Title = title;
        SubNodes = subNodes;
    }
}