# Part 03 — answers

---

## BlockedUsers

- Time complexity before: O(N * M)
- Time (ms) before: 19 ms
- What did you change? : changed the list to a hashset
- Time complexity after: O(M)
- Time (ms) after: 0 ms

---

## Students

- What was the problem? : The student catalog was doing more work than needed by returning the whole list at once.
- What did you change? : Used yield return to make it return student one by one and changed the return typr to IEnumerable.
