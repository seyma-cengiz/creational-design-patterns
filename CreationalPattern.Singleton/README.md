## Singleton Pattern [^1]

Singleton is a creational design pattern that lets us ensure that a class has only one instance, 
while providing a **_global access_** point to this instance. <br /> 
The Singleton pattern solves two problems at the same time:
1. Ensure that a class has just a single instance.
2. Provide a global access point to that instance and also protects that instance from being overwritten by other code.
*(There’s another side to this problem: we don’t want the code that solves problem #1 to be scattered all over your program.
It’s much better to have it within one class, especially if the rest of your code already depends on it.)*<br /> <br /> 

<img width="473" alt="image" src="https://github.com/seyma-cengiz/creational-design-patterns/assets/97255015/f3810d32-8f43-4662-af3a-c6645af0554c">
<br /> <br /> 

> [!IMPORTANT]
Singleton pattern violates the Single Responsibility Principle. The pattern solves two problems at the time.
<br /> <br />

## 🖊 $\color{blue} \text{How \ to \ Implement}\$
1. Add a private static field to the class for storing the singleton instance.
2. Declare a public static creation method for getting the singleton instance.
3. Implement “lazy initialization” inside the static method. It should create a new object on its first call and put it into the static field.
The method should always return that instance on all subsequent calls.
4. Make the constructor of the class private. The static method of the class will still be able to call the constructor, but not the other objects.
5. Go over the client code and replace all direct calls to the singleton’s constructor with calls to its static creation method.
<br />

> [!WARNING]
It may be difficult to unit test the client code of the Singleton because many test frameworks rely on inheritance when producing mock objects.
Since the constructor of the singleton class is private and overriding static methods is impossible in most languages,
we will need to think of a creative way to mock the singleton. Or just don’t write the tests. Or don’t use the Singleton pattern.

[^1]: https://refactoring.guru/design-patterns/singleton
