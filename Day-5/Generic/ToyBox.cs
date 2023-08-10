public class ToyBox<T> // T = type data
{
    private T Toy;

    public ToyBox(T value)
    {
        Toy = value;
    }

    public T ToyBoxMethod(T parameter)
    {
        Console.WriteLine($"Mainan : {Toy}");
        Console.WriteLine($"Parameter : {parameter}");

        return parameter;
    }
}
