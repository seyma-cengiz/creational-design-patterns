## Factory Pattern [^1]

Factory Method is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.<br /> 
Adding a new class to the program isn’t that simple if the rest of the code is already coupled to existing classes.<br /> 

The Factory Method pattern suggests that we replace direct object construction calls (using the new operator) with calls to a special factory method.
Don’t worry: the objects are still created via the new operator, but it’s being called from within the factory method.

> Objects returned by a factory method are often referred to as **_products_**.

So, now we can override the factory method in a subclass and change the class of products being created by the method.

> [!WARNING]
There’s a slight limitation though: subclasses may return different types of products only if these products have a common base class or interface. <br /> <br /> 
Also, the factory method in the base class should have its return type declared as this interface.
<br />

<img width="699" alt="image" src="https://github.com/seyma-cengiz/creational-design-patterns/assets/97255015/597b02dc-2838-4a60-81e6-a26752fd5e8f">
<br /> <br />

> [!IMPORTANT]
The creator class declares the factory method that must return an object of a product class. 
The creator's subclasses usually provide the implementation of this method. <br /> <br /> 
The creator may also provide some default implementation of the factory method.

> [!NOTE]
Note that, despite its name, the creator's primary responsibility isn't creating products. 
It usually contains some core business logic that relies on product objects returned by the factory method. <br /> <br /> 
Subclasses can indirectly change that business logic by overriding the factory method and returning a different type of product from it.
    
[^1]: https://refactoring.guru/design-patterns/factory-method
