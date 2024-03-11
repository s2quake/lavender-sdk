namespace Lavender;

public interface IBankService
{
    DenominationMetadataCollection Denominations { get; }

    Coin GetSupply(string denomination);

    void Send(Address sender, Address recipient, Coin coin);

    void Delegate(Address sender, Address recipient, Coin coin);

    void Undelegate(Address sender, Address recipient, Coin coin);

    void Mint(Address account, Coin coin);

    void Burn(Address account, Coin coin);

    // https://github.com/cosmos/cosmos-sdk/blob/v0.50.4/x/bank/keeper/keeper.go#L156
    event EventHandler? CoinSpent;

    // https://github.com/cosmos/cosmos-sdk/blob/v0.50.4/x/bank/keeper/keeper.go#L374
    event EventHandler? CoinMinted;

    // https://github.com/cosmos/cosmos-sdk/blob/v0.50.4/x/bank/keeper/keeper.go#L408
    event EventHandler? CoinBurned;
}