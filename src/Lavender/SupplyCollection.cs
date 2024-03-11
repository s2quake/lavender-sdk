using System.Collections;

namespace Lavender;

public sealed class SupplyCollection : IEnumerable<Supply>
{
    private readonly List<Supply> _supplyList = [];

    public IEnumerator<Supply> GetEnumerator() => _supplyList.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => _supplyList.GetEnumerator();
}
