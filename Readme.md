# CREATIONAL DESIGN PATTERNS

### https://refactoring.guru/design-patterns/creational-patterns

## **What**

- Creational design patterns abstract the process of object creation and provide mechanisms for flexibility, reuse, and better management of object lifecycles.

## **Why**

- They reduce tight coupling between client code and object creation, allow for more flexibility, manage complexity, and centralize the control of object instantiation.

## **When**

- Use creational patterns when object creation is complex, needs to be flexible, or requires controlling how objects are instantiated. They are especially useful when you want to manage object lifecycles, handle multiple variants, or ensure a single instance of an object.


<br/>


## Most Commonly used

**Singleton** - Often used to ensure that a class has only one instance, it’s popular for things like database connections or logging systems. However, it can lead to tightly coupled code and make testing difficult because it's essentially a global instance that can be accessed from anywhere.

**Factory Method** - Commonly used when object creation is deferred to subclasses. While it helps with object creation and encapsulation, it can sometimes lead to overengineering, especially when a simpler solution would suffice.

**Abstract Factory** - Used to create families of related objects without specifying their concrete classes. While useful in some scenarios, it's often overused in situations where polymorphism or simpler patterns could be enough, leading to unnecessary complexity.

**Builder** - This pattern is popular for constructing complex objects step-by-step, but it can lead to bloated code if overused. Sometimes, a simple constructor with named parameters or a factory method can achieve the same goal more concisely.

**Prototype** - Involves creating new objects by copying an existing one, which is useful in some cases (like cloning), but in most business scenarios, it’s rarely needed and can be over-complicated.