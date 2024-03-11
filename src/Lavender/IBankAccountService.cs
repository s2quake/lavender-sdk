namespace Lavender;

public interface IBankAccountService
{
    string Authority { get; }

    AddressCollection BlockedAddresses { get; }

    RestrictionCollection Restrictions { get; }

    DenominationCollection Denominations { get; }

    void Send(Address sender, Address receiver, Coin coin);

    void SendMany(Address[] senders, Address[] receivers, Coin[] coins);

    // https://github.com/cosmos/cosmos-sdk/blob/v0.50.4/x/bank/keeper/send.go#L161
    // 어떤 이벤트 인지 감이 안옴
    // event EventHandler? Tx;

    // https://github.com/cosmos/cosmos-sdk/blob/v0.50.4/x/bank/keeper/send.go#L184
    event EventHandler? Transfered;

    // https://github.com/cosmos/cosmos-sdk/blob/v0.50.4/x/bank/keeper/send.go#L293
    event EventHandler? CoinSpent;

    // https://github.com/cosmos/cosmos-sdk/blob/v0.50.4/x/bank/keeper/send.go#L319
    event EventHandler? CoinReceived;
}