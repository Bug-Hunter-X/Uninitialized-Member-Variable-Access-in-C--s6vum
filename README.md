# Uninitialized Member Variable Access in C#

This repository demonstrates a common error in C#: accessing a member variable before it has been properly initialized. This can lead to a `NullReferenceException` if the variable is a reference type, or unexpected behavior if it's a value type.

## The Problem

The `ExampleClass` has a `Value` property backed by a private `_value` integer field. The `DoSomething` method checks if `Value` is 0, but it doesn't initialize the `_value` field. If `DoSomething` is called before the `Value` property is set, accessing `Value` throws a `NullReferenceException` (not in this case, since _value is an integer, but it could happen with other reference types).

## The Solution

The solution is to always initialize the member variable before use.  This can be done in several ways:

* **Initialization in the declaration:**  The simplest way is to initialize `_value` when you declare it.
* **Initialization in the constructor:**  Initialize it in the class constructor.
* **Explicitly setting the value before access:**  Ensure that `Value` is set before calling `DoSomething`.