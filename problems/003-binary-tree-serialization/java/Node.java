import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Node {
    String val;
    Node left, right;

    Node(String value) {
        this(value, null, null);
    }

    Node(String value, Node left) {
        this(value, left, null);
    }

    Node(String value, Node left, Node right) {
        this.val = value;
        this.left = left;
        this.right = right;
    }

    public static String serialize(Node root) {
        return root == null ? "" : root.toString();
    }
    
    public static Node deserialize(String treeString) {

        if(treeString == null || treeString.trim().isEmpty()) {
            return null;
        }

        List<String> parts = new ArrayList<>(Arrays.asList(treeString.trim().split(" ")));
        return buildTree(parts);
    }

    private static Node buildTree(List<String> parts) {
        if(parts.isEmpty()) return null;

        String part = parts.remove(0);

        if(part.equals("|")) {
            return null;
        } else {
            Node newNode = new Node(part);
        
            newNode.left = buildTree(parts);
            newNode.right = buildTree(parts);

            return newNode;
        }
    }

    @Override
    public String toString() {

        String output = val + " ";
        
        if(left != null) {
            output += left.toString();
        } else {
            output += "| ";
        }

        if(right != null) {
            output += right.toString();
        } else {
            output += "| ";
        }
        
        return output;
    }
}
