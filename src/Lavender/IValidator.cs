namespace Lavender;

// https://github.com/cosmos/cosmos-sdk/blob/v0.50.4/x/staking/types/exported.go#L19
public interface IValidator
{
	bool IsJailed { get; }

	// string Moniker { get; }

	BondStatus Status { get; }

	Address OperatorAddress { get; }
	// ConsPubKey() (cryptotypes.PubKey, error)                        // validation consensus pubkey (cryptotypes.PubKey)
	// TmConsPublicKey() (cmtprotocrypto.PublicKey, error)             // validation consensus pubkey (CometBFT)
	// GetConsAddr() ([]byte, error)                                   // validation consensus address
	long Tokens { get; }

	long BondedTokens { get; }
	// GetConsensusPower(math.Int) int64                               // validation power in CometBFT
	// GetCommission() math.LegacyDec                                  // validator commission rate
	// GetMinSelfDelegation() math.Int                                 // validator minimum self delegation
	// GetDelegatorShares() math.LegacyDec                             // total outstanding delegator shares
	// TokensFromShares(math.LegacyDec) math.LegacyDec                 // token worth of provided delegator shares
	// TokensFromSharesTruncated(math.LegacyDec) math.LegacyDec        // token worth of provided delegator shares, truncated
	// TokensFromSharesRoundUp(math.LegacyDec) math.LegacyDec          // token worth of provided delegator shares, rounded up
	// SharesFromTokens(amt math.Int) (math.LegacyDec, error)          // shares worth of delegator's bond
	// SharesFromTokensTruncated(amt math.Int) (math.LegacyDec, error) // truncated shares worth of delegator's bond
}