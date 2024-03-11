using System.Collections;

namespace Lavender;

public sealed class ValidatorCollection : IEnumerable<IValidator>
{
	private readonly List<IValidator> _validatorList = [];

    public IEnumerator<IValidator> GetEnumerator() => _validatorList.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => _validatorList.GetEnumerator();
}