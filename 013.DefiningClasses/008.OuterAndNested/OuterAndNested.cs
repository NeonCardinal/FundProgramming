//Defining classes, Example 008
//10.05.2023, 21:48
using System;

public class OuterAndNested
{
    private string name;

    private OuterAndNested(string name)
    {
        this.name = name;
    }

    private class NestedClass
    {
        private string name;
        private OuterAndNested parent;

        public NestedClass(OuterAndNested parent, string name)
        {
            this.parent = parent;
            this.name = name;
        }

        public void PrintNames()
        {
            Console.WriteLine($"Nested class: {this.name}");
            Console.WriteLine($"Outer class: {this.parent.name}");
        }
    }

    public static void Main()
    {
        OuterAndNested outerClass = new OuterAndNested("outer");
        NestedClass nestedClass = new NestedClass(outerClass, "nested");

        nestedClass.PrintNames();
    }
}