using System.Collections;
using System.Collections.Specialized;

namespace Lavender;

public sealed class DenominationCollection : IEnumerable<Denomination>
{
    private readonly OrderedDictionary _denominationByName = [];

    public Denomination this[string name]
        => (Denomination)_denominationByName[name]!;

    public Denomination this[int index]
        => (Denomination)_denominationByName[index]!;

    public bool Contains(string name)
        => _denominationByName.Contains(name);

    public IEnumerator<Denomination> GetEnumerator()
        => _denominationByName.Values.Cast<Denomination>().GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator()
        => _denominationByName.Values.GetEnumerator();
}
