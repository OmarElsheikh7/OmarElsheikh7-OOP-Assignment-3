Task 2.1 — Research: IReadOnlyDictionary & SortedDictionary

IReadOnlyDictionary vs Dictionary : The difference is the IReadOnlyDictionary hides the methods that can change the values of it like 
(Add(),Remove()) you can just read. and thats why a public method would return it.

SortedDictionary vs Dictionary : 
1. ordering : the Dictionary does not have a specific order its just there. but the SortedDictionary order the values by its keys.
2. lookup speed : the Dictionary uses hashing so the time complexity is O(1). but the SortedDictionary because of the sort it lookup using binary 
    search so its complexity is O(Log(n)).
3. when to use it : when you need your data to be sorted on addition and will remove or edit and need it to be sorted all time.

===========================================================================================================================================

Task 2.2 — Pick the Collection

S1 : Dictionary, Because you can make the national id a key and student value and get it in O(1).
S2 : Hashset, Because hashset does not store duplications.
S3 : List, Because it keeps the data the order they were entered and can store duplications.
S4 : IReadOnlyDictionary, Because that is exactly what it does can read the but can not add or change any. 
S5 : SortedDictionary, Because it sort by key on additon and always keep ordering.
S6 : IEnumerable, Because you can use yield return with it.