# Problem 005 – Functional Pair Implementation

**Problem:**

`cons(a, b)` constructs a pair, and `car(pair)` and `cdr(pair)` returns the first and last element of that pair. 

Given this implementation of cons:

```python
def cons(a, b):
    def pair(f):
        return f(a, b)
    return pair
```

Implement `car` and `cdr`.

**Example:**

`car(cons(3,4))` returns `3`, and `cdr(cons(3,4))` returns `4`.
