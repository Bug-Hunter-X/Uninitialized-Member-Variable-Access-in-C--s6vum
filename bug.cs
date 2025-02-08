public class ExampleClass
{
    private int _value;

    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public void DoSomething()
    {
        if (Value == 0)
        {
            //This line will throw a NullReferenceException if Value is not initialized before this method is called.
            Console.WriteLine(Value.ToString());
        }
    }
}