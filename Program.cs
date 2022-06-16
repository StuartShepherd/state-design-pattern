using StateDesignPattern;
using System;

Console.WriteLine("State Design Pattern");
Console.WriteLine("State is a behavioral design pattern that allows an object to change the behavior when its internal state changes.");
Console.WriteLine();

var context = new Context(new ConcreteStateAlpha());
context.Next();
context.Next();
context.Previous();
context.Previous();
context.Next();
context.Next();
context.Next();

Console.WriteLine();