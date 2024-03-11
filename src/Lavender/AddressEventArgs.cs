namespace Lavender;

public class AddressEventArgs(Address address) : EventArgs
{
    public Address Address { get; } = address;
}
