namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000326")]
internal struct XblTournamentTeamResult
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008EC")]
	internal readonly UTF8StringPtr Team; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40008ED")]
	internal readonly XblTournamentGameResultWithRank GameResult; //Field offset: 0x8

	[Address(RVA = "0x2BB8D80", Offset = "0x2BB8180", Length = "0x71")]
	[Token(Token = "0x600118C")]
	internal XblTournamentTeamResult(XblTournamentTeamResult publicObject, DisposableCollection disposableCollection) { }

}

