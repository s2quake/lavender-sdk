namespace Lavender;

// https://github.com/cosmos/cosmos-sdk/blob/v0.50.4/x/staking/types/exported.go#L12
public interface IDelegation
{
    Address Delegator { get; }

    Address Validator { get; }

    long Shares { get; }
}
