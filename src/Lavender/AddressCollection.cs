using System.Collections;

namespace Lavender;

public sealed class AddressCollection : IEnumerable<Address>
{
    private readonly List<Address> _addressList = [];

    public IEnumerator<Address> GetEnumerator() => _addressList.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => _addressList.GetEnumerator();
}
