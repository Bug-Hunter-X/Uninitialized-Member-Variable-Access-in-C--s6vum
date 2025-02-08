public class ExampleClass
{
    private int _value = 0; // Initialize _value in the declaration

    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public void DoSomething()
    {
        if (Value == 0)
        {
            Console.WriteLine(Value.ToString());
        }
    }

    public ExampleClass() // Constructor to initialize _value if necessary.
    {
       _value = 0;
    }
} 