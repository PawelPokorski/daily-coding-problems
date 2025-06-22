# Problem 003 – Binary Tree Serialization

**Problem:**

Given the root of a binary tree, implement two functions:

- `serialize(root)` – converts the tree into a string representation.
- `deserialize(s)` – reconstructs the tree from the string.

The structure and values of the tree must be preserved during this process.

**Example:**

Given the following `Node` class
```python
class Node:
    def __init__(self, val, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right
```

The following test should pass:
```python
node = Node('root', Node('left', Node('left.left')), Node('right'))

assert deserialize(serialize(node)).left.left.val == 'left.left'
```

**Constraints:**

Node values are strings.

The serialized format should allow unambiguous reconstruction.
