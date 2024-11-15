### CleanCode24

# SOLID

## SRP (Single Responsibility Principle)
The single responsibility principle is a computer programming principle that states that every module or class should have responsibility over a single part of the functionality provided by the software, and that responsibility should be entirely encapsulated by the class. All its services should be narrowly aligned with that responsibility.

## OCP (Open Closed Principle)
Software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification.

## LSP (Liskov Substitution Principle)
Liskov’s notion of a behavioural subtype defines a notion of substitutability for objects; that is, if S is a subtype of T, then objects of type T in a program may be replaced with objects of type S without altering any of the desirable properties of that program (e.g. correctness).

## ISP (Interface segregation principle)
ISP splits interfaces that are very large into smaller and more specific ones so that clients will only have to know about the methods that are of interest to them. Such shrunken interfaces are also called role interfaces. ISP is intended to keep a system decoupled and thus easier to refactor, change, and redeploy.

## DIP (Dependency Inversion Principle)
Dependency inversion talks about the coupling between the different classes or modules.
The main motto of the dependency inversion is Any higher classes should always depend upon the abstraction of the class rather than the detail.
This aims to reduce the coupling between the classes is achieved by introducing abstraction between the layer, thus doesn’t care about the real implementation.
