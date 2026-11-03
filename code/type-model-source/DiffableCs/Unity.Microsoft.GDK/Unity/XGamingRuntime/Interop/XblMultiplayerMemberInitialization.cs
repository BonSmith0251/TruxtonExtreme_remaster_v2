namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000318")]
internal struct XblMultiplayerMemberInitialization
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008B2")]
	internal readonly ulong JoinTimeout; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40008B3")]
	internal readonly ulong MeasurementTimeout; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40008B4")]
	internal readonly ulong EvaluationTimeout; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40008B5")]
	internal readonly NativeBool ExternalEvaluation; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40008B6")]
	internal readonly uint MembersNeededToStart; //Field offset: 0x1C

	[Address(RVA = "0x2BB6720", Offset = "0x2BB5B20", Length = "0x3A")]
	[Token(Token = "0x600117A")]
	internal XblMultiplayerMemberInitialization(XblMultiplayerMemberInitialization publicObject) { }

}

