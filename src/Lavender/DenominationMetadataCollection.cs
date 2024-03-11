using System.Collections;
using System.Collections.Specialized;

namespace Lavender;

public sealed class DenominationMetadataCollection : IEnumerable<DenominationMetadata>
{
    private readonly OrderedDictionary _DenominationMetadataByName = [];

    public DenominationMetadata this[string name]
        => (DenominationMetadata)_DenominationMetadataByName[name]!;

    public DenominationMetadata this[int index]
        => (DenominationMetadata)_DenominationMetadataByName[index]!;

    public bool Contains(string name)
        => _DenominationMetadataByName.Contains(name);

    public IEnumerator<DenominationMetadata> GetEnumerator()
        => _DenominationMetadataByName.Values.Cast<DenominationMetadata>().GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator()
        => _DenominationMetadataByName.Values.GetEnumerator();
}
