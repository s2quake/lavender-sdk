namespace Lavender;

public abstract class Address
{
    public static Address Empty { get; } = new EmptyAddress();

    sealed class EmptyAddress : Address
    {

    }
}
