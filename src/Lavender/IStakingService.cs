namespace Lavender;

// https://github.com/cosmos/cosmos-sdk/blob/v0.50.4/x/distribution/types/expected_keepers.go#L36
// https://github.com/cosmos/cosmos-sdk/blob/v0.50.4/x/slashing/types/expected_keepers.go#L38
public interface IStakingService
{
    ValidatorCollection Validators { get; }

    DelegationCollection Delegations { get; }

    IDelegation Delegate(Address accountAddress, Address validatorAddress);

    // https://github.com/cosmos/cosmos-sdk/blob/v0.50.4/x/staking/keeper/msg_server.go#L578
    event EventHandler? UnbondingCancelled;

    // https://github.com/cosmos/cosmos-sdk/blob/v0.50.4/x/staking/keeper/val_state_change.go#L64
    event EventHandler? UnbondingCompleted;

    // https://github.com/cosmos/cosmos-sdk/blob/v0.50.4/x/staking/keeper/val_state_change.go#L104
    event EventHandler? RedelegationCompleted;
}