public class Pair<T1, T2>
{
    public T1 First;
    public T2 Second;

    public Pair(T1 first, T2 second)
    {
        this.First = first;
        this.Second = second;
    }

    public bool Equals(Pair<T1, T2> other)
    {
        return First == other.First;
    }
}