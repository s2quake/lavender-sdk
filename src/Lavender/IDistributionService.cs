namespace Lavender;

public interface IDistributionService
{
    // https://github.com/cosmos/cosmos-sdk/blob/v0.50.4/x/gov/types/expected_keepers.go#L35
    // FundCommunityPool(ctx context.Context, amount sdk.Coins, sender sdk.AccAddress) error

    // https://github.com/cosmos/cosmos-sdk/blob/v0.50.4/x/distribution/keeper/keeper.go#L80
    void SetWithdrawAddress(Address delegator, Address withdrawAddress);

    // https://github.com/cosmos/cosmos-sdk/blob/v0.50.4/x/distribution/keeper/allocation.go#L97
    event EventHandler? CommissionAllocated;

    // https://github.com/cosmos/cosmos-sdk/blob/v0.50.4/x/distribution/keeper/allocation.go#L128
    event EventHandler? RewardAllocated;

    // https://github.com/cosmos/cosmos-sdk/blob/v0.50.4/x/distribution/keeper/delegation.go#L310
    event EventHandler? RewardsWithdrawn;

    // https://github.com/cosmos/cosmos-sdk/blob/v0.50.4/x/distribution/keeper/keeper.go#L180
    event EventHandler? CommissionWithdrawn;
}