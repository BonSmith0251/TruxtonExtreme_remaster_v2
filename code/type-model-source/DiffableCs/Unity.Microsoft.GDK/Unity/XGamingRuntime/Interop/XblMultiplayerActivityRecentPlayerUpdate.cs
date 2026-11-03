namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200030F")]
internal struct XblMultiplayerActivityRecentPlayerUpdate
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000897")]
	internal readonly ulong xuid; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000898")]
	internal readonly XblMultiplayerActivityEncounterType encounterType; //Field offset: 0x8

	[Address(RVA = "0x2BB6510", Offset = "0x2BB5910", Length = "0x20")]
	[Token(Token = "0x6001173")]
	internal XblMultiplayerActivityRecentPlayerUpdate(XblMultiplayerActivityRecentPlayerUpdate publicObject) { }

}

