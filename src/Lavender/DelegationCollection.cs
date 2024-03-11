using System.Collections;

namespace Lavender;

public sealed class DelegationCollection : IEnumerable<IDelegation>
{
	private readonly List<IDelegation> _delegationList = [];

    public IEnumerator<IDelegation> GetEnumerator() => _delegationList.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => _delegationList.GetEnumerator();
}