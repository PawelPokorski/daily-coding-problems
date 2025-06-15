import static org.junit.Assert.assertEquals;
import org.junit.Test;

public class NodeTests {
    
    @Test
    public void nodeTest() {
        // Arrange
        var node = new Node("root", new Node("left", new Node("left.left")), new Node("right"));
        // Act
        var result = Node.deserialize(Node.serialize(node)).left.left.val;
        // Assert
        assertEquals("left.left", result);
    }
}
