# Problem 006 – XOR Linked List Implementation

**Problem:**

An XOR linked list is a more memory-efficient doubly linked list. Instead of each node holding `next` and `prev` fields, it holds a field named `both`, which is an XOR of the next node and the previous node.

Implement an XOR linked list; it should have:

- `add(element)` — adds the element to the end of the list.
- `get(index)` — returns the node at the given index.

If using a language that has no pointers (such as Python), you can assume you have access to `get_pointer` and `dereference_pointer` functions that convert between nodes and memory addresses.

**Example:**

Add elements `[1, 2, 3]` and get element at index `1`  
Output: Node with value `2`

**Constraints:**

You must simulate pointer operations if your language does not support pointers.

The list should support efficient traversal using the XOR logic.
