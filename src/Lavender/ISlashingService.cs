namespace Lavender;

// https://github.com/cosmos/cosmos-sdk/blob/v0.50.4/x/evidence/types/expected_keepers.go#L27
public interface ISlashingService
{
    void Tombstone(Address validatorAddress);

    long Slash(Address validatorAddress, long fraction, long power, long height, InfractionType infractionType);

    void Jail(Address validatorAddress);

    void Unjail(Address validatorAddress);

    // https://github.com/cosmos/cosmos-sdk/blob/v0.50.4/x/slashing/keeper/infractions.go#L91
    event EventHandler? AfterLiveness;

    // https://github.com/cosmos/cosmos-sdk/blob/v0.50.4/x/slashing/keeper/keeper.go#L100
    // https://github.com/cosmos/cosmos-sdk/blob/v0.50.4/x/slashing/keeper/keeper.go#L117
    // https://github.com/cosmos/cosmos-sdk/blob/v0.50.4/x/slashing/keeper/infractions.go#L137
    event EventHandler<SlashedEventArgs>? Slashed;
}