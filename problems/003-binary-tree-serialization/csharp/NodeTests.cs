using NUnit.Framework;

public class NodeTests
{
    [Test]
    public void NodeTest()
    {
        var node = new Node("root", new Node("left", new Node("left.left")), new Node("right"));

        var serialized = Node.Serialize(node);
        var deserialized = Node.Deserialize(serialized);

        var result = Node.Deserialize(Node.Serialize(node)).Left.Left.Val;

        Assert.That(result, Is.EqualTo("left.left"));
    }
}
