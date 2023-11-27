## Builder Pattern [^1]

Builder is a creational design pattern that lets us construct complex objects **_step by step_**. <br /> 
The pattern allows us to produce different types and representations of an object using the same construction code.<br /> 

Initialization code of a complex object that requires laborious, step-by-step initialization of many fields and nested objects is usually buried inside a monstrous constructor with lots of parameters. Or even worse: scattered all over the client code.
> [!WARNING]
We might make the program too complex by creating a subclass for every possible configuration of an object.<br /> 
Also, the constructor with lots of parameters has its downside: not all the parameters are needed at all times.


- The Builder pattern suggests that we extract the object construction code out of its own class and move it to separate objects called builders.<br /> <br /> 
- We can go further and extract a series of calls to the builder steps we use to construct a product into a separate class called director (not strictly necessary). The director class defines the order in which to execute the building steps, while the builder provides the implementation for those steps.<br /> 


<img width="700" alt="image" src="https://github.com/seyma-cengiz/creational-design-patterns/assets/97255015/40f26b4e-4fa1-496a-8d4e-5e26f31dfad7"><br /> 


## 🖊 $\color{blue} \text{How \ to \ Implement}\$
1. Make sure that you can clearly define the common construction steps for building all available product representations. Otherwise, you won’t be able to proceed with implementing the pattern. Declare these steps in the base builder interface.
2. Create a concrete builder class for each of the product representations and implement their construction steps.
3. Don’t forget about implementing a method for fetching the result of the construction. The reason why this method can’t be declared inside the builder interface is that various builders may construct products that don’t have a common interface. Therefore, you don’t know what would be the return type for such a method. However, if you’re dealing with products from a single hierarchy, the fetching method can be safely added to the base interface.
4. Think about creating a director class. It may encapsulate various ways to construct a product using the same builder object.
5. The client code creates both the builder and the director objects. Before construction starts, the client must pass a builder object to the director. Usually, the client does this only once, via parameters of the director’s class constructor. The director uses the builder object in all further construction. There’s an alternative approach, where the builder is passed to a specific product construction method of the director.a
6. The construction result can be obtained directly from the director only if all products follow the same interface. Otherwise, the client should fetch the result from the builder.

[^1]: https://refactoring.guru/design-patterns/builder
