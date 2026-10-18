**1. What is the same between the two stores, and what is different?**
    They are exact same they have same methods logic, The only difference is the data types (Course , Student).
    
**2. The Compiler error and Why?**
    The Erorr : ('T' does not contain a definition for 'Id' and no accessible extension method 'Id') , The Compiler reject it because T can be any object so he cant know if it will have Id or not.

**3. Why new Store<string>() must NOT compile?**
It does not compile because the generic constraint (where T : IHasId). The string in C# does not implement IHasId interface so the compiler rejects it.

**4. What is the common name for the kind of class you built in Steps 4 and 5?**
The common name for this design is the **Repository Pattern** (specifically, a Generic Repository). It abstracts away the data storage logic so the rest of the application can work with data as a simple collection of objects.