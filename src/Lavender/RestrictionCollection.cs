using System.Collections;

namespace Lavender;

public sealed class RestrictionCollection : IEnumerable<Restriction>
{
    private readonly List<Restriction> _restrictionList = [];

    public IEnumerator<Restriction> GetEnumerator() => _restrictionList.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => _restrictionList.GetEnumerator();
}