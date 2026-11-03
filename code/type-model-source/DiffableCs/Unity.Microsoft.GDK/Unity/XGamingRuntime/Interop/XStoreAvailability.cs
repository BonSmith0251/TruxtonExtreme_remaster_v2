namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000385")]
internal struct XStoreAvailability
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A05")]
	internal string availabilityId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000A06")]
	internal XStorePrice price; //Field offset: 0x8
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000A07")]
	internal long endDate; //Field offset: 0x48

}

