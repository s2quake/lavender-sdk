namespace Lavender;

// https://github.com/cosmos/cosmos-sdk/blob/v0.50.4/x/staking/types/staking.pb.go#L349
public sealed class Validator : IValidator
{
	public Address OperatorAddress { get; set; } = Address.Empty;

	public byte[] ConsensusPubkey { get; } = [];

	public bool IsJailed { get; set; }

	public BondStatus Status { get; set; }

	public long Tokens { get; set; }

	public long BondedTokens { get; set; }
	// // delegator_shares defines total shares issued to a validator's delegators.
	// DelegatorShares cosmossdk_io_math.LegacyDec `protobuf:"bytes,6,opt,name=delegator_shares,json=delegatorShares,proto3,customtype=cosmossdk.io/math.LegacyDec" json:"delegator_shares"`
	// // description defines the description terms for the validator.
	// Description Description `protobuf:"bytes,7,opt,name=description,proto3" json:"description"`

	public long UnbondingHeight { get; set; }
	// // unbonding_time defines, if unbonding, the min time for the validator to complete unbonding.
	// UnbondingTime time.Time `protobuf:"bytes,9,opt,name=unbonding_time,json=unbondingTime,proto3,stdtime" json:"unbonding_time"`
	// // commission defines the commission parameters.
	// Commission Commission `protobuf:"bytes,10,opt,name=commission,proto3" json:"commission"`
	// // min_self_delegation is the validator's self declared minimum self delegation.
	// //
	// // Since: cosmos-sdk 0.46
	// MinSelfDelegation cosmossdk_io_math.Int `protobuf:"bytes,11,opt,name=min_self_delegation,json=minSelfDelegation,proto3,customtype=cosmossdk.io/math.Int" json:"min_self_delegation"`
	// // strictly positive if this validator's unbonding has been stopped by external modules
	// UnbondingOnHoldRefCount int64 `protobuf:"varint,12,opt,name=unbonding_on_hold_ref_count,json=unbondingOnHoldRefCount,proto3" json:"unbonding_on_hold_ref_count,omitempty"`
	// // list of unbonding ids, each uniquely identifing an unbonding of this validator
	// UnbondingIds[] uint64 `protobuf:"varint,13,rep,packed,name=unbonding_ids,json=unbondingIds,proto3" json:"unbonding_ids,omitempty"`    
}