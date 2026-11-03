namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002E6")]
internal struct XblLeaderboardColumn
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007E1")]
	internal readonly UTF8StringPtr statName; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40007E2")]
	internal readonly XblLeaderboardStatType statType; //Field offset: 0x8

	[Address(RVA = "0x2BB57B0", Offset = "0x2BB4BB0", Length = "0x4D")]
	[Token(Token = "0x6001137")]
	internal XblLeaderboardColumn(XblLeaderboardColumn column, DisposableCollection disposableCollection) { }

}

