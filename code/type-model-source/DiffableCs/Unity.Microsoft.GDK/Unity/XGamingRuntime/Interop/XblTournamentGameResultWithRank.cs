namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000325")]
internal struct XblTournamentGameResultWithRank
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008EA")]
	internal readonly XblTournamentGameResult Result; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40008EB")]
	internal readonly ulong Ranking; //Field offset: 0x8

	[Address(RVA = "0x2BB8D50", Offset = "0x2BB8150", Length = "0x20")]
	[Token(Token = "0x600118B")]
	internal XblTournamentGameResultWithRank(XblTournamentGameResultWithRank publicObject) { }

}

